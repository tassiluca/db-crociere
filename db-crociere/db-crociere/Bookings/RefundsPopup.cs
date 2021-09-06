using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_crociere.Bookings
{
    public partial class RefundsPopup : Form
    {

        private DataClassesDBCrociereDataContext db;
        private DateTime cancellationDate { get; set; }
        private int noticePeriod { get; set; }
        private int refundCode { get; set; }


        public RefundsPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            InitializeComponent();
        }

        private void BookingComboBox_Click(object sender, EventArgs e)
        {
            var cancelledBookings = (from a in db.ANNULLAMENTI
                                    select a.CodPrenotazione);
            var bookings = (from p in db.PRENOTAZIONI
                           select p.CodPrenotazione).Except(cancelledBookings);
            BookingComboBox.DataSource = bookings;
        }

        private int calcRefund(int bookingPriceCod, int refundPercentage)
        {
            int bookingPrice = (int)(from p in db.PAGAMENTI
                                     where p.CodTransazione == bookingPriceCod
                                     select p.Importo).First();
            return (bookingPrice * refundPercentage) / 100;
        }

        private void BookingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookingComboBox.SelectedIndex != -1)
            {
                var booking = (from p in db.PRENOTAZIONI
                               where p.CodPrenotazione == int.Parse(BookingComboBox.Text)
                               select p).First();
                cancellationDate = DateTime.Now;
                noticePeriod = booking.DataOraImbarco.Subtract(cancellationDate).Days;
                NoticeTextBox.Text = noticePeriod.ToString();

                // non per forza c'è il rimborso 
                var refund = from r in db.RIMBORSI
                             where noticePeriod >= r.Preavviso_Dal &&
                                   noticePeriod <= r.Preavviso_Al
                             select new
                             {
                                 refundCode = r.CodRimborso,
                                 refundPercentage = r.PercentualeRimborso
                             };
                if (refund.Any())
                {
                    refundCode = (int)refund.First().refundCode;
                    RefundTextBox.Text = calcRefund(
                        (int)booking.CodTransazione, 
                        (int)refund.First().refundPercentage).ToString();
                }
                else
                {
                    RefundTextBox.Text = "NESSUN RIMBORSO";
                }
            }
            else
            {
                cancellationDate = new DateTime();
                refundCode = 0;
                noticePeriod = 0;
                NoticeTextBox.Clear();
                RefundTextBox.Clear();
            }
        }

        private void CancelBookingBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                int booking = int.Parse(BookingComboBox.Text);

                /* Inserts the new path. */
                ANNULLAMENTI annullamento = new ANNULLAMENTI
                {
                    CodPrenotazione = booking,
                    DataRichiesta = cancellationDate,
                    CodRimborso = refundCode
                };
                db.ANNULLAMENTI.InsertOnSubmit(annullamento);

                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                Utilities.ShowErrorMessage(msg);
                db = new DataClassesDBCrociereDataContext();
            }
            Utilities.ClearAll(this);
        }
    }
}
