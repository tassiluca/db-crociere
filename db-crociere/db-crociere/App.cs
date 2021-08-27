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
        DataClassesDBCrociereDataContext db = new DataClassesDBCrociereDataContext();
        public App()
        {
            InitializeComponent();
        }

        private void initNavigation()
        {
            var res = from porti in db.PORTIs
                      select new { porti.CodPorto };
            NavigationDropDownMenu.DataSource = res;
        }

        private Dictionary<Label, string> getShipCode(string shipName)
        {
            var shipInfos = new Dictionary<Label, string>();
            
            shipInfos.Add(ShipNameLabel, shipName);

            var code = from navi in db.NAVIs
                        where String.Equals(navi.Nome, shipName) == true
                        select navi.CodNave;
            shipInfos.Add(ShipCodeLabel, code.First().ToString());

            var width = from navi in db.NAVIs
                        where navi.Nome == shipName
                        select navi.Larghezza;
            shipInfos.Add(WidthLabel, width.First().ToString());

            var length = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Lunghezza;
            shipInfos.Add(LengthLabel, length.First().ToString());

            var weight = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Peso;
            shipInfos.Add(WeightLabel, weight.First().ToString());

            var height = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Altezza;
            shipInfos.Add(HeightLabel, height.First().ToString());

            var cabins = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.NumeroCabine;
            shipInfos.Add(CabinsNumLabel, cabins.First().ToString());

            return shipInfos;
        }

        private void fillShipInfo(String shipName)
        {
            var shipInfos = getShipCode(shipName);
            foreach (KeyValuePair<Label, string> elem in shipInfos)
            {
                elem.Key.Text = elem.Value;
            }
        }

        private void fillPathInfo(String shipName)
        {
            var path = from p in db.PERCORSIs
                       where p.NomeNave == shipName
                       select new
                       {
                           COD_PATH = p.CodPercorso,
                           DURATION = p.GiorniDurata,
                       };

            string defaultMsg = "Non ancora inserito";
            PathCodeLabel.Text = path.Count() == 0 ? defaultMsg : path.FirstOrDefault().COD_PATH;
            DurationLabel.Text = path.Count() == 0 ? defaultMsg : path.First().DURATION.ToString();

            if (path.Count() > 0)
            {
                var sections = from sq in db.SEQUENZE_TRATTEs
                               from t in db.TRATTEs
                               from p1 in db.PORTIs
                               from p2 in db.PORTIs
                               where sq.CodPercorso == path.First().COD_PATH &&
                                     sq.CodTratta == t.CodTratta &&
                                     p1.CodPorto == t.CodPortoPartenza &&
                                     p2.CodPorto == t.CodPortoArrivo
                               select new
                               {
                                   Percorso = sq.CodPercorso,
                                   Tratta = sq.CodTratta,
                                   Partenza = p1.Città,
                                   Arrivo = p2.Città,
                                   Ordine = sq.Ordine
                               };
                SectionsGridView.DataSource = sections;
                SectionsGridView.Sort(SectionsGridView.Columns["Ordine"], ListSortDirection.Ascending);
            } else
            {
                SectionsGridView.Rows.Clear();
            }

        }

        private void updateShipList(object sender, EventArgs e)
        {
            var ships = from navi in db.NAVIs
                        select navi.Nome;
            shipListBox.DataSource = ships;
            if(ships.Count() > 0)
            {
                fillShipInfo(ships.ToArray()[0]);
                fillPathInfo(ships.ToArray()[0]);
                initNavigation();
            }
        
        }

        private void shipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("INDEX SHIPLIST CHANGED");
        }

        private void AddShipBtnClick(object sender, EventArgs e)
        {
            var addShipPopup = new AddShipPopup(db);
            addShipPopup.ShowDialog(this);
        }

        private void App_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("FOCUS");
            updateShipList(sender, e);
        }

        private void shipListBox_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CAMBIATA SELEZIONE NAVE");
            var shipName = shipListBox.SelectedItem.ToString();
            fillShipInfo(shipName);
            fillPathInfo(shipName);
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
            foreach(var p in nav)
            {
                avaiableDateRanges.Add(new DateRange(p.startNavDate,p.endNavDate));
            }
            
            navSelPren.DataSource = avaiableDateRanges;

        }

        private void bookingTab_Enter(object sender, EventArgs e)
        {
            
            var path = from p in db.PERCORSIs
                        select p.CodPercorso;
            pathSelPren.DataSource = path;
        }

        private void App_Load(object sender, EventArgs e)
        {
                       

        }
    }

    class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public DateRange(DateTime Start, DateTime End) {
            this.Start = Start;
            this.End = End;
        }

        public override string ToString()
        {
            return this.Start.ToString() + " - " + this.End.ToString();
        }
    }
}
