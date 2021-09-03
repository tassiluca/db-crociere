using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_crociere
{
    public static class Utilities
    {

        /// <summary>
        /// Get all controls of type given in input.
        /// </summary>
        /// <param name="control">The control visual representation.</param>
        /// <param name="type">The type of the control.</param>
        /// <returns>IENumerable with all the controls.</returns>
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        /// <summary>
        /// Clears all the visual components of the form or set them to their
        /// actual value (i.e. for DateTimePicker).
        /// </summary>
        public static void ClearAll(Control control)
        {
            foreach (TextBox elem in GetAll(control, typeof(TextBox)))
            {
                elem.Clear();
            }
            foreach (RichTextBox elem in GetAll(control, typeof(RichTextBox)))
            {
                elem.Clear();
            }
            foreach (ComboBox elem in GetAll(control, typeof(ComboBox)))
            {
                elem.SelectedIndex = -1;
            }
            foreach (DateTimePicker elem in GetAll(control, typeof(DateTimePicker)))
            {
                /* COULD CREATE PROBLEMS IN BOOKINGS (in navigation combobox) 
                 * If this happens test it with: elem.Value = DateTime.Now;
                 * @see shorturl.at/gkmuS */
                elem.Value = DateTime.Today;
            }
        }

        /// <summary>
        /// Shows error message box.
        /// </summary>
        /// <param name="msg">The message to display.</param>
        public static void ShowErrorMessage(string msg)
        {
            MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
