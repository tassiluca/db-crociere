using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_crociere.Activities
{
    public partial class AddActivitiesPopup : Form
    {
        private DataClassesDBCrociereDataContext db;

        public AddActivitiesPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            InitializeComponent();
        }

        private void NavigationCodeComboBox_Click(object sender, EventArgs e)
        {
            var navigations = from n in db.NAVIGAZIONI
                              select n.CodNavigazione;
            NavigationCodeComboBox.DataSource = navigations;
        }

        private void NavigationCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NavigationCodeComboBox.SelectedIndex != -1)
            {
                var navInfos = (from n in db.NAVIGAZIONI
                                where n.CodNavigazione == int.Parse(NavigationCodeComboBox.Text)
                                select new
                                {
                                    start = n.DataInizio,
                                    end = n.DataFine,
                                    shipName = n.NomeNave
                                }).First();
                NavigationTextBox.Text = navInfos.start + " " + navInfos.end;
                var rooms = from s in db.SALE
                            where s.NomeNave == navInfos.shipName
                            select s.CodSala;
                if (!rooms.Any())
                {
                    RoomComboBox.SelectedIndex = -1;
                }
                RoomComboBox.DataSource = rooms;
            }
            else
            {
                NavigationTextBox.Clear();
                RoomComboBox.DataSource = null;
                RoomComboBox.SelectedIndex = -1;
            }
        }

        private void ActivityComboBox_Click(object sender, EventArgs e)
        {
            var activities = from a in db.ATTIVITÀ
                             select a.Nome;
            ActivityComboBox.DataSource = activities;
        }

        private void AddActivityBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string name = ActivityNameTextBox.Text;
                string description = ActivityDescriptionTextBox.Text;

                ATTIVITÀ attività = new ATTIVITÀ
                {
                    Nome = name,
                    Descrizione = description
                };

                db.ATTIVITÀ.InsertOnSubmit(attività);
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

        private bool checksExecution(DateTime start, int navigation)
        {
            var navInfos = (from n in db.NAVIGAZIONI
                            where n.CodNavigazione == navigation
                            select n).First();
            return start >= navInfos.DataInizio && start <= navInfos.DataFine;
        }

        private void AddActivityExecutionBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                DateTime startDate = StartDatePicker.Value;
                TimeSpan startTime = new TimeSpan(StartTimePicker.Value.Hour,
                    StartTimePicker.Value.Minute, StartTimePicker.Value.Second);
                int room = int.Parse(RoomComboBox.Text);
                string activityName = ActivityComboBox.Text;
                int activityCode = (int)(from a in db.ATTIVITÀ
                                    where a.Nome == activityName
                                    select a).First().CodAttività;
                int navigation = int.Parse(NavigationCodeComboBox.Text);
                int duration = int.Parse(DurationTextBox.Text);

                if (!checksExecution(startDate, navigation))
                {
                    msg = "La data deve essere coerente con la navigaziione";
                    throw new ArgumentException(msg);
                }

                PROGRAMMAZIONI programmazione = new PROGRAMMAZIONI
                {
                    InizioData = startDate,
                    InizioOra = startTime,
                    CodSala = room,
                    CodAttività = activityCode,
                    CodNavigazione = navigation,
                    Durata = duration
                };
                db.PROGRAMMAZIONI.InsertOnSubmit(programmazione);

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
