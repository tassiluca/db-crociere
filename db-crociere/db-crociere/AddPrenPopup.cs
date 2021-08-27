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
        private void pathSelPren_Click(object sender, EventArgs e)
        {
            this.navDateMap.Clear();
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
                navDateMap.Add(rd.ToStringDate(),rd);
                avaiableDateRanges.Add(rd.ToStringDate());
            }
            navPeriodSelector.DataSource = avaiableDateRanges;
        }

        private void portSelPren_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedPeriod = navPeriodSelector.SelectedItem.ToString();
            var pathCode = pathSelPren.SelectedItem.ToString();
            var startDate = this.navDateMap[selectedPeriod].StartDate;
            //mostra tutti i porti che ci sono nel percorso
            //TODO
            /* var port = from p in db.PERCORSIs db.SEQUENZE_TRATTEs
                       where p
                       select p;
            */
        }
    }
}
