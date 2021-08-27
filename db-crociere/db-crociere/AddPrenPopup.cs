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
    public partial class AddPrenPopup : Form
    {
        private DataClassesDBCrociereDataContext db;
        public AddPrenPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            InitializeComponent();
        }

        private void pathSelPren_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pathCode = pathSelPren.SelectedItem.ToString();
            var nav = from n in db.NAVIGAZIONIs
                      where n.CodPercorso == pathCode
                      orderby n.DataInizio
                      select new
                      {
                          startNavDate = n.DataInizio,
                          endNavDate = n.DataFine
                      };

            List<DateRange> avaiableDateRanges = new List<DateRange>();
            foreach (var p in nav)
            {
                avaiableDateRanges.Add(new DateRange(p.startNavDate, p.endNavDate));
            }

            navSelPren.DataSource = avaiableDateRanges;

        }

        private void bookingTab_Enter(object sender, EventArgs e)
        {

            var path = from p in db.PERCORSIs
                       select p.CodPercorso;
            pathSelPren.DataSource = path;
        }

    }
}
