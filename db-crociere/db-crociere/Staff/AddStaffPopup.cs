using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_crociere.Staff
{
    public partial class AddStaffPopup : Form
    {

        private DataClassesDBCrociereDataContext db;

        public AddStaffPopup(DataClassesDBCrociereDataContext db)
        {
            this.db = db;
            InitializeComponent();
        }


        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roleName = from r in db.RUOLI
                           where r.CodRuolo == RoleComboBox.Text
                           select r.Nome;
            RoleInfo.Text = roleName.FirstOrDefault();
        }


        /// <summary>
        /// Fills the roles combobox.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void FillsRoles(ComboBox cb)
        {
            var roles = from r in db.RUOLI
                        select r.CodRuolo;
            cb.DataSource = roles;
        }

        private void RoleComboBox_Click(object sender, EventArgs e)
        {
            FillsRoles(RoleComboBox);
        }

        private void ResponsabilityRoleComboBox_Click(object sender, EventArgs e)
        {
            FillsRoles(ResponsabilityRoleComboBox);
        }

        /// <summary>
        /// Manages the graphics insertion of officials or crew enabling or disabling
        /// the correctly related fields. This routine is activated when official insertion
        /// is requested by the user.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void InsertOfficialCheckBox_Click(object sender, EventArgs e)
        {
            if (InsertOfficialCheckBox.Checked == true)
            {
                InsertCrewCheckBox.Checked = false;
                InsertCrewLayoutPanel
                    .Controls
                    .OfType<TextBox>()
                    .ToList()
                    .ForEach(tb => tb.Enabled = true);
                RoleComboBox.Enabled = true;
            } else
            {
                Console.WriteLine("ELSE");
                InsertCrewLayoutPanel.Controls
                    .OfType<TextBox>()
                    .ToList()
                    .ForEach(tb => tb.Enabled = false);
                RoleComboBox.Enabled = false;
                RoleComboBox.DataSource = null;
            }
        }

        /// <summary>
        /// Manages the graphics insertion of officials or crew enabling or disabling
        /// the correctly related fields. This routine is activated when crew insertion
        /// is requested by the user.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void InsertCrewCheckBox_Click(object sender, EventArgs e)
        {
            if (InsertCrewCheckBox.Checked == true)
            {
                InsertOfficialCheckBox.Checked = false;
                InsertCrewLayoutPanel.Controls
                    .OfType<TextBox>()
                    .ToList()
                    .ForEach(tb => tb.Enabled = true);
                RoleComboBox.Enabled = true;
                SeniortyTextBox.Enabled = false;
                RankTextBox.Enabled = false;
            } else
            {
                InsertCrewLayoutPanel.Controls
                    .OfType<TextBox>()
                    .ToList()
                    .ForEach(tb => {
                        tb.Enabled = false;
                        tb.Clear();
                    });
                RoleComboBox.Enabled = false;
                RoleComboBox.DataSource = null;
            }
        }

        /// <summary>
        /// Add a new crew or official depending on which InsertOfficialCheckBox 
        /// or InsertCrewCheckBox is checked.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddCrewBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string fiscalCode = FiscalCodeTextBox.Text;
                string name = NameTextBox.Text;
                string surname = SurnameTextBox.Text;
                string nationality = NationalityTextBox.Text;
                string passport = PassPortTextBox.Text;
                string phoneNumber = PhoneNumTextBox.Text;
                int salary = int.Parse(SalaryTextBox.Text);
                string role = RoleComboBox.Text;

                if (InsertOfficialCheckBox.Checked == true)
                {
                    string rank = RankTextBox.Text;
                    int seniority = int.Parse(SeniortyTextBox.Text);
                    PERSONALE cabina = new PERSONALE
                    {
                        CodiceFiscale = fiscalCode,
                        Nome = name,
                        Cognome = surname,
                        Nazionalità = nationality,
                        Passaporto = passport,
                        Recapito = phoneNumber,
                        StipendioAnnuo = salary,
                        CodRuolo = role,
                        AnzianitàServizio = seniority,
                        Grado = rank
                    };
                    db.PERSONALE.InsertOnSubmit(cabina);
                }
                else
                {
                    PERSONALE cabina = new PERSONALE
                    {
                        CodiceFiscale = fiscalCode,
                        Nome = name,
                        Cognome = surname,
                        Nazionalità = nationality,
                        Passaporto = passport,
                        Recapito = phoneNumber,
                        StipendioAnnuo = salary,
                        CodRuolo = role
                    };
                    db.PERSONALE.InsertOnSubmit(cabina);
                }

                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                Utilities.ShowErrorMessage(msg);
                db = new DataClassesDBCrociereDataContext();
            }
            Utilities.ClearAll(this);
        }

        /// <summary>
        /// Add a new role into the database.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddRoleBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string role = RoleCodeTextBox.Text;
                string description = RoleDescriptionTextBox.Text;
                string name = RoleNameTextBox.Text;

                RUOLI ruolo = new RUOLI
                {
                    CodRuolo = role,
                    Descrizione = description,
                    Nome = name
                };

                db.RUOLI.InsertOnSubmit(ruolo);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                Utilities.ShowErrorMessage(msg);
                db = new DataClassesDBCrociereDataContext();
            }
            Utilities.ClearAll(this);
        }

        /// <summary>
        /// Checks integrity on shifts. In details: a new shift can be accepted 
        /// only if a service in that day is present.
        /// </summary>
        /// <param name="fiscalCode"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private bool ChecksShifts(string fiscalCode, DateTime start, DateTime end)
        {
            var res = (from s in db.SERVIZI
                       from n in db.NAVIGAZIONI
                       where s.CodiceFiscale == fiscalCode &&
                             s.CodNavigazione == n.CodNavigazione &&
                             start.Date >= n.DataInizio && start.Date <= n.DataFine &&
                             end.Date >= n.DataInizio && end.Date <= n.DataFine
                       select n.CodNavigazione).Count();
            return res == 1;
        }

        /// <summary>
        /// Adds a shift in the database.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddShift_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string fiscalCode = ShiftFiscalCodeComboBox.Text;
                DateTime startDate = StartDatePicker.Value;
                DateTime endDate = EndDatePicker.Value;

                if (!ChecksShifts(fiscalCode, startDate, endDate))
                {
                    msg = "Non puoi inserire un turno se in quella " +
                        "data non è previsto un servizio!";
                    throw new ArgumentException(msg);
                }

                TURNI_LAVORATIVI tl = new TURNI_LAVORATIVI
                {
                    CodiceFiscale = fiscalCode,
                    DataOraInizio = startDate,
                    DataOraFine = endDate
                };

                db.TURNI_LAVORATIVI.InsertOnSubmit(tl);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                Utilities.ShowErrorMessage(msg);
                db = new DataClassesDBCrociereDataContext();
            }
            Utilities.ClearAll(this);
        }

        /// <summary>
        /// Fills the fiscal code combobox passed in input.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void FillsFiscalCodeComboBox(ComboBox cb)
        {
            var fc = from p in db.PERSONALE
                     select p.CodiceFiscale;
            cb.DataSource = fc;
        }


        private void FiscalCodeComboBox_Click(object sender, EventArgs e)
        {
            FillsFiscalCodeComboBox(ShiftFiscalCodeComboBox);
        }

        private void ServiceFiscalCodeComboBox_Click(object sender, EventArgs e)
        {
            FillsFiscalCodeComboBox(ServiceFiscalCodeComboBox);
        }

        private void ResponsabilityFiscalCode_Click(object sender, EventArgs e)
        {
            FillsFiscalCodeComboBox(ResponsabilityFiscalCodeComboBox);
        }

        /// <summary>
        /// Fills the fiscal code combobox passed in input.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void FillsNavigationComboBox(ComboBox cb)
        {
            var fn = from n in db.NAVIGAZIONI
                     select n.CodNavigazione;
            cb.DataSource = fn;
        }

        private void NavigationComboBox_Click(object sender, EventArgs e)
        {
            FillsNavigationComboBox(ServiceNavigationComboBox);
        }

        private void ResponsabilityNavigationComboBox_Click(object sender, EventArgs e)
        {
            FillsNavigationComboBox(ResponsabilityNavigationComboBox);
        }

        /// <summary>
        /// Integrity checks: i cannot insert a new service if another service
        /// in the same period have been already inserted.
        /// </summary>
        /// <returns></returns>
        private bool ChecksServices(string fiscalCode, int navigation)
        {
            var navDates = (from n in db.NAVIGAZIONI
                            where n.CodNavigazione == navigation
                            select new
                            {
                                start = n.DataInizio,
                                end = n.DataFine
                            }).First();

            var intersections = (from s in db.SERVIZI
                                 from n in db.NAVIGAZIONI
                                 where s.CodNavigazione == n.CodNavigazione &&
                                       s.CodiceFiscale == fiscalCode &&
                                       ((navDates.start >= n.DataInizio && navDates.start <= n.DataFine) ||
                                       (navDates.end >= n.DataInizio && navDates.end <= n.DataFine) ||
                                       (n.DataInizio >= navDates.start && n.DataInizio <= navDates.end) ||
                                       (n.DataFine >= navDates.end && n.DataFine <= navDates.end))
                                 select n.CodNavigazione).Count();
            return intersections == 0;
        }

        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                int navigation = int.Parse(ServiceNavigationComboBox.Text);
                string fiscalCode = ServiceFiscalCodeComboBox.Text;

                if (!ChecksServices(fiscalCode, navigation))
                {
                    msg = "Non puoi inserire un servizio se un'altro " +
                        "nello stesso periodo è già stato inserito!";
                    throw new ArgumentException(msg);
                }

                SERVIZI servizio = new SERVIZI
                {
                    CodNavigazione = navigation,
                    CodiceFiscale = fiscalCode
                };

                db.SERVIZI.InsertOnSubmit(servizio);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                Utilities.ShowErrorMessage(msg);
                db = new DataClassesDBCrociereDataContext();
            }
            Utilities.ClearAll(this);
        }

        /// <summary>
        /// Integrity Checks Responsabilities.
        /// </summary>
        /// <returns></returns>
        private bool ChecksResponsabilities(int navigation, string fiscalCode)
        {
            var res = (from s in db.SERVIZI
                       where s.CodiceFiscale == fiscalCode && s.CodNavigazione == navigation
                       select s).Count();
            return res == 1;
        }

        /// <summary>
        /// Adds a new responsability into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddResponsability_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                int navigation = int.Parse(ResponsabilityNavigationComboBox.Text);
                string fiscalCode = ResponsabilityFiscalCodeComboBox.Text;
                string role = ResponsabilityRoleComboBox.Text;

                if (!ChecksResponsabilities(navigation, fiscalCode))
                {
                    msg = "Un personale non può essere responsabile all’interno di " +
                        "una navigazione se non vi presta servizio ";
                    throw new ArgumentException(msg);
                }

                RESPONSABILITÀ responsabilities = new RESPONSABILITÀ
                {
                    CodNavigazione = navigation,
                    CodiceFiscale = fiscalCode,
                    CodRuolo = role
                };

                db.RESPONSABILITÀ.InsertOnSubmit(responsabilities);
                db.SubmitChanges();
                msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                Utilities.ShowErrorMessage(msg);
                db = new DataClassesDBCrociereDataContext();
            }
            Utilities.ClearAll(this);
        }
    }
}
