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
            var ships = from n in db.NAVI
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
            var types = from t in db.TIPOLOGIE
                        select t.Nome;
            TypeComboBox.DataSource = types;
        }

        /// <summary>
        /// Checks integrity. In details checks there are no price lists with overlapping
        /// dates.
        /// </summary>
        /// <param name="shipName"></param>
        /// <param name="type"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>False if one of the checks is violated. True otherwise.</returns>
        private bool CheckPrices(string shipName, string type, DateTime start, DateTime end)
        {
            var intersections = (from t in db.TARIFFARI
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

                if (!CheckPrices(shipName, type, start, end))
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

                db.TARIFFARI.InsertOnSubmit(tariffario);
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
                DateTime date = DateExpensePicker.Value.Date;
                int amount = int.Parse(AmountExpenseTextBox.Text);
                string infos = InfosTextBox.Text;

                SPESE_EXTRA spesa = new SPESE_EXTRA
                {
                    CodBadge = badge,
                    DataSpesa = date,
                    Importo = amount,
                    Descrizione = infos
                };

                db.SPESE_EXTRA.InsertOnSubmit(spesa);
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
        /// Add new refund into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRefundBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                var code = (from r in db.RIMBORSI
                            select r.CodRimborso)
                            .OrderByDescending(x => x)
                            .FirstOrDefault() + 1;
                int from = int.Parse(FromNoticeTextBox.Text);
                int to = int.Parse(ToNoticeTextBox.Text);
                int refund = int.Parse(RefundTextBox.Text);

                RIMBORSI rimborso = new RIMBORSI
                {
                    CodRimborso = code,
                    Preavviso_Dal = from,
                    Preavviso_Al = to,
                    PercentualeRimborso = refund
                };

                db.RIMBORSI.InsertOnSubmit(rimborso);
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
