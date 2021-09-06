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
    public partial class Main : Form
    {
        Timer tmr;

        public Main()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            App app = new App();
            app.Show();
            this.Hide();
        }

    }
}
