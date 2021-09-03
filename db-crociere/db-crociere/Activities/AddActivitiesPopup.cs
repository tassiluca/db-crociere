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
            var navigations = from n in db.NAVIGAZIONIs
                              select n.CodNavigazione;
            NavigationCodeComboBox.DataSource = navigations;
        }

        private void NavigationCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NavigationCodeComboBox.SelectedIndex != -1)
            {
                var navInfos = (from n in db.NAVIGAZIONIs
                                where n.CodNavigazione == int.Parse(NavigationCodeComboBox.Text)
                                select new
                                {
                                    start = n.DataInizio,
                                    end = n.DataFine,
                                    shipName = n.NomeNave
                                }).First();
                NavigationTextBox.Text = navInfos.start + " " + navInfos.end;
                var rooms = from s in db.SALEs
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
        /*
        private void AddActivityExecutionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = StartDatePicker.Value;
                TimeSpan startTime = new TimeSpan(StartTimePicker.Value.Hour,
                    StartTimePicker.Value.Minute, StartTimePicker.Value.Second);
                int room =

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
        */
    }
}
