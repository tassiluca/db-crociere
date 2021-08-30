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
        private Dictionary<String, HashSet<DateTime>> portDates;
        private db_crociere.PRENOTAZIONI prenot; //obj used to keep datas before adding them in db
        private Dictionary<String,PASSEGGERI> passengersDict;

        public AddPrenPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            prenot = new PRENOTAZIONI();
            passengersDict = new Dictionary<String, PASSEGGERI>();
            InitializeComponent();
        }

        private void AddPrenPopup_Load(object sender, EventArgs e)
        {
            var path = from p in db.PERCORSIs
                        select p.CodPercorso;
            pathSelPren.DataSource = path;
        }
        private void updateNavigationListSelector(object sender, EventArgs e)
        {
            //path selected
            navDateMap = new Dictionary<string,DateRange>();
            var pathCode = pathSelPren.SelectedItem.ToString();
            Console.WriteLine("Percorso selezionato: " + pathCode);
            //get all the avaiable navigation for the selected path
            var nav = from n in db.NAVIGAZIONIs
                      where n.CodPercorso == pathCode
                      orderby n.DataInizio
                      select new
                      {
                          codNav = n.CodNavigazione,
                          startNavDate = n.DataInizio,
                          endNavDate = n.DataFine
                      };

            if (nav.Count() > 0)
            {
                foreach (var p in nav)
                {
                    var rd = new DateRange(p.startNavDate, p.endNavDate);
                    rd.NavCode = p.codNav;
                    navDateMap.Add(rd.ToStringDate(),rd);
                }   
            }
            else {
                navPeriodSelector.Text = "Nessuna Navigazione";
                portSelPren.Text = "Nessuna Tratta";
                startDateSelPren.Text = "Nessuna data disponibile";
                portSelPren.DataSource = new List<String>();
                startDateSelPren.DataSource = new List<String>();
            }

            navPeriodSelector.DataSource = navDateMap.Keys.ToList();
        }
        private void updatePortSelectorList(object sender, EventArgs e)
        {
            //navigation selected
            String selectedPeriod = navPeriodSelector.SelectedItem.ToString();
            //save selected navigation code 
            prenot.CodNavigazione = navDateMap[selectedPeriod].NavCode;
            Console.WriteLine("Navig. selezionata: " + selectedPeriod + " "+ prenot.CodNavigazione);
            var startDateNav = this.navDateMap[selectedPeriod].StartDate;
            var endDateNav = this.navDateMap[selectedPeriod].EndDate;
            /*select all the esecuzioni_tratta that are part of navigation with id = navCodPathSelected
             * and are inside the period selected
            */
            var path_sections = from est in db.ESECUZIONI_TRATTAs
                                from t in db.TRATTEs
                                from port in db.PORTIs
                                where est.CodNavigazione == prenot.CodNavigazione
                                && t.CodTratta == est.CodTratta
                                && port.CodPorto == t.CodPortoPartenza
                                && est.Partenza_Data >= startDateNav
                                && est.Arrivo_Data <= endDateNav
                                select new {
                                    portName = port.Città,
                                    portCode = port.CodPorto,
                                    imbDate = est.Partenza_Data,
                                    imbTime = est.Partenza_Ora
                                };
            portDates = new Dictionary<String, HashSet<DateTime>>();
            if (path_sections.Count() > 0)
            {
                //create list of avaiable imbarc date-time foreach port
                foreach (var ps in path_sections)
                {
                    DateTime imbDateTime = ps.imbDate + ps.imbTime;
                    
                    if (portDates.ContainsKey(ps.portName))
                    {
                        var updatedSet = portDates[ps.portName];
                        updatedSet.Add(imbDateTime);
                        portDates[ps.portName]=updatedSet;
                    }
                    else {
                        var newSet = new HashSet<DateTime>();
                        newSet.Add(imbDateTime);
                        portDates.Add(ps.portName,newSet);
                    }
                }
            }
            else {
                portSelPren.Text = "Nessuna Tratta";
                Console.WriteLine("Nessun tratta trovata per la navigazione(periodo) "+ selectedPeriod);
            }
            
            portSelPren.DataSource = portDates.Keys.ToList();

        }
        private void updateDateTimeSelector(object sender, EventArgs e)
        {
            //starting port selected
            prenot.CodPorto = portSelPren.SelectedItem.ToString();
            startDateSelPren.DataSource = portDates[prenot.CodPorto].ToList();
        }

        private void startDateSelPren_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dateTimeDeparture = startDateSelPren.SelectedItem.ToString();
            prenot.DataOraImbarco = DateTime.Parse(dateTimeDeparture);

            var selectedPeriod = navPeriodSelector.SelectedItem.ToString();
            Console.WriteLine("Data prossima per sbarco in porto scelto");
            String str = "" +prenot.DataOraImbarco + prenot.CodNavigazione + prenot.CodPorto;
            Console.WriteLine(str);
             var dateTimeSbarco = from est in db.ESECUZIONI_TRATTAs
                                  from t in db.TRATTEs
                                  //from port in db.PORTIs
                                  where est.CodNavigazione == prenot.CodNavigazione
                                  && t.CodTratta == est.CodTratta
                                  && t.CodPortoArrivo == prenot.CodPorto
                                  && est.Arrivo_Data > prenot.DataOraImbarco
                                  orderby est.Arrivo_Data
                                  select new
                                  {
                                      //portName = port.Città,
                                      //portCode = port.CodPorto,
                                      sbarcoDate = est.Arrivo_Data,
                                      sbarcoTime = est.Arrivo_Ora
                                  };
            
            Console.WriteLine(dateTimeSbarco.Count() +  "trovati");
            foreach (var elem in dateTimeSbarco) {
                Console.WriteLine(" "+ elem.sbarcoDate + " " + elem .sbarcoTime);
            }
            //TODO CAPIRE PERCHè CON LA QUERY NON OTTENGO NULLA, CON SQL SERVER RESTITUISCE INVECE

        }

        private void AddPassengerBtn_Click(object sender, EventArgs e)
        {
            var CF = codFiscaletextBox.Text;
            var name = nameBox.Text;
            var surname = surnameBox.Text;
            var country = countryBox.Text;
            var passportId = passportIDBox.Text;

            if (CF.Length != 0 && name.Length != 0 && surname.Length != 0
                && country.Length != 0 && passportId.Length != 0)
            {

                /* Inserimento di un passeggero */
                PASSEGGERI passeggero = new PASSEGGERI
                {
                    CodiceFiscale = CF,
                    Nome = name,
                    Cognome = surname,
                    Nazionalità = country,
                    Passaporto = passportId
                };

                if (isPersonAlreadyInPren(passeggero.CodiceFiscale))
                {
                    var msg = "Tutti is campi devono essere compilati!";
                    MessageBox.Show(msg, "ERRORE");                    
                }
                else { 
                    passengersDict.Add(passeggero.CodiceFiscale, passeggero);                
                }
                ClearPassengerFields();
            }
            else {
                var msg = "Tutti is campi devono essere compilati!";
                MessageBox.Show(msg, "ERRORE");
            }
            /*
            db.PASSEGGERIs.InsertOnSubmit(passeggero);
            db.SubmitChanges();
            ClearPassengerFields();
            */
            updatePassgListBox();
        }

        private Boolean isPersonAlreadyInPren(String CFpers)
        {
            var pasngInPren = from prenPass in db.PRENOTAZIONI_PASSEGGERIs
                              from pren in db.PRENOTAZIONIs
                              where prenPass.CodiceFiscale == CFpers
                              && pren.CodPrenotazione == prenPass.CodPrenotazione
                              && pren.DataOraImbarco >= prenot.DataOraImbarco
                              && pren.DataOraSbarco <= prenot.DataOraSbarco
                              select new { 
                                codFiscale = prenPass.CodiceFiscale,
                                dataImbarco = pren.DataOraImbarco,
                                dataSbarco = pren.DataOraSbarco,
                              };
            return pasngInPren.Count()>0;
        }

        private void updatePassgListBox()
        {
            numPassgInfo.Text = passengersDict.Keys.Count().ToString();
            passengerList.DataSource = passengersDict.Keys.ToList();
        }

        private void ClearPassengerFields()
        {
            codFiscaletextBox.Clear();
            nameBox.Clear();
            surnameBox.Clear();
            countryBox.Clear();
            passportIDBox.Clear();
        }

        private void delPassengerBtn_Click(object sender, EventArgs e)
        {
            var toDelete = passengerList.SelectedItem.ToString();
            if (toDelete.Length > 0) {
                passengersDict.Remove(toDelete);
            }
            updatePassgListBox();
            
        }

    }
}
