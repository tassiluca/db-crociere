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
    public partial class AddNavigationPopup : Form
    {
        private DataClassesDBCrociereDataContext db;
        private List<decimal> sectionsList = new List<decimal>();
        private List<decimal> selectedSections = new List<decimal>();

        public AddNavigationPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            InitializeComponent();
        }

        /// <summary>
        /// Return the Harbors codes of given section.
        /// </summary>
        /// <param name="codSection">The code of the section.</param>
        /// <returns>A dictionary: associated with the "START" key there is the departure
        /// code harbor and associated with the "END" key the arrival one.</returns>
        private Dictionary<string, string> getHarborsOfSection(decimal codSection)
        {
            Dictionary<string, string> harborsDict = new Dictionary<string, string>();
            var harbors = (from p1 in db.PORTIs
                           from p2 in db.PORTIs
                           from t in db.TRATTEs
                           where t.CodTratta == codSection &&
                                 t.CodPortoPartenza == p1.CodPorto &&
                                 t.CodPortoArrivo == p2.CodPorto
                           select new
                           {
                               START = p1.CodPorto,
                               END = p2.CodPorto
                           }).ToList();

            harborsDict.Add("START", harbors[0].START);
            harborsDict.Add("END", harbors[0].END);
            return harborsDict;
        }

        /// <summary>
        /// Implements the integrity checks for sections. In detail: the port of arrival of the 
        /// section must coincide with the port of departure of the next one.
        /// </summary>
        /// <returns>False if one of the checks is violated. True otherwise.</returns>
        private bool ChecksSections()
        {
            for (int i = 0; i < selectedSections.Count(); i++)
            {
                if (getHarborsOfSection(selectedSections[i])["END"] !=
                    getHarborsOfSection(selectedSections[(i + 1) % selectedSections.Count()])["START"])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// The routine which inserts path and related sections sequences.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void AddPathBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string pathCode = CodPathTextBox.Text;
                int duration = int.Parse(DurationTextBox.Text);
                string shipName = ShipNameComboPath.SelectedItem.ToString();

                Console.WriteLine(pathCode + " " + duration + " " + shipName);

                if (!ChecksSections())
                {
                    msg = "Il porto di arrivo di tratta deve coincidere con il" +
                        " porto di partenza di quella successiva";
                    throw new ArgumentException(msg);
                }

                /* Inserts the new path. */
                PERCORSI percorso = new PERCORSI
                {
                    CodPercorso = pathCode,
                    NomeNave = shipName,
                    GiorniDurata = duration
                };
                db.PERCORSIs.InsertOnSubmit(percorso);

                /* Inserts the sections sequences. */
                int i = 0;
                foreach (var codSequence in selectedSections)
                {
                    i++;
                    SEQUENZE_TRATTE sqtratte = new SEQUENZE_TRATTE
                    {
                        CodPercorso = pathCode,
                        CodTratta = codSequence,
                        Ordine = i
                    };
                    db.SEQUENZE_TRATTEs.InsertOnSubmit(sqtratte);

                }
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Utilities.ClearAll(this);
            AddNavigationPopup_Load(sender, e);
        }

        /// <summary>
        /// The routine which updates the section list in the ListBox.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void AddNavigationPopup_Load(object sender, EventArgs e)
        {
            var sections = (from t in db.TRATTEs
                            from p1 in db.PORTIs
                            from p2 in db.PORTIs
                            where p1.CodPorto == t.CodPortoPartenza &&
                                  p2.CodPorto == t.CodPortoArrivo
                            select new
                            {
                                SEC_CODE = t.CodTratta,
                                ARR_PORT = p2.Città,
                                DEP_PORT = p1.Città
                            }).ToList();

            sectionsList.Clear();
            SectionsListBox.Items.Clear();
            foreach (var elem in sections)
            {
                string msg = "[" + elem.SEC_CODE + "] " + elem.DEP_PORT + " -> " + elem.ARR_PORT;
                SectionsListBox.Items.Add(msg);
                sectionsList.Add(elem.SEC_CODE);
            }
            selectedSections.Clear();
            InsertedSections.Items.Clear();
        }

        /// <summary>
        /// Add to the selected sections listbox the one which the user has just selected
        /// and remove it from the listbox of available sections.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void InsertSectionPathBtn_Click(object sender, EventArgs e)
        {
            if (SectionsListBox.SelectedIndex != -1)
            {
                InsertedSections.Items.Add(SectionsListBox.SelectedItem.ToString());
                selectedSections.Add(sectionsList[SectionsListBox.SelectedIndex]);
                sectionsList.RemoveAt(SectionsListBox.SelectedIndex);
                SectionsListBox.Items.RemoveAt(SectionsListBox.SelectedIndex);
            }
            else
            {
                var msg = "Nessuna selezione!";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove to the selected sections listbox the one which the user has just selected
        /// and add it from the listbox of available sections. This is the opposite of 
        /// InsertSectionPathBtn_Click.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>        
        private void DeleteSectionPathBtn_Click(object sender, EventArgs e)
        {
            if (InsertedSections.SelectedIndex != -1)
            {
                SectionsListBox.Items.Add(InsertedSections.SelectedItem.ToString());
                sectionsList.Add(selectedSections[InsertedSections.SelectedIndex]);
                selectedSections.RemoveAt(InsertedSections.SelectedIndex);
                InsertedSections.Items.RemoveAt(InsertedSections.SelectedIndex);
            }
            else
            {
                var msg = "Nessuna selezione!";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Inserts a new harbor into the database.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>   
        private void AddHarbor_Click(object sender, EventArgs e)
        {
            try
            {
                string harborCode = HarborCodeTextBox.Text;
                string nationality = NationalityTextBox.Text;
                string city = CityTextBox.Text;
                int dockingPrice = int.Parse(DockingPriceTextBox.Text);

                /* Inserting a new harbor */
                PORTI porto = new PORTI
                {
                    CodPorto = harborCode,
                    Nazionalità = nationality,
                    Città = city,
                    PrezzoAttracco = dockingPrice
                };

                db.PORTIs.InsertOnSubmit(porto);
                db.SubmitChanges();
                var msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                var msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Utilities.ClearAll(this);
        }

        /// <summary>
        /// Fills the harbor combobox with the harbors in the db.
        /// </summary>
        /// <param name="cb">the combobox into which inserts data.</param>
        private void FillHarborComboBox(ComboBox cb)
        {
            var harbors = from porto in db.PORTIs
                          select porto.Città;
            cb.DataSource = harbors;
        }

        private void DepartureHarborComboBox_Click(object sender, EventArgs e)
        {
            FillHarborComboBox(DepartureHarborComboBox);
        }

        private void ArrivalHarborComboBox_Click(object sender, EventArgs e)
        {
            FillHarborComboBox(ArrivalHarborComboBox);
        }


        /// <summary>
        /// Adds into the database a new section.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>   
        private void AddSectionBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string departureHarbor = DepartureHarborComboBox.Text;
                string arrivalHarbor = ArrivalHarborComboBox.Text;

                string departureHarborCode = (from p in db.PORTIs
                                              where p.Città == departureHarbor
                                              select p.CodPorto).First();
                string arrivalHarborCode = (from p in db.PORTIs
                                            where p.Città == arrivalHarbor
                                            select p.CodPorto).First();

                // checks departure harbor and arrival one are not the same
                if (departureHarborCode == arrivalHarborCode)
                {
                    msg = "Il porto di arrivo e destinazione non possono coincidere";
                    throw new ArgumentException(msg);
                }

                TRATTE tratta = new TRATTE
                {
                    CodPortoPartenza = departureHarborCode,
                    CodPortoArrivo = arrivalHarborCode
                };

                db.TRATTEs.InsertOnSubmit(tratta);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Utilities.ClearAll(this);
        }

        /// <summary>
        /// Fills the ship name combo box.
        /// </summary>
        /// <param name="cb">The combobox into which inserts data.</param>
        private void FillShipNameCombo(ComboBox cb)
        {
            var ships = from navi in db.NAVIs
                        select navi.Nome;
            cb.DataSource = ships;
        }

        private void ShipNameNavigationComboBox_Click(object sender, EventArgs e)
        {
            FillShipNameCombo(ShipNameNavigationComboBox);
        }

        private void ShipNameComboPath_Click(object sender, EventArgs e)
        {
            FillShipNameCombo(ShipNameComboPath);
        }

        private void ShipNameSectionComboBox_Click(object sender, EventArgs e)
        {
            FillShipNameCombo(ShipNameSectionComboBox);
        }

        /// <summary>
        /// Implements the integrity checks for navigations. In detail: a navigation cannot 
        /// overlaps with another one already inserted into the database.
        /// </summary>
        /// <param name="shipName">The ship name.</param>
        /// <param name="start">The navigation start date.</param>
        /// <param name="end">The navigation end date.</param>
        /// <returns></returns>
        private bool checksNavigation(string shipName, DateTime start, DateTime end)
        {
            var intersections = from n in db.NAVIGAZIONIs
                                where n.NomeNave == shipName &&
                                      ((start >= n.DataInizio && start <= n.DataFine) ||
                                      (end >= n.DataInizio && end <= n.DataFine) ||
                                      (n.DataInizio >= start && n.DataFine <= start) ||
                                      (n.DataInizio >= end && n.DataFine <= end))
                                select n.CodNavigazione;
            return intersections.Count() == 0;
        }

        /// <summary>
        /// Inserts into the database a new navigation.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>   
        private void AddNavigationBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string shipName = ShipNameNavigationComboBox.Text;
                DateTime startDate = StartNavigationDatePicker.Value.Date;
                DateTime endDate = EndNavigationDatePicker.Value.Date;
                int executions = int.Parse(ExecutionsTextBox.Text);
                string pathCode = PathCodeTextBox.Text;

                Console.WriteLine(shipName + " " + startDate + " " + endDate + " " + executions + " " + pathCode);

                if (!checksNavigation(shipName, startDate, endDate))
                {
                    msg = "Intersezione date con un'altra navigazione già presente nel DB!";
                    throw new ArgumentException(msg);
                }

                /* Inserting a new navigation */
                NAVIGAZIONI navigazione = new NAVIGAZIONI
                {
                    NomeNave = shipName,
                    DataInizio = startDate,
                    DataFine = endDate,
                    NumeroEsecuzioni = executions,
                    CodPercorso = pathCode
                };

                db.NAVIGAZIONIs.InsertOnSubmit(navigazione);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Utilities.ClearAll(this);
        }

        /// <summary>
        /// Fills the path texbox with the one associated to the ship name selected.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>   
        private void ShipNameNavigationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = from p in db.PERCORSIs
                      where p.NomeNave == (String)ShipNameNavigationComboBox.SelectedItem
                      select p.CodPercorso;
            //PathCodeTextBox.Text = res.FirstOrDefault();
            PathCodeTextBox.Text = res.Count() > 0 ? res.First() : "NOT_SET";
        }

        /// <summary>
        /// Fills the navigation combobox with all navigations of the ship name selected.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>   
        private void ShipNameSectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShipNameSectionComboBox.SelectedIndex != -1)
            {
                var nav = from n in db.NAVIGAZIONIs
                          where n.NomeNave == ShipNameSectionComboBox.SelectedItem.ToString()
                          select n.CodNavigazione;
                if (nav.Count() == 0)
                {
                    NavigationSectionsComboBox.SelectedIndex = -1;
                    SectionsComboBox.SelectedIndex = -1;
                }
                NavigationSectionsComboBox.DataSource = nav;
            }
        }

        /// <summary>
        /// Fills the range navigation textbox and sections combobox with, respectively, the navigation 
        /// start and end date and all sections of the path associated to the navigation itself.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>   
        private void NavigationSectionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NavigationSectionsComboBox.SelectedIndex != -1)
            {
                var infoNav = from n in db.NAVIGAZIONIs
                              where n.CodNavigazione == int.Parse(NavigationSectionsComboBox.SelectedItem.ToString())
                              select new
                              {
                                  pathCode = n.CodPercorso,
                                  startNavDate = n.DataInizio,
                                  endNavDate = n.DataFine
                              };

                var dates = new DateRange(infoNav.First().startNavDate, infoNav.First().endNavDate);
                RangeNavigationTextBox.Text = dates.ToStringDate();

                /* NOTES that if the navigation is present into the database also the path is present.*/

                var pathCode = infoNav.First().pathCode;
                var secs = from s in db.SEQUENZE_TRATTEs
                           from t in db.TRATTEs
                           where s.CodPercorso == pathCode &&
                                 s.CodTratta == t.CodTratta
                           select s.CodTratta;
                SectionsComboBox.DataSource = secs;
            }
            else
            {
                RangeNavigationTextBox.Clear();
                SectionsComboBox.DataSource = null;
            }
        }

        /// <summary>
        /// Fills the harbors of the section textbox.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>   
        private void SectionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionsComboBox.SelectedIndex != -1)
            {
                var harbors = from t in db.TRATTEs
                              where t.CodTratta == int.Parse(SectionsComboBox.SelectedItem.ToString())
                              select new
                              {
                                  start = t.CodPortoPartenza,
                                  end = t.CodPortoArrivo
                              };
                string sectionHarbors = (String)harbors.First().start + " - " + (String)harbors.First().end;
                SectionHarborTextBox.Text = sectionHarbors;
            }
            else
            {
                SectionHarborTextBox.Clear();
            }
        }

        /// <summary>
        /// Implements integrity checks for sections execution. In details checks if the dates 
        /// are consistent with the other sections execution in the database.
        /// [NOTE] Not implemented checks on times!
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private bool checksExecutionSection(int navigation, DateTime start, DateTime stop)
        {
            var intersections = from e in db.ESECUZIONI_TRATTAs
                                where e.CodNavigazione == navigation &&
                                      ((start > e.Partenza_Data && start < e.Arrivo_Data) ||
                                      (stop > e.Partenza_Data && stop < e.Arrivo_Data))
                                select e.CodTratta;
            return intersections.Count() == 0;

            /*
            var infoNav = from n in db.NAVIGAZIONIs
                          where n.CodNavigazione == int.Parse(NavigationSectionsComboBox.SelectedItem.ToString())
                          select new
                          {
                              startNavDate = n.DataInizio,
                              endNavDate = n.DataFine
                          };
            var dates = new DateRange(infoNav.First().startNavDate, infoNav.First().endNavDate);
            return start >= dates.StartDate && stop <= dates.EndDate;
            */
        }

        /// <summary>
        /// Insert a new section execution.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddExecutionSection_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                int navigation = int.Parse(NavigationSectionsComboBox.Text);
                int section = int.Parse(SectionsComboBox.Text);
                DateTime startDate = DateStartSection.Value.Date;
                TimeSpan startTime = new TimeSpan(TimeStartSection.Value.Hour,
                    TimeStartSection.Value.Minute, TimeStartSection.Value.Second);
                DateTime endDate = EndDateSection.Value.Date;
                TimeSpan endTime = new TimeSpan(EndTimeSection.Value.Hour,
                    EndTimeSection.Value.Minute, EndTimeSection.Value.Second);

                if (!checksExecutionSection(navigation, startDate, endDate))
                {
                    msg = "La data di esecuzione tratta devono essere coerenti tra loro!";
                    throw new ArgumentException(msg);
                }

                /* Inserting a new section execution */
                ESECUZIONI_TRATTA estratta = new ESECUZIONI_TRATTA
                {
                    CodNavigazione = navigation,
                    CodTratta = section,
                    Partenza_Data = startDate,
                    Partenza_Ora = startTime,
                    Arrivo_Data = endDate,
                    Arrivo_Ora = endTime
                };

                db.ESECUZIONI_TRATTAs.InsertOnSubmit(estratta);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Utilities.ClearAll(this);
        }
    }
}
