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
    public partial class AddShipPopup : Form
    {
        private DataClassesDBCrociereDataContext db;

        public AddShipPopup(DataClassesDBCrociereDataContext dbDataContext)
        {
            db = dbDataContext;
            InitializeComponent();
        }

        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void AddShipInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ShipNameTextBox.Text;
                int length = int.Parse(LengthTextBox.Text);
                int width = int.Parse(WidthTextBox.Text);
                int weight = int.Parse(WeightTextBox.Text);
                int height = int.Parse(HeightTextBox.Text);
                int cabinsNum = int.Parse(CabinsNumTextBox.Text);

                /* Inserimento di una nuova nave */
                NAVI nave = new NAVI
                {
                    Nome = name,
                    Larghezza = width,
                    Lunghezza = length,
                    Peso = weight,
                    Altezza = height,
                    NumeroCabine = cabinsNum
                };

                db.NAVIs.InsertOnSubmit(nave);
                db.SubmitChanges();
                var msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                var msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.ToString() + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShipNameComboPath_Click(object sender, EventArgs e)
        {
            var ships = from navi in db.NAVIs
                        select navi.Nome;
            ShipNameComboPath.DataSource = ships;
        }

        private void AddPathBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string pathCode = CodPathTextBox.Text;
                int duration = int.Parse(DurationTextBox.Text);
                string shipName = ShipNameComboPath.SelectedItem.ToString();

                /* Inserimento di una nuovo percorso */
                PERCORSI percorso = new PERCORSI
                {
                    CodPercorso = pathCode,
                    NomeNave = shipName,
                    GiorniDurata = duration
                };
                
                db.PERCORSIs.InsertOnSubmit(percorso);
                db.SubmitChanges();
                var msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                var msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.ToString() + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddShipPopup_Load(object sender, EventArgs e)
        {
            var sections = from t in db.TRATTEs
                           from p1 in db.PORTIs
                           from p2 in db.PORTIs
                           where p1.CodPorto == t.CodPortoPartenza && p2.CodPorto == t.CodPortoArrivo
                           select new
                           {
                               SEC_CODE = t.CodTratta,
                               ARR_PORT = p2.Città,
                               DEP_PORT = p1.Città                               
                           };
            SectionsListBox.DataSource = sections;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertedSections.Items.Add(SectionsListBox.SelectedItem.ToString());
            SectionsListBox.Items.RemoveAt(SectionsListBox.SelectedIndex);
            

        }
    }
}
