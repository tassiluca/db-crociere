using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace db_crociere
{
    public partial class App : Form
    {
        DataClassesDBCrociereDataContext db = new DataClassesDBCrociereDataContext();
        public App()
        {
            InitializeComponent();
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
            if (ships.Count() > 0)
            {
                fillShipInfo(ships.ToArray()[0]);
                fillPathInfo(ships.ToArray()[0]);
            }        
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
            NavigationDropDownMenu_Click(sender, e);
        }

        private void addPrenBtn_Click(object sender, EventArgs e)
        {
            AddPrenPopup AddPrenPopup_window = new AddPrenPopup(db);
            AddPrenPopup_window.ShowDialog(this);
        }

        private void NavigationDropDownMenu_Click(object sender, EventArgs e)
        {
            var nav = from n in db.NAVIGAZIONIs
                      where n.NomeNave == ShipNameLabel.Text
                      select n.CodNavigazione;

            if (nav.Count() == 0)
            {
                NavigationDropDownMenu.SelectedIndex = -1;
            }
            NavigationDropDownMenu.DataSource = nav;
        }

        private void NavigationDropDownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NavigationDropDownMenu.SelectedIndex != -1)
            {
                var exSecs = from et in db.ESECUZIONI_TRATTAs
                             from t in db.TRATTEs
                             where et.CodNavigazione == int.Parse(NavigationDropDownMenu.SelectedItem.ToString()) &&
                                   et.CodTratta == t.CodTratta
                             select new
                             {
                                 Tratta = et.CodTratta,
                                 Porto_Partenza = t.CodPortoPartenza,
                                 Porto_Arrivo = t.CodPortoArrivo,
                                 Navigazione = et.CodNavigazione,
                                 Data_Partenza = et.Partenza_Data,
                                 Orario_Partenza = et.Partenza_Ora,
                                 Data_Arrivo = et.Arrivo_Data,
                                 Orario_Arrivo = et.Arrivo_Ora,
                             };
                NavigationExecutionGridView.DataSource = exSecs;
            }
        }

        private void AddExpensesBtn_Click(object sender, EventArgs e)
        {
            AddExpensesPopup AddExpensesPopup_Window = new AddExpensesPopup(db);
            AddExpensesPopup_Window.ShowDialog(this);
        }

        private void ShipNameComboBox_Click(object sender, EventArgs e)
        {
            var ships = from n in db.NAVIs
                        select n.Nome;
            ShipNameComboBox.DataSource = ships;
        }

        private void ShipNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prices = from t in db.TARIFFARIs
                         where t.NomeNave == ShipNameComboBox.Text
                         select new
                         {
                             Tipologia = t.NomeTipologia,
                             Data_Inizio = t.DataInizio,
                             Data_Fine = t.DataFine,
                             Prezzo = t.Prezzo
                         };
            PriceListGridView.DataSource = prices;
        }

        private void RankingPath(object sender, EventArgs e)
        {
            var rank = (from p in db.PRENOTAZIONIs
                        from n in db.NAVIGAZIONIs
                        where p.CodNavigazione == n.CodNavigazione &&
                              p.DataEffettuazione.Year == DateTime.Now.Year
                        group n by n.CodPercorso into paths
                        select new
                        {
                            Percorso = paths.Key,
                            Numero_Prenotazioni = paths.Count()
                        }).OrderByDescending(p => p.Numero_Prenotazioni);
            RankPathGridView.DataSource = rank;

            foreach (var elem in rank)
            {
                Series series = this.chart1.Series.Add(elem.Percorso);
                series.Points.Add(elem.Numero_Prenotazioni);
            }
        }

        private void AddPathBtn_Click(object sender, EventArgs e)
        {
            AddNavigationPopup AddNavigationPopup_Window = new AddNavigationPopup(db);
            AddNavigationPopup_Window.ShowDialog(this);
        }
    }
}
