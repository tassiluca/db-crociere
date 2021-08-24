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
        public AddShipPopup()
        {
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

        private void ShipCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextValidation(ShipCodeTextBox, e);
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
            Console.WriteLine(ValidateChildren(ValidationConstraints.Enabled));
        }

    }
}
