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
        //range min e max per i dati del database, si discostano dai range di c#
        private const String MIN_DATE = "01/01/2000";
        private const String MAX_DATE = "12/05/2079";
        private const String ASSENT_INFO = "Assente";
        private DataClassesDBCrociereDataContext db;
        private Dictionary<String, DateRange> navDateMap;
        private Dictionary<String, HashSet<DateTime>> portDates;
        //below obj used to keep datas before adding them in db
        private db_crociere.PRENOTAZIONI prenot;
        private Dictionary<String,PASSEGGERI> passengersDict;
        private List<decimal> addedRoomToPren;

        public AddPrenPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            prenot = new PRENOTAZIONI();
            prenot.DataOraImbarco = DateTime.Parse(MIN_DATE);
            prenot.DataOraSbarco = DateTime.Parse(MAX_DATE);
            passengersDict = new Dictionary<String, PASSEGGERI>();
            addedRoomToPren = new List<decimal>();
            InitializeComponent();
        }

        /// <summary>
        /// Get all path from db and update ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPrenPopup_Load(object sender, EventArgs e)
        {
            var path = from p in db.PERCORSIs
                        select p.CodPercorso;
            pathSelPren.DataSource = path;
            Console.WriteLine("Percorsi caricati");
        }
        /// <summary>
        /// After path selection, update navigation's ListBox with avaiable navigation
        /// for the path selected before
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                dateSbarcoBox.Text = ASSENT_INFO;
                portSelPren.DataSource = new List<String>();
                startDateSelPren.DataSource = new List<String>();
            }

            navPeriodSelector.DataSource = navDateMap.Keys.ToList();
        }

        /// <summary>
        /// Navigation selected. Update port ListBox with the avaiable port
        /// in the selected navigation and path.
        /// Port and relative dateTime departures are saved in portDates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    
                    if (portDates.ContainsKey(ps.portCode))
                    {
                        var updatedSet = portDates[ps.portCode];
                        updatedSet.Add(imbDateTime);
                        portDates[ps.portCode]=updatedSet;
                    }
                    else {
                        var newSet = new HashSet<DateTime>();
                        newSet.Add(imbDateTime);
                        portDates.Add(ps.portCode,newSet);
                    }
                }
            }
            else {
                portSelPren.Text = "Nessuna Tratta";
                startDateSelPren.Text = "Nessuna Data";
                startDateSelPren.DataSource = new List<String>();
                Console.WriteLine("Nessun tratta trovata per la navigazione(periodo) "+ selectedPeriod);
            }
            
            portSelPren.DataSource = portDates.Keys.ToList();

        }

        /// <summary>
        /// Port selected. Update ListBox with avaiable dateTime for departure
        /// in selected navigation and path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateDateTimeSelector(object sender, EventArgs e)
        {
            //starting port selected
            prenot.CodPorto = portSelPren.SelectedItem.ToString();
            startDateSelPren.DataSource = portDates[prenot.CodPorto].ToList();
        }

        /// <summary>
        /// DateTime departure selected. This method calculate and update label tha show
        /// date and time of the end of passenger trip.
        /// The first date avaiable (in the same port of departure) after the departure date is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startDateSelPren_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateSbarcoBox.Text = " ";
            var dateTimeDeparture = startDateSelPren.SelectedItem.ToString();
            prenot.DataOraImbarco = DateTime.Parse(dateTimeDeparture);

            Console.WriteLine("Data prossima per sbarco in porto scelto");
            String str = "Imbarco " +prenot.DataOraImbarco +" "+ prenot.CodNavigazione + prenot.CodPorto;
            Console.WriteLine(str);

             var dateTimeSbar = from est in db.ESECUZIONI_TRATTAs
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
                                      //portCode = t.CodPortoArrivo,
                                      sbarcoDate = est.Arrivo_Data,
                                      sbarcoTime = est.Arrivo_Ora
                                  };
            if (dateTimeSbar.Count() > 0)
            {
                var sbarDateTime = dateTimeSbar.First().sbarcoDate + dateTimeSbar.First().sbarcoTime;

                //!!MANTENERE QUESTO ORDINE DELLE RIGHE SOTTO, NON APPENA IL TESTO CAMBIA, VIENE AGGIORNATO L'ELENCO
                //DELLE TIPOLOGIE DELLE CAMERE DOVE VIENE LETTO dataOraSbarco da prenot
                prenot.DataOraSbarco = sbarDateTime;
                dateSbarcoBox.Text = sbarDateTime.ToString();
            }
            else {
                dateSbarcoBox.Text = ASSENT_INFO;
            }
            Console.WriteLine(dateTimeSbar.Count() +  "trovati");
            foreach (var elem in dateTimeSbar) {
                Console.WriteLine(" "+ elem.sbarcoDate + " " + elem .sbarcoTime);
            }

        }

        //PASSEGGERI
        /// <summary>
        /// Get all the information of passenger for the period and dateTime selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                /* Passenegr insert */
                PASSEGGERI passeggero = new PASSEGGERI
                {
                    CodiceFiscale = CF,
                    Nome = name,
                    Cognome = surname,
                    Nazionalità = country,
                    Passaporto = passportId
                };
                //check if passenger has already booked in the same period and path
                if (isPersonAlreadyInPren(passeggero.CodiceFiscale))
                {
                    var msg = "Passeggero già presente in una altra prenotazione in questo periodo";
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
            //constraint 1 check: Non possono esserci due prenotazioni distinte inerenti
            //allo stesso passeggero nello stesso periodo (incluse le date comprese)
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

    //CABINE-CAMERE
        private void numRoomUpDownSel_ValueChanged(object sender, EventArgs e)
        {
            var numRooms = numRoomUpDownSel.Value;
        }

        private void updateTypeRoomSelector(object sender, EventArgs e)
        {
            if (dateSbarcoBox.Text == ASSENT_INFO) {
                roomTypeSelector.DataSource = new List<String>();
                roomTypeSelector.Text = ASSENT_INFO;
            }
            else
            {
                var nomeNave = getNomeNave().First().Nome;
                //ricavo tutti i cod cabina attualmente impegnati nel periodo di dataoraImbarco-dataOraSbarco selezionato
                //del tipo e posizione selezionati
                //Console.WriteLine(prenot.CodNavigazione +" "+prenot.DataOraImbarco + " "+prenot.DataOraSbarco);

                var erro = from p in db.PRENOTAZIONIs
                           where p.DataOraImbarco >= prenot.DataOraImbarco
                           select p;

                var cabineUsate = from p in db.PRENOTAZIONIs
                                  from alloggi in db.ALLOGGIs
                                  from cab in db.CABINEs
                                  where p.CodNavigazione == prenot.CodNavigazione
                                  && p.DataOraImbarco >= prenot.DataOraImbarco
                                  && p.DataOraSbarco <= prenot.DataOraSbarco
                                  && alloggi.CodPrenotazione == p.CodPrenotazione
                                  && cab.CodCabina == alloggi.CodCabina
                                  && cab.NomeNave == nomeNave                                  
                                  select cab;

                var tutteCabineNave = from c in db.CABINEs
                                      where c.NomeNave == nomeNave
                                      select c;

                var cabineLibere = tutteCabineNave.Except(cabineUsate);

                roomTypeSelector.DataSource = cabineLibere.Select(c => c.NomeTipologia).Distinct();
                
            }

        }
 
        //updated after selection of room type
        private void updateRoomPosSelector(object sender, EventArgs e)
        {

        }


        private void treatmentField_TextChanged(object sender, EventArgs e)
        {
            prenot.Trattamento = treatmentField.Text;
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            
        }

        //UTILITIES CABINE
        private IQueryable<NAVI> getNomeNave()
        {
                var pathCode = pathSelPren.SelectedItem.ToString();
                var shipName = from p in db.PERCORSIs
                               from n in db.NAVIs
                               where p.CodPercorso == pathCode
                               && p.NomeNave == n.Nome
                               select n;
                return shipName;
        }
      
    }
}
