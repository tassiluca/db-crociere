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

        /// <summary>
        /// Inserts new price list into the database.
        /// </summary>
        /// <param name="control">The control visual representation.</param>
        /// <param name="type">The type of the control.</param>
        private void AddShipInfoBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string shipName = ShipNameComboBox.Text;
                string type = TypeComboBox.Text;
                DateTime start = StartDatePicker.Value.Date;
                DateTime end = EndDatePicker.Value.Date;
                int price = int.Parse(PriceTextBox.Text);

                TARIFFARI tariffario = new TARIFFARI
                {
                    NomeNave = shipName,
                    NomeTipologia = type,
                    DataInizio = start,
                    DataFine = end,
                    Prezzo = price
                };

                db.TARIFFARIs.InsertOnSubmit(tariffario);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Utilities.ClearAll(this);
        }
    }
}
