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
using db_crociere.Bookings;

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
            updatePrenRimbTable();
            updatePayPrenSelector();
            updatePrenCancelled();
        }

        private void updatePrenCancelled()
        {
            var cancelled = from c in db.ANNULLAMENTI
                            select new {
                                c.CodPrenotazione,
                                c.DataRichiesta,
                                c.CodRimborso
                            };
            cancelledPrenview.DataSource =cancelled;
        }

        private void updatePayPrenSelector()
        {
            var pren = from p in db.PRENOTAZIONI
                       select p.CodPrenotazione;
            prenotSelector.DataSource = pren;
        }

        private void refreshPaymentInf(object sender, EventArgs e)
        {
            var selectedPren = prenotSelector.SelectedItem.ToString();
            var paym = getPayment(selectedPren);
            var ratePagate = from r in db.RATE
                                where r.CodTransazione == paym.CodTransazione
                                select r;
            var annullati = from a in db.ANNULLAMENTI
                            where a.CodPrenotazione == Decimal.Parse(selectedPren)
                            select a;
            pricePrenField.Text = paym.Importo.ToString();
            pagarataLabel.Text = "*La rata viene inserita con data odierna: " + DateTime.Now.Date;

            if (annullati.Count() > 0) {
                annullataLabel.Text = "Annullata";
            }
            else
            {
                annullataLabel.Text = "";
            }

            if (paym.NumeroRate != null && paym.Anticipo != null)
            {
                var rateRimaste = paym.NumeroRate - ratePagate.Count();
                DateTime dataUltimaRata;
                if (ratePagate.Count() > 0)
                {
                    dataUltimaRata = ratePagate.OrderBy(r => r.DataPagamento).First().DataPagamento;
                }
                else {
                    dataUltimaRata = DateTime.MinValue;
                }
                rataCostField.Text = ((paym.Importo - paym.Anticipo) / paym.NumeroRate).ToString();
                rateToPayField.Text = rateRimaste.ToString();
                Console.WriteLine("Ultima rata pagata data: "+dataUltimaRata);
                if (rateRimaste <= 0 || dataUltimaRata.Date == DateTime.Now.Date)
                {
                    payRataBtn.Enabled = false;
                }
                else {
                    payRataBtn.Enabled = true;
                }
            }
            else {
                rataCostField.Text = "Non rateizzato";
                rateToPayField.Text = "/";
                payRataBtn.Enabled = false;
            }
            dataGridRate.DataSource =ratePagate.Select(r => new {r.DataPagamento,
                                                                 r.CodTransazione,
                                                                 r.Importo}) ;
            
        }

        private void addPayRata(object sender, EventArgs e)
        {         
            var codTrans = getPayment(prenotSelector.SelectedItem.ToString()).CodTransazione;
            var rataCost = Decimal.Parse(rataCostField.Text);
            var rata = new RATE
            {
                CodTransazione = codTrans,
                DataPagamento = DateTime.Now,
                Importo = rataCost
            };
            db.RATE.InsertOnSubmit(rata);
            try
            {
                db.SubmitChanges();
            } catch (Exception exc)
            {
                Utilities.ShowErrorMessage("ERRORE: " + exc.Message);
                db = new DataClassesDBCrociereDataContext();
            }
            refreshPaymentInf(sender, e);
        }

        private PAGAMENTI getPayment(String codPrenot)
        {
            Console.WriteLine("Ricavo codTransazione per codPreotazione: "+ codPrenot);
            return (from pren in db.PRENOTAZIONI
             from pays in db.PAGAMENTI
             where pays.CodTransazione == pren.CodTransazione
             && pren.CodPrenotazione == Decimal.Parse(codPrenot)
             select pays).First();
        }

        private void updatePrenRimbTable()
        {
            var pren = from p in db.PRENOTAZIONI
                        select new { 
                            p.CodPrenotazione,
                            p.DataEffettuazione,
                            p.DataOraImbarco,
                            p.DataOraSbarco,
                            p.CodNavigazione,
                            p.CodPorto,
                            p.Trattamento,
                            p.CodTransazione
                        };
            prenViewTable.DataSource = pren;

            var rimb = from r in db.RIMBORSI
                       select r;
            rimbView.DataSource = rimb;
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

            this.RankingPathChart.Series.Clear();
            foreach (var elem in rank)
            {
                Series series = this.RankingPathChart.Series.Add(elem.Percorso);
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
            this.AverageCostsChart.Series.Clear();
            foreach (var elem in rank)
            {
                Series series = this.AverageCostsChart.Series.Add(elem.Percorso);
                series.Points.Add(Decimal.ToDouble(elem.Costo_Medio));
            }
        }

        private void AddPersonal_Click(object sender, EventArgs e)
        {
            AddStaffPopup addStaffPopupWindow = new AddStaffPopup(db);
            addStaffPopupWindow.ShowDialog(this);
        }

        private void AddActivitiesBtn_Click(object sender, EventArgs e)
        {
            AddActivitiesPopup addActivitiesPopup = new AddActivitiesPopup(db);
            addActivitiesPopup.ShowDialog(this);
        }

        private void addRefound_Click(object sender, EventArgs e)
        {
            RefundsPopup refundsPopupWindows = new RefundsPopup(db);
            refundsPopupWindows.ShowDialog(this);
        }

        private void fillsNavigationComboBox(ComboBox cb)
        {
            var nav = from n in db.NAVIGAZIONI
                      select n.CodNavigazione;
            cb.DataSource = nav;
        }

        private void ResponsabilitiesNavigationComboBox_Click(object sender, EventArgs e)
        {
            fillsNavigationComboBox(ResponsabilitiesNavigationComboBox);
        }

        private void ResponsabilitiesNavigationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResponsabilitiesNavigationComboBox.SelectedIndex != -1)
            {
                var res = from r in db.RESPONSABILITÀ
                          where r.CodNavigazione == int.Parse(ResponsabilitiesNavigationComboBox.Text)
                          select new
                          {
                              Navigazione = r.CodNavigazione,
                              Ruolo = r.CodRuolo,
                              Codice_Fiscale = r.CodiceFiscale
                          };
                ResponsabilitiesGridView.DataSource = res;
            }
            else
            {
                ResponsabilitiesGridView.DataSource = null;
            }
        }

        private void NavigationComboBox_Click(object sender, EventArgs e)
        {
            var nav = from n in db.SERVIZI
                      where n.CodiceFiscale == ShiftFCComboBox.Text
                      select n.CodNavigazione;
            NavigationComboBox.DataSource = nav;
        }

        private void ShiftFCComboBox_Click(object sender, EventArgs e)
        {
            var fc = from p in db.PERSONALE
                     select p.CodiceFiscale;
            ShiftFCComboBox.DataSource = fc;
        }

        private void NavigationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nav = from n in db.NAVIGAZIONI
                      where n.CodNavigazione == int.Parse(NavigationComboBox.Text)
                      select new
                      {
                          start = n.DataInizio,
                          end = n.DataFine
                      };

            var shifts = from t in db.TURNI_LAVORATIVI
                         where t.DataOraInizio >= nav.First().start &&
                               t.DataOraFine <= nav.First().end
                         select new
                         {
                             Inizio = t.DataOraInizio,
                             Fine = t.DataOraFine
                         };
            ShiftsGridView.DataSource = shifts;
        }

        private void GrossBoxOfficeBtn_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            var bookingsIncomes = (from p in db.PAGAMENTI
                                   where p.DataPagamento.Year == DateTime.Now.Year
                                   select p.Importo);
            var extraIncomes = (from s in db.SPESE_EXTRA
                                where s.DataSpesa.Year == DateTime.Now.Year
                                select s.Importo);
            if (bookingsIncomes.Any())
            {
                total += (int)bookingsIncomes.Sum();
            }
            if (extraIncomes.Any())
            {
                total += (int)extraIncomes.Sum();
            }
            GrossBoxOfficeLabel.Text = total.ToString();
        }

        private void RankHarborsBtn_Click(object sender, EventArgs e)
        {
            var harborsRank = from p in db.PORTI
                              from pren in db.PRENOTAZIONI
                              where p.CodPorto == pren.CodPorto
                              group p by p.Città into harbors
                              select new
                              {
                                  Porto = harbors.Key,
                                  Numero_Imbarchi = harbors.Count()
                              };
            RankHarborBooking.DataSource = harborsRank;

            this.RankHarborsChart.Series.Clear();
            foreach (var elem in harborsRank)
            {
                Series series = this.RankHarborsChart.Series.Add(elem.Porto);
                series.Points.Add(Decimal.ToDouble(elem.Numero_Imbarchi));
            }
        }

        private void ActivityNavigationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActivityNavigationComboBox.SelectedIndex != -1)
            {
                var activities = from p in db.PROGRAMMAZIONI
                                 from a in db.ATTIVITÀ
                                 where p.CodNavigazione == int.Parse(ActivityNavigationComboBox.Text) &&
                                       p.CodAttività == a.CodAttività
                                 select new
                                 {
                                     Inizio_Data = p.InizioData,
                                     Inizio_ora = p.InizioOra,
                                     Sala = p.CodSala,
                                     Attività = a.Nome,
                                     Durata = p.Durata
                                 };
                ActivitiesGridView.DataSource = activities;
            } else
            {
                ActivitiesGridView.DataSource = null;
            }
        }

        private void ActivityNavigationComboBox_Click(object sender, EventArgs e)
        {
            fillsNavigationComboBox(ActivityNavigationComboBox);
        }

        private void RankResponsabilitiesBtn_Click(object sender, EventArgs e)
        {
            var rank = from r in db.RESPONSABILITÀ
                       group r by r.CodiceFiscale into crew
                       select new
                       {
                           Codice_Fiscale = crew.Key,
                           Numero_Responsabilità = crew.Count()
                       };
            RankResponsabilitiesGridView.DataSource = rank;

            this.RankResponsabilitiesChart.Series.Clear();
            foreach (var elem in rank)
            {
                Series series = this.RankResponsabilitiesChart.Series.Add(elem.Codice_Fiscale);
                series.Points.Add(Decimal.ToDouble(elem.Numero_Responsabilità));
            }
        }

    }
}
