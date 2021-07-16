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
    }
}
