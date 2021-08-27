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
        private Dictionary<String, DateRange> navDateMap;

        private DataClassesDBCrociereDataContext db;
        public AddPrenPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            navDateMap = new Dictionary<string, DateRange>();
            InitializeComponent();
        }

        private void AddPrenPopup_Load(object sender, EventArgs e)
        {
            var path = from p in db.PERCORSIs
                        select p.CodPercorso;
            pathSelPren.DataSource = path;
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

            List<String> avaiableDateRanges = new List<String>();
            foreach (var p in nav)
            {
                var rd = new DateRange(p.startNavDate, p.endNavDate);
                navDateMap.Add(rd.ToString(),rd);
                avaiableDateRanges.Add(rd.ToString());
            }

            navPeriodSelector.DataSource = avaiableDateRanges;
        }

        private void portSelPren_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedPeriod = navPeriodSelector.SelectedItem.ToString();
            var startDate = this.navDateMap[selectedPeriod].StartDate;
            var nav = from est in db.ESECUZIONI_TRATTAs
                      where est.Partenza_Data == startDate;
                     /* and 
                      select new
                      {
                     
                      };*/
        }
    }
}
