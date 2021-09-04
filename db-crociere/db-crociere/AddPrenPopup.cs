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
        private const String ASSENT_SHIP_NAME = "Nave Assente";
        private const Double PERC_ANTICIPO = 0.3;
        private const decimal ASSENT_CODE_VALUE = -1;
        private const decimal PAY_CARD_LEN = 16;

        private DataClassesDBCrociereDataContext db;
        private Dictionary<String, DateRange> navDateMap;
        private Dictionary<String, HashSet<DateTime>> portDates;
        private IQueryable<CABINE> cabineLibere;
        //cabine ceh rispecchiano le richieste dell'utente, candidate alla aggiunta nella prenotazione
        private IQueryable<CABINE> cabinePrenotabili;
        private Dictionary<decimal, CABINE> cabinePrenotabiliNonAggiunte;
        private Dictionary<String, List<TARIFFARI>> dictTar;

        //below obj used to keep datas before adding them in db
        private db_crociere.PRENOTAZIONI prenot;
        private Dictionary<String, PASSEGGERI> passengersDict;
        private Dictionary<decimal, CABINE> roomOfPrenot;
        private Dictionary<String, String> passngerCard;
        private List<decimal> codTariffari;
        private int importoPrenot;

        public AddPrenPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            prenot = new PRENOTAZIONI();
            prenot.DataOraImbarco = DateTime.Parse(MIN_DATE);
            prenot.DataOraSbarco = DateTime.Parse(MAX_DATE);
            passengersDict = new Dictionary<String, PASSEGGERI>();
            passngerCard = new Dictionary<String, String>();
            cabinePrenotabiliNonAggiunte = new Dictionary<decimal, CABINE>();
            roomOfPrenot = new Dictionary<decimal, CABINE>();
            codTariffari = new List<decimal>();
            InitializeComponent();
        }

        /// <summary>
        /// Get all path from db and update ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPrenPopup_Load(object sender, EventArgs e)
        {
            var path = from p in db.PERCORSI
                       select p.CodPercorso;
            pathSelPren.DataSource = path;
            Console.WriteLine("Percorsi caricati");
            checkBoxRateizzato_CheckedChanged(sender, e);
        }

        private void treatmentField_TextChanged(object sender, EventArgs e)
        {
            prenot.Trattamento = treatmentField.Text;
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
            navDateMap = new Dictionary<string, DateRange>();
            var pathCode = pathSelPren.SelectedItem.ToString();
            Console.WriteLine("Percorso selezionato: " + pathCode);
            //get all the avaiable navigation for the selected path
            var nav = from n in db.NAVIGAZIONI
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
                    navDateMap.Add(rd.ToStringDate(), rd);
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
            Console.WriteLine("Navig. selezionata: " + selectedPeriod + " " + prenot.CodNavigazione);
            var startDateNav = this.navDateMap[selectedPeriod].StartDate;
            var endDateNav = this.navDateMap[selectedPeriod].EndDate;
            /*select all the esecuzioni_tratta that are part of navigation with id = navCodPathSelected
             * and are inside the period selected
            */
            var path_sections = from est in db.ESECUZIONI_TRATTA
                                from t in db.TRATTE
                                from port in db.PORTI
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
                        portDates[ps.portCode] = updatedSet;
                    }
                    else {
                        var newSet = new HashSet<DateTime>();
                        newSet.Add(imbDateTime);
                        portDates.Add(ps.portCode, newSet);
                    }
                }
            }
            else {
                portSelPren.Text = "Nessuna Tratta";
                startDateSelPren.Text = "Nessuna Data";
                startDateSelPren.DataSource = new List<String>();
                Console.WriteLine("Nessun tratta trovata per la navigazione(periodo) " + selectedPeriod);
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
            //reset elenco passeggeri
            passengersDict = new Dictionary<string, PASSEGGERI>();
            passngerCard = new Dictionary<string, string>();
            passengerList.DataSource = new List<String>();

            dateSbarcoBox.Text = " ";
            var dateTimeDeparture = startDateSelPren.SelectedItem.ToString();
            prenot.DataOraImbarco = DateTime.Parse(dateTimeDeparture);

            Console.WriteLine("Data prossima per sbarco in porto scelto");
            String str = "Imbarco " + prenot.DataOraImbarco + " " + prenot.CodNavigazione + prenot.CodPorto;
            Console.WriteLine(str);

            var dateTimeSbar = from est in db.ESECUZIONI_TRATTA
                               from t in db.TRATTE
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
            Console.WriteLine(dateTimeSbar.Count() + "trovati");
            foreach (var elem in dateTimeSbar) {
                Console.WriteLine(" " + elem.sbarcoDate + " " + elem.sbarcoTime);
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
            var creditCard = payCardField.Text;

            if (CF.Length != 0 && name.Length != 0 && surname.Length != 0
                && country.Length != 0 && passportId.Length != 0)
            {
                if (creditCard.Length == PAY_CARD_LEN)
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
                        ClearPassengerFields();
                    }
                    else
                    {
                        if (!passengersDict.ContainsKey(passeggero.CodiceFiscale))
                        {
                            passengersDict.Add(passeggero.CodiceFiscale, passeggero);
                            passngerCard.Add(passeggero.CodiceFiscale, creditCard);
                        }
                        else
                        {
                            var msg1 = "Passeggero già inserito";
                            MessageBox.Show(msg1, "ERROR");
                            ClearPassengerFields();
                        }

                    }
                    
                }
                else { 
                    var msg2 = "Numero di carta inserito incompleto";
                    MessageBox.Show(msg2, "ERROR");
                }
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
            var pasngInPren = from prenPass in db.PRENOTAZIONI_PASSEGGERI
                              from pren in db.PRENOTAZIONI
                              where prenPass.CodiceFiscale == CFpers
                              && pren.CodPrenotazione == prenPass.CodPrenotazione
                              &&(
                              ( pren.DataOraImbarco <= prenot.DataOraImbarco && 
                                pren.DataOraSbarco >= prenot.DataOraImbarco) ||
                                (pren.DataOraImbarco <= prenot.DataOraSbarco && 
                                    pren.DataOraSbarco >= prenot.DataOraSbarco)
                               )

                              select new {
                                  codFiscale = prenPass.CodiceFiscale,
                                  dataImbarco = pren.DataOraImbarco,
                                  dataSbarco = pren.DataOraSbarco,
                              };
            return pasngInPren.Count() > 0;
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
            payCardField.Clear();
        }

        private void delPassengerBtn_Click(object sender, EventArgs e)
        {
            if (passengerList.SelectedItem != null) {
                var toDelete = passengerList.SelectedItem.ToString();
                if (toDelete.Length > 0)
                {
                    passengersDict.Remove(toDelete);
                    passngerCard.Remove(toDelete);
                }
                updatePassgListBox();
            }

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
                roomTypeSelector.SelectedItem = ASSENT_INFO;
                roomOfPrenot = new Dictionary<decimal, CABINE>();
            }
            else
            {
                var nomeNave = getNomeNave();
                //ricavo tutti i cod cabina attualmente impegnati nel periodo di dataoraImbarco-dataOraSbarco selezionato
                //del tipo e posizione selezionati
                //Console.WriteLine(prenot.CodNavigazione +" "+prenot.DataOraImbarco + " "+prenot.DataOraSbarco);

                var erro = from p in db.PRENOTAZIONI
                           where p.DataOraImbarco >= prenot.DataOraImbarco
                           select p;

                var cabineUsate = from p in db.PRENOTAZIONI
                                  from alloggi in db.ALLOGGI
                                  from cab in db.CABINE
                                  where p.CodNavigazione == prenot.CodNavigazione
                                  && p.DataOraImbarco >= prenot.DataOraImbarco
                                  && p.DataOraSbarco <= prenot.DataOraSbarco
                                  && alloggi.CodPrenotazione == p.CodPrenotazione
                                  && cab.CodCabina == alloggi.CodCabina
                                  && cab.NomeNave == nomeNave
                                  select cab;

                var tutteCabineNave = from c in db.CABINE
                                      where c.NomeNave == nomeNave
                                      select c;

                //faccio sottrazione fra tutte cabine-cabine gia prenotate
                cabineLibere = tutteCabineNave.Except(cabineUsate);
                roomTypeSelector.DataSource = cabineLibere.Select(c => c.NomeTipologia).Distinct();

                if (cabineLibere.Count() <= 0)
                {
                    roomTypeSelector.Text = ASSENT_INFO;
                }
            }

        }

        //updated after selection of room type
        private void updateRoomPosSelector(object sender, EventArgs e)
        {
            if (roomTypeSelector.Text == ASSENT_INFO)
            {
                roomPositionSel.DataSource = new List<String>();
                roomPositionSel.Text = ASSENT_INFO;
                roomPositionSel.SelectedItem = ASSENT_INFO;
            }
            else {
                var tipoCab = roomTypeSelector.SelectedItem.ToString();
                var cabDiTipoScelto = cabineLibere.Where(c => c.NomeTipologia == tipoCab);
                roomPositionSel.DataSource = cabDiTipoScelto.Select(c => c.Posizione).Distinct();
            }
        }

        private void updateNumPeopleSel(object sender, EventArgs e)
        {
            if (roomPositionSel.Text == ASSENT_INFO)
            {
                roomSizeSel.DataSource = new List<String>();
                roomSizeSel.Text = "-";
                roomSizeSel.SelectedItem = ASSENT_INFO;
            }
            else
            {
                var tipoCab = roomTypeSelector.SelectedItem.ToString();
                var posCab = roomPositionSel.SelectedItem.ToString();
                cabinePrenotabili = cabineLibere.Where(c => c.NomeTipologia == tipoCab && c.Posizione == posCab);
                //azzero le cabine prenotabili e ripopolo il dictionary aggiornato
                cabinePrenotabiliNonAggiunte = new Dictionary<decimal, CABINE>();
                foreach (var cab in cabinePrenotabili) {
                    cabinePrenotabiliNonAggiunte.Add(cab.CodCabina, cab);
                }
                roomSizeSel.DataSource = cabinePrenotabili.Select(c => c.PostiLetto).Distinct();
            }
        }

        private void updateMaxRoomQuantity(object sender, EventArgs e)
        {
            if (roomSizeSel.Text == "-")
            {
                numRoomUpDownSel.Maximum = 0;
            }
            else {
                numRoomUpDownSel.Maximum = cabinePrenotabili.Count();
                numRoomUpDownSel.Value = 1;
            }

        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            if (passengersDict.Count() > 0)
            {
                var qty = (int)numRoomUpDownSel.Value;
                var selectedRoom = cabinePrenotabiliNonAggiunte.Keys.Take(qty).ToList();
                foreach (var sr in selectedRoom)
                {
                    if (!roomOfPrenot.ContainsKey(sr))
                    {
                        roomOfPrenot.Add(sr, cabinePrenotabiliNonAggiunte[sr]);
                        cabinePrenotabiliNonAggiunte.Remove(sr);
                        Console.WriteLine("Aggiunta cavina: " + sr);
                    }
                }
                updateRoomListBox();
            }
            else {
                var msg = "Inserire almeno un passeggero.";
                MessageBox.Show(msg, "ATTENZIONE");
            }
        }

        private void delRoomBtn_Click(object sender, EventArgs e)
        {
            if (roomListBox.SelectedItem != null) {
                var cabToremove = Convert.ToDecimal(roomListBox.SelectedItem.ToString());
                if (roomOfPrenot.ContainsKey(cabToremove))
                {
                    if (!cabinePrenotabiliNonAggiunte.ContainsKey(cabToremove))
                    {
                        cabinePrenotabiliNonAggiunte.Add(cabToremove, roomOfPrenot[cabToremove]);
                    }
                    roomOfPrenot.Remove(cabToremove);
                    updateRoomListBox();
                    Console.WriteLine("Rimossa cabina: " + cabToremove);
                }
            }
            else
            {
                Console.WriteLine("Nessuna cabina da rimuovere dalla prenotazione");
            }
        }

        private void updateRoomListBox() {
            roomListBox.DataSource = roomOfPrenot.Keys.ToList();
            numRoomUpDownSel.Maximum = cabinePrenotabiliNonAggiunte.Count();
            textTotPostiLetto.Text = roomOfPrenot.Values.Select(c => c.PostiLetto).Sum().ToString();
        }

        //UTILITIES CABINE
        private String getNomeNave()
        {
            if (pathSelPren.SelectedItem != null)
            {
                var pathCode = pathSelPren.SelectedItem.ToString();
                var shipName = from p in db.PERCORSI
                               from n in db.NAVI
                               where p.CodPercorso == pathCode
                               && p.NomeNave == n.Nome
                               select n;
                return shipName.First().Nome;

            }
            else {
                var msg = "Prima selezionare il percorso";
                MessageBox.Show(msg, "ERRORE");
                return ASSENT_SHIP_NAME;
            }

        }

        private void calcTotalPriceBtn_Click(object sender, EventArgs e)
        {
            /*OCCORRENTE: per calcolare ottenere i tariffari associati ed applictyi alla prenotazioe necessito delle informazioni seguenti:
             NomeTipologia (cabina),
             NomeNave (che ricavo partendo dal percorso selezionato),
             Le date DataOraImbarco e DataOraSbarco devono essere comprese in DataInizio-DataFine (tariffario)*/
            importoPrenot = (int)ASSENT_CODE_VALUE;
            var nomeNave = getNomeNave(); //deve essere selezionato il codice Percorso
            if (nomeNave != ASSENT_SHIP_NAME)
            {
                var roomTypeOfPrenot = roomOfPrenot.Values.Select(c => c.NomeTipologia).Distinct().ToList();
                var tariffari = from tar in db.TARIFFARI
                                where tar.NomeNave == nomeNave
                                // && roomTypeOfPrenot.All(c1 => tar.NomeTipologia == c1)
                                select tar;
                Console.WriteLine(tariffari.Count() + " tariffari trovati nave: " + nomeNave);
                foreach (var ee in tariffari)
                {
                    Console.WriteLine(ee.NomeNave + " " + ee.NomeTipologia);

                }
                foreach (var ee in roomTypeOfPrenot)
                {
                    Console.WriteLine(ee + "Tipo cabina prenotazione");

                }

                //struttura dati che mi serve per cercare i tariffari applicati alle tipologie presenti nella prenotazione
                dictTar = new Dictionary<String, List<TARIFFARI>>();
                foreach (var tr in tariffari)
                {
                    //se la tipologia del tariffario rientra in quelle delle cabine associate alla prenotazione
                    //inserisco nella dictionary
                    if (roomTypeOfPrenot.Contains(tr.NomeTipologia))
                    {

                        if (dictTar.ContainsKey(tr.NomeTipologia))
                        {
                            var updatedSet = dictTar[tr.NomeTipologia];
                            updatedSet.Add(tr);
                            dictTar[tr.NomeTipologia] = updatedSet;
                        }
                        else
                        {
                            var newSet = new List<TARIFFARI>();
                            newSet.Add(tr);
                            dictTar.Add(tr.NomeTipologia, newSet);
                        }
                    }
                    //se il nome della tipolgia non rientra fra quelle associate alla prenotazione
                    //non metto dentro il dictionary
                }

                //devo ordinare i tariffari in ordine crescente

                var listTobeOrered = dictTar.Keys.ToList();
                foreach (var tp in listTobeOrered)
                {
                    var listaOrdinata = dictTar[tp].OrderBy(a => a.DataInizio).ToList();
                    dictTar[tp] = listaOrdinata;

                }

                /* ora per ciascuna tipologia presente nella dictionary lancio la funzione ricorsiva che mi calcola
                 * il prezzo totale per quella tipologia di cabina per il periodo DataOraImbarco-dataOraSbarco
                 */
                if (roomTypeOfPrenot.Count() > 0)
                {

                    var typeIdx = 0; //prima tipologia
                    var prezzoTot = 0;
                    try
                    {
                        //calcolo il costo per tutte le tipologie di camere che sono presenti nella prenotazione
                        for (typeIdx = 0; typeIdx < roomTypeOfPrenot.Count(); typeIdx++)
                        {
                            var tipo = roomTypeOfPrenot.ElementAt(typeIdx);
                            var num = roomOfPrenot.Values.Select(c => c.NomeTipologia).Where(c => c == tipo).Count();
                            var costoTipo = ricCalcCost(prenot.DataOraImbarco, prenot.DataOraSbarco, 0, tipo);
                            prezzoTot += costoTipo * num;
                        }
                        priceLabel.Text = prezzoTot.ToString();
                        importoPrenot = prezzoTot;
                    }
                    catch (InvalidOperationException exc)
                    {
                        var msg = "Mancanza di tariffari e/o periodi non tariffati";
                        MessageBox.Show(msg, "ERRORE");
                        Console.WriteLine("ECCEZIONE: " + exc);
                        priceLabel.Text = " ";
                        importoPrenot = (int)ASSENT_CODE_VALUE;
                        codTariffari = new List<decimal>();
                    }
                }
                else {
                    var msg = "Prezzo non calcolabile: selezionare almeno una camera";
                    priceLabel.Text = " ";
                    importoPrenot = (int)ASSENT_CODE_VALUE;
                    MessageBox.Show(msg, "Attenzione");
                }
            }
            else
            {
                var msg = "Prezzo non calcolabile: selezionare percorso e date Imbarco-Sbarco";
                priceLabel.Text = " ";
                importoPrenot = (int)ASSENT_CODE_VALUE;
                MessageBox.Show(msg, "Attenzione");
            }

        }

        private void addTariff_Prenot(decimal codTarif) {
            if (!codTariffari.Contains(codTarif)) {
                codTariffari.Add(codTarif);
            }
            Console.WriteLine("Tarifarrio memorizzato: " + codTarif);
        }

        private int ricCalcCost(DateTime imbarco, DateTime sbarco, int idxTarTipoCab, String type) {
            if (dictTar.ContainsKey(type) && idxTarTipoCab < dictTar[type].Count()) {
                int prezzo = 0;
                var tar = dictTar[type].ElementAt(idxTarTipoCab);
                var dataFine = tar.DataFine;
                var dataInizio = tar.DataInizio;

                if (dataInizio <= imbarco && imbarco <= dataFine)
                {
                    if (sbarco <= dataFine)
                    {
                        //caso in cui ho un solo tariffario applicato a quel tipo di cabina in una nave
                        addTariff_Prenot(tar.CodTariffario);
                        int giorni = (int)(sbarco - imbarco).TotalDays;
                        return giorni * (int)tar.Prezzo;
                    }
                    else
                    {
                        //memorizzo costo fino alla fine del tariffario corrente poi salto al successivo
                        //il periodo della prenotazione inizia dentro il peridoo del tariffario corrente e finisce in uno di quelli seguenti
                        int giorni = (int)(dataFine - imbarco).TotalDays;
                        prezzo = giorni * (int)tar.Prezzo;
                        addTariff_Prenot(tar.CodTariffario);

                        if (idxTarTipoCab + 1 < dictTar[type].Count()) {
                            //se non vado fuori dalla lista,ci sono ancora tariffari da scorrere
                            //verifico che il tariffario attuale sia contiguo al successivo

                            var tarNext = dictTar[type].ElementAt(idxTarTipoCab + 1);
                            //verifico i due tariffari vicini siano contigui
                            if ((tarNext.DataInizio - tar.DataFine).TotalDays <= 1)
                            {
                                //significa che sono contigui e non ci sono gap
                                var dImb = tarNext.DataInizio;
                                return prezzo + ricCalcCost(dImb, sbarco, idxTarTipoCab + 1, type);
                            }
                            else {
                                Console.WriteLine("I tariffari non sono contigui, ci sono buchi di tariffazione");
                                //lancio eccezione
                                throw new InvalidOperationException("Periodi Tariffari non contigui o assenti");
                            }

                        }
                        Console.WriteLine("Sono arrivato in fondo, Tariffari finiti");
                        throw new InvalidOperationException("Tariffari finiti, non è possibile andare oltre");
                    }
                }
                else {
                    Console.WriteLine("Salto al tariffario successivo, non inizia in questo periodo");
                    return prezzo + ricCalcCost(imbarco, sbarco, idxTarTipoCab + 1, type);
                }
            }
            else {
                //stampa di errore , è presente un buco del tariffario, la tipologia corrente ha dei periodi
                //mancanti dei tariffari
                Console.WriteLine("Sono arrivato in fondo, Tariffari finiti");
                throw new InvalidOperationException("Tariffari finiti, non è possibile andare oltre");
            }
        }

        //AGGIUNTA PRENOTAZIONE E QUERY DI INSERIMENTO
        private void confirmPrenotBtn_Click(object sender, EventArgs e)
        {
            //verifica della presenza di tutti i dati necessari per l'inserimento
            //la mancanza di una sola informazione non permette l'inserimento e la conferma della prenotazione

            calcRataBtn_Click(sender,e);
            if (!checkPay())
            {
                printDataGap("prezzo non valido");
            }
            else if (!checkPren())
            {
                printDataGap("prenotazione e/o non ammessi");
            }
            else if (!checkPasng())
            {
                printDataGap("passeggeri, inserirne almeno uno");
            }
            else if (!checkBadge())
            {
                printDataGap("numero carta di credito incompleto");
            }
            else if (!checkAlloggi())
            {
                printDataGap("posti letto insufficenti o nessuna cabina inserita");
            }
            else if (!checkTarif())
            {
                printDataGap("nessun tariffario trovato");
            }
            else {
                decimal codicePrenotazione = calculatePrenId();
                decimal codicePagamento = calculateTransId();

                Console.WriteLine("CodPrenot: "+ codicePrenotazione+ " codTrans: " + codicePagamento);
                insertPagamento(codicePagamento, checkBoxRateizzato.Checked);
                insertPrenotazione(codicePrenotazione, codicePagamento);
                insertPasseggeri();
                insertPrenot_Passeggeri(codicePrenotazione);
                insertBadge(codicePrenotazione);
                insertAlloggi(codicePrenotazione);

                insertTariffari_Prenot(codicePrenotazione);
                db.SubmitChanges();
                MessageBox.Show("Prenotazione confermata!","SUCCESS");
            
            }
        }

        private decimal calculateTransId()
        {
            var lastCode = (from pay in db.PAGAMENTI
                           select pay.CodTransazione )
                           .OrderByDescending(e => e)
                           .First();
            return lastCode+1;
        }

        private decimal calculatePrenId()
        {
            var lastCode = (from pre in db.PRENOTAZIONI
                            select pre.CodPrenotazione)
                          .OrderByDescending(e => e)
                          .First();
            return lastCode + 1;
        }

        private void printDataGap(String msg){
            MessageBox.Show("Dati mancanti: " + msg, "Errore");
        }

        private bool checkTarif()
        {
            //i controlli che il tariffario sia relativo ad una nave
            //e alla tipologia della cabine/e presente nella prenotazione viene controllato in fase
            //di elaborazione dei tariffari
            return codTariffari.Count() > 0;
        }

        private bool checkAlloggi()
        {
            //verifico che ci siano abbastanza posti letto per contenere i passeggeri
            return roomOfPrenot.Count() > 0 && checkPasng() && 
                    passengersDict.Count() <= roomOfPrenot.Values.Select(c => c.PostiLetto).Sum();
        }

        private bool checkBadge()
        {
            //contrololo che per ciascun passeggero ci sia la carta di credito inserita
            if (passngerCard.Count() == passengersDict.Count() && checkPasng()) {
                foreach (var psng in passengersDict.Keys) {
                    if (passngerCard[psng].Length < PAY_CARD_LEN)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private bool checkPasng()
        {
            return passengersDict.Count() > 0;
        }

        private bool checkPren()
        {
            return prenot.DataOraImbarco != null &&
                    prenot.DataOraSbarco != null &&
                    prenot.DataOraImbarco <= DateTime.Parse(MAX_DATE) &&
                    prenot.DataOraImbarco >= DateTime.Parse(MIN_DATE) &&
                    prenot.DataOraSbarco <= DateTime.Parse(MAX_DATE) &&
                    prenot.DataOraSbarco >= DateTime.Parse(MIN_DATE) &&
                    prenot.Trattamento != null &&
                    prenot.Trattamento.Length > 0 &&
                    prenot.CodNavigazione != ASSENT_CODE_VALUE &&
                    prenot.CodPorto != null && 
                    prenot.CodPorto.Length > 0;
        }

        private bool checkPay()
        {
            var state = checkBoxRateizzato.Checked;
            if (state)
            {
                return numRateField.Value >= 2 && fieldAnticipo.Text.Length > 0;
            }
            else {
                return importoPrenot > 0 && importoPrenot != ASSENT_CODE_VALUE;
            }
            
        }

        private void insertBadge(decimal codicePrenotazione)
        {
            foreach (var psngKey in passengersDict.Keys)
            {
                var badge = new BADGE
                {
                CodPrenotazione = codicePrenotazione,
                CodiceFiscale = psngKey,
                CartaCredito = passngerCard[psngKey]
                };
                db.BADGE.InsertOnSubmit(badge);
            }
            Console.WriteLine("Badge inseriti");
        }

        private void insertPagamento(decimal codTransaz, Boolean isUnico)
        {
            if (!isUnico)
            {
                var payment = new PAGAMENTI
                {
                    CodTransazione = codTransaz,
                    DataPagamento = DateTime.Now,
                    Importo = importoPrenot,
                };
                db.PAGAMENTI.InsertOnSubmit(payment);
            }
            else {
                Console.WriteLine("Inserimento pagamento a rate");
                var payment = new PAGAMENTI
                {
                    CodTransazione = codTransaz,
                    DataPagamento = DateTime.Now,
                    Importo = importoPrenot,
                    NumeroRate = numRateField.Value,
                    Anticipo = Convert.ToDecimal(fieldAnticipo.Text),
                };
                db.PAGAMENTI.InsertOnSubmit(payment);

            }
            Console.WriteLine("Pagamento inseriti");
        }

        private void insertPrenotazione(decimal codicePrenotazione, decimal codicePagamento)
        {
            var pren = new PRENOTAZIONI
                {
                    CodPrenotazione = codicePrenotazione,
                    CodTransazione = codicePagamento,
                    DataEffettuazione = DateTime.Now,
                    DataOraImbarco = prenot.DataOraImbarco,
                    DataOraSbarco = prenot.DataOraSbarco,
                    Trattamento = treatmentField.Text,
                CodNavigazione = prenot.CodNavigazione,
                CodPorto = prenot.CodPorto
            };
            db.PRENOTAZIONI.InsertOnSubmit(pren);
            Console.WriteLine("Badge inseriti");
        }

        private void insertPasseggeri()
        {
                    foreach (var psng in passengersDict.Values)
                    {
                        var psngrIn = (from p in db.PASSEGGERI
                                      select p.CodiceFiscale).ToList();
                        if (!psngrIn.Contains(psng.CodiceFiscale)) {
                            var pass = new PASSEGGERI
                            {
                                CodiceFiscale = psng.CodiceFiscale,
                                Nome = psng.Nome,
                                Cognome = psng.Cognome,
                                Nazionalità = psng.Nazionalità,
                                Passaporto = psng.Passaporto
                            };
                            db.PASSEGGERI.InsertOnSubmit(pass);
                        }
                    }
            Console.WriteLine("Passeggeri inseriti");
        }

        private void insertPrenot_Passeggeri(decimal codPren)
                {
                    foreach (var psng in passengersDict.Values)
                    {
                        var pren_pass = new PRENOTAZIONI_PASSEGGERI
                        {
                            CodiceFiscale = psng.CodiceFiscale,
                            CodPrenotazione = codPren
                        };
                        db.PRENOTAZIONI_PASSEGGERI.InsertOnSubmit(pren_pass);
                    }
            Console.WriteLine("Prenot_passggeri inseriti");
        }

        private void insertAlloggi(decimal codPren)
                {
                    foreach (var codCabina in roomOfPrenot.Keys )
                    {
                        var alloggio = new ALLOGGI
                        {
                            CodCabina = codCabina,
                            CodPrenotazione = codPren
                        };
                        db.ALLOGGI.InsertOnSubmit(alloggio);
                    }
            Console.WriteLine("Alloggi inseriti");
        }

        private void insertTariffari_Prenot(decimal codPren)
                {
                    foreach (var t in codTariffari) {
                        var tariffari_prenotazioni = new TARIFFARI_PRENOTAZIONI
                        {
                            CodTariffario = t,
                            CodPrenotazione = codPren
                        };
                        db.TARIFFARI_PRENOTAZIONI.InsertOnSubmit(tariffari_prenotazioni);
                    }
            Console.WriteLine("Tariff_Prenot inseriti");
        }

        private void checkBoxRateizzato_CheckedChanged(object sender, EventArgs e)
        {
            var state = checkBoxRateizzato.Checked;
            fieldAnticipo.Enabled = state;
            numRateField.Enabled = state;
            fieldAnticipo.Text = ((int)(importoPrenot * PERC_ANTICIPO)).ToString();
            calcRataBtn_Click(sender,e);
        }

        private void calcRataBtn_Click(object sender, EventArgs e)
        {
            if (fieldAnticipo.Text.Length > 0 && importoPrenot > 0)
            {
                var anticipo = Decimal.Parse(fieldAnticipo.Text);
                if (anticipo >= importoPrenot)
                {
                    var msg = "Anticipo troppo alto";
                    MessageBox.Show(msg, "Error");
                    var ant = (int)(importoPrenot * PERC_ANTICIPO);
                    fieldAnticipo.Text = ant.ToString();
                    rataCalcolata.Text = ((importoPrenot - ant) / numRateField.Value).ToString();
                }
                else if (anticipo == 0)
                {
                    //disattivo rateizzato
                    checkBoxRateizzato.Checked = false;
                    fieldAnticipo.Text = "";
                    rataCalcolata.Text = "";
                }
                else
                {
                    rataCalcolata.Text = ((int)((importoPrenot - anticipo) / numRateField.Value)).ToString();
                }
            }
        }
    }
}
