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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void onShipTabClick(object sender, EventArgs e)
        {
            /**
             * Un esempio con i porti...
             */
            DataClasses1DataContext db = new DataClasses1DataContext();
            var res = from porti in db.PORTIs
                      select new { porti.Città };
            shipListBox.DataSource = res;
        }

        private void test(object sender, EventArgs e)
        {
            Console.WriteLine("Hello validate: ", sender);
        }

        private void shipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddShipBtn_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
