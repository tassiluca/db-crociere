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
            RequiredTextValidation(HeightInfoTextBox, e);
        }

        private void CabinsNumTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(CabinsNumTextBox, e);
        }

        private void AddShipInfoBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                /* check con TryParse */
                string name = ShipNameTextBox.Text;
                int length = int.Parse(LengthTextBox.Text);
                int width = int.Parse(WidthTextBox.Text);
                int weight = int.Parse(WeightTextBox.Text);
                int height = int.Parse(HeightInfoTextBox.Text);
                int cabinsNum = int.Parse(CabinsNumTextBox.Text);

                /*
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

                try
                {
                    db.SubmitChanges();
                    Console.WriteLine("Inserita correttamente una nuova nave");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
                */
            }
        }
    }
}
