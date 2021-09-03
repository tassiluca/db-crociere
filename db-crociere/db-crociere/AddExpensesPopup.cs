using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_crociere
{
    public partial class AddExpensesPopup : Form
    {
        private DataClassesDBCrociereDataContext db;

        public AddExpensesPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            InitializeComponent();
        }

        /// <summary>
        /// Populates the shipname combobox.
        /// </summary>
        /// <param name="control">The control visual representation.</param>
        /// <param name="type">The type of the control.</param>
        private void ShipNameComboBox_Click(object sender, EventArgs e)
        {
            var ships = from n in db.NAVIs
                        select n.Nome;
            ShipNameComboBox.DataSource = ships;
        }

        /// <summary>
        /// Populates the type combobox.
        /// </summary>
        /// <param name="control">The control visual representation.</param>
        /// <param name="type">The type of the control.</param>
        private void TypeComboBox_Click(object sender, EventArgs e)
        {
            var types = from t in db.TIPOLOGIEs
                        select t.Nome;
            TypeComboBox.DataSource = types;
        }

        private bool checkPrices(string shipName, string type, DateTime start, DateTime end)
        {
            var intersections = (from t in db.TARIFFARIs
                                 where t.NomeNave == shipName && t.NomeTipologia == type &&
                                       ((start >= t.DataInizio && start <= t.DataFine) ||
                                        (end >= t.DataInizio && end <= t.DataFine) ||
                                        (t.DataInizio >= start && t.DataFine <= end) ||
                                        (t.DataFine >= start && t.DataFine <= end))
                                 select t.CodTariffario).Count();
            return intersections == 0;
        }

        /// <summary>
        /// Inserts new price list into the database.
        /// </summary>
        /// <param name="control">The control visual representation.</param>
        /// <param name="type">The type of the control.</param>
        private void AddPriceBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string shipName = ShipNameComboBox.Text;
                string type = TypeComboBox.Text;
                DateTime start = StartDatePicker.Value.Date;
                DateTime end = EndDatePicker.Value.Date;
                int price = int.Parse(PriceTextBox.Text);

                Console.WriteLine(shipName +" "+ type + " " + start + " " + end + " " + price);

                if (!checkPrices(shipName, type, start, end))
                {
                    msg = "Intersezione date con un'altra tariffa già presente nel DB!";
                    throw new ArgumentException(msg);
                }

                TARIFFARI tariffario = new TARIFFARI
                {
                    NomeNave = shipName,
                    NomeTipologia = type,
                    DataInizio = start,
                    DataFine = end,
                    Prezzo = price
                };

                Console.WriteLine(tariffario.NomeNave + " " + tariffario.NomeTipologia + " " 
                    + tariffario.DataInizio + " " + tariffario.DataFine + " " + tariffario.Prezzo);

                db.TARIFFARIs.InsertOnSubmit(tariffario);
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

        /// <summary>
        /// Inserts a new expense to the database.
        /// </summary>
        /// <param name="control">The control visual representation.</param>
        /// <param name="type">The type of the control.</param>
        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                int badge = int.Parse(BadgeIdTextBox.Text);
                var booking = (from b in db.BADGEs
                               where b.CodBadge == badge
                               select b.CodPrenotazione).First();
                DateTime date = DateExpensePicker.Value.Date;
                int amount = int.Parse(AmountExpenseTextBox.Text);
                string infos = InfosTextBox.Text;

                SPESE_EXTRA spesa = new SPESE_EXTRA
                {
                    CodBadge = badge,
                    CodPrenotazione = booking,
                    DataSpesa = date,
                    Importo = amount,
                    Descrizione = infos
                };

                db.SPESE_EXTRAs.InsertOnSubmit(spesa);
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
