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
using db_crociere.Staff;
using db_crociere.Activities;

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

            var code = from navi in db.NAVI
                        where String.Equals(navi.Nome, shipName) == true
                        select navi.CodNave;
            shipInfos.Add(ShipCodeLabel, code.First().ToString());

            var width = from navi in db.NAVI
                        where navi.Nome == shipName
                        select navi.Larghezza;
            shipInfos.Add(WidthLabel, width.First().ToString());

            var length = from navi in db.NAVI
                         where navi.Nome == shipName
                         select navi.Lunghezza;
            shipInfos.Add(LengthLabel, length.First().ToString());

            var weight = from navi in db.NAVI
                         where navi.Nome == shipName
                         select navi.Peso;
            shipInfos.Add(WeightLabel, weight.First().ToString());

            var height = from navi in db.NAVI
                         where navi.Nome == shipName
                         select navi.Altezza;
            shipInfos.Add(HeightLabel, height.First().ToString());

            var cabins = from navi in db.NAVI
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
            var path = from p in db.PERCORSI
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
                var sections = from sq in db.SEQUENZE_TRATTE
                               from t in db.TRATTE
                               from p1 in db.PORTI
                               from p2 in db.PORTI
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
            var ships = from navi in db.NAVI
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
            var nav = from n in db.NAVIGAZIONI
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
                var exSecs = from et in db.ESECUZIONI_TRATTA
                             from t in db.TRATTE
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
            } else
            {
                NavigationExecutionGridView.DataSource = null;
            }
        }

        private void AddExpensesBtn_Click(object sender, EventArgs e)
        {
            AddExpensesPopup AddExpensesPopup_Window = new AddExpensesPopup(db);
            AddExpensesPopup_Window.ShowDialog(this);
        }

        private void ShipNameComboBox_Click(object sender, EventArgs e)
        {
            var ships = from n in db.NAVI
                        select n.Nome;
            ShipNameComboBox.DataSource = ships;
        }

        private void ShipNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prices = from t in db.TARIFFARI
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

        private void AddPathBtn_Click(object sender, EventArgs e)
        {
            AddNavigationPopup AddNavigationPopup_Window = new AddNavigationPopup(db);
            AddNavigationPopup_Window.ShowDialog(this);
        }

        private void BadgeIdComboBox_Click(object sender, EventArgs e)
        {
            var badges = from b in db.BADGE
                         select b.CodBadge;
            BadgeIdComboBox.DataSource = badges;
        }

        private void BadgeIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var expenses = from se in db.SPESE_EXTRA
                           where se.CodBadge == int.Parse(BadgeIdComboBox.Text)
                           select new
                           {
                               Codice_Spesa = se.CodiceSpesa,
                               Badge = se.CodBadge,
                               Data = se.DataSpesa,
                               Importo = se.Importo,
                               Descrizione = se.Descrizione
                           };
            ExpensesGridView.DataSource = expenses;
        }

        private void RankingPathBtn_Click(object sender, EventArgs e)
        {
            var rank = (from p in db.PRENOTAZIONI
                        from n in db.NAVIGAZIONI
                        where p.CodNavigazione == n.CodNavigazione &&
                              p.DataEffettuazione.Year == DateTime.Now.Year
                        group n by n.CodPercorso into paths
                        select new
                        {
                            Percorso = paths.Key,
                            Prenotazioni = paths.Count()
                        }).OrderByDescending(p => p.Prenotazioni);
            RankPathGridView.DataSource = rank;

            foreach (var elem in rank)
            {
                Series series = this.chart1.Series.Add(elem.Percorso);
                series.Points.Add(elem.Prenotazioni);
            }
        }

        private void AverageBookingsCostsBtn_Click(object sender, EventArgs e)
        {
            var rank = from n in db.NAVIGAZIONI
                       from pa in db.PAGAMENTI
                       from pr in db.PRENOTAZIONI
                       where pa.CodTransazione == pr.CodTransazione &&
                             n.CodNavigazione == pr.CodNavigazione
                       group pa by n.CodPercorso into paths
                       select new
                       {
                           Percorso = paths.Key,
                           Costo_Medio = paths.Average(p => p.Importo)
                       };
            RankCostsGridView.DataSource = rank;
            foreach (var elem in rank)
            {
                Series series = this.chart2.Series.Add(elem.Percorso);
                series.Points.Add(Decimal.ToDouble(elem.Costo_Medio));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaffPopup addStaffPopupWindow = new AddStaffPopup(db);
            addStaffPopupWindow.ShowDialog(this);
        }

        private void AddActivitiesBtn_Click(object sender, EventArgs e)
        {
            AddActivitiesPopup addActivitiesPopup = new AddActivitiesPopup(db);
            addActivitiesPopup.ShowDialog(this);
        }


    }
}
