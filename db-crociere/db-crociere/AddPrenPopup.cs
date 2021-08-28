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
        private Dictionary<String, DateRange> navDateMap;
        private decimal navCodPathSelected;
        
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
                          codNav = n.CodNavigazione,
                          startNavDate = n.DataInizio,
                          endNavDate = n.DataFine
                      };

            List<String> avaiableDateRanges = new List<String>();
            
            if (nav.Count() > 0)
            {
                foreach (var p in nav)
                {
                    var rd = new DateRange(p.startNavDate, p.endNavDate);
                    navDateMap.Add(rd.ToStringDate(),rd);
                    avaiableDateRanges.Add(rd.ToStringDate());
                }
                navCodPathSelected = nav.First().codNav;
            }
            else {
                navPeriodSelector.Text = "Nessuna Navigazione";
                portSelPren.Text = "Nessuna Tratta";
                portSelPren.DataSource = new List<String>();
                //MessageBoxPrenot("Non risultano navigazioni per il percorso scelto","ERRORE");
            }
           
            navPeriodSelector.DataSource = avaiableDateRanges;
        }
        private void navPeriodSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> avaiblePort = new List<String>();
            String selectedPeriod = navPeriodSelector.SelectedItem.ToString();
            var startDateNav = this.navDateMap[selectedPeriod].StartDate;
            var endDateNav = this.navDateMap[selectedPeriod].EndDate;
            /*select all the esecuziioni_tratta that are part of navigation with id = navCodPathSelected
             * and are inside the period selected
            */
             var path_sections = from t in db.ESECUZIONI_TRATTAs
                                where t.CodNavigazione == navCodPathSelected
                                && t.Partenza_Data >= startDateNav
                                && t.Arrivo_Data <= endDateNav
                                select t;
            
            if (path_sections.Count() > 0)
            {
                foreach (var ps in path_sections)
                { //TODO ora ho messo codTratta ma ci andrebbe il nome del porto di partenza
                    avaiblePort.Add(ps.CodTratta.ToString());
                    //navDateMap.Add(rd.ToStringDate(), rd);
                }
            }
            else {
                portSelPren.Text = "Nessuna Tratta";
                Console.WriteLine(avaiblePort);
                //MessageBoxPrenot("Non risultano tratte per il periodo scelto", "ERRORE");
            }
            
            portSelPren.DataSource = avaiblePort;

        }
        private void portSelPren_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void MessageBoxPrenot(String msg, String msgType) {
            MessageBox.Show(msg, msgType);
        }

    }
}
