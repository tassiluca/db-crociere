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
            var roleName = from r in db.RUOLIs
                           where r.CodRuolo == RoleComboBox.Text
                           select r.Nome;
            RoleInfo.Text = roleName.FirstOrDefault();
        }

        /// <summary>
        /// Fills the roles combobox.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void RoleComboBox_Click(object sender, EventArgs e)
        {
            var roles = from r in db.RUOLIs
                        select r.CodRuolo;
            RoleComboBox.DataSource = roles;
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
                // TODO: to change int phoneNumber --> string
                int phoneNumber = int.Parse(PhoneNumTextBox.Text);
                int salary = int.Parse(SalaryTextBox.Text);
                string role = RoleComboBox.Text;

                if (InsertOfficialCheckBox.Enabled == true)
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
                    db.PERSONALEs.InsertOnSubmit(cabina);
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
                    db.PERSONALEs.InsertOnSubmit(cabina);
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

                db.RUOLIs.InsertOnSubmit(ruolo);
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
        /// 
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddShift_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string fiscalCode = FiscalCodeComboBox.Text;
                DateTime startDate = StartDatePicker.Value;
                DateTime endDate = EndDatePicker.Value;

                TURNI_LAVORATIVI tl = new TURNI_LAVORATIVI
                {
                    CodiceFiscale = fiscalCode,
                    DataOraInizio = startDate,
                    DataOraFine = endDate
                };

                db.TURNI_LAVORATIVIs.InsertOnSubmit(tl);
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
        /// Fills the fiscal code combobox.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void FiscalCodeComboBox_Click(object sender, EventArgs e)
        {
            var fc = from p in db.PERSONALEs
                     select p.CodiceFiscale;
            FiscalCodeComboBox.DataSource = fc;
        }
    }
}
