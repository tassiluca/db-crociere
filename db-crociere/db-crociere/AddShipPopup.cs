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
    public partial class AddShipPopup : Form
    {
        private DataClassesDBCrociereDataContext db;

        public AddShipPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            InitializeComponent();
        }

        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void RequiredTextValidation(TextBox tb, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                tb.Focus();
                errorProviderInfo.SetError(tb, "Field should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderInfo.SetError(tb, "");
            }
        }

        private void ShipNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(ShipNameTextBox, e);
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(WidthTextBox, e);
        }

        private void LengthTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(LengthTextBox, e);
        }

        private void WeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(WeightTextBox, e);
        }

        private void HeightInfoTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(HeightTextBox, e);
        }

        private void CabinsNumTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(CabinsNumTextBox, e);
        }

        private void AddShipInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                int length, width, weight, height, cabinsNum;

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    name = ShipNameTextBox.Text;
                    length = int.Parse(LengthTextBox.Text);
                    width = int.Parse(WidthTextBox.Text);
                    weight = int.Parse(WeightTextBox.Text);
                    height = int.Parse(HeightTextBox.Text);
                    cabinsNum = int.Parse(CabinsNumTextBox.Text);

                    /* Inserimento di una nuova nave */
                    NAVI nave = new NAVI
                    {
                        Nome = name,
                        Larghezza = width,
                        Lunghezza = length,
                        Peso = weight,
                        Altezza = height,
                        NumeroCabine = cabinsNum
                    };

                    db.NAVIs.InsertOnSubmit(nave);
                    db.SubmitChanges();
                    var msg = "Inserimento avvenuto con SUCCESSO";
                    MessageBox.Show(msg, "SUCCESSO");
                }
            }
            catch (Exception exc)
            {
                var msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.ToString() + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShipNameComboPath_Click(object sender, EventArgs e)
        {
            var ships = from navi in db.NAVIs
                        select navi.Nome;
            ShipNameComboPath.DataSource = ships;
        }
    }
}
