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
        private List<decimal> sectionsList = new List<decimal>();
        private List<decimal> selectedSections = new List<decimal>();

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
                var msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShipNameComboPath_Click(object sender, EventArgs e)
        {
            var ships = from navi in db.NAVIs
                        select navi.Nome;
            ShipNameComboPath.DataSource = ships;
        }

        private List<string> getHarboursOfSections(decimal codSection)
        {
            List<string> harboursList = new List<string>();
            var harbours = (from p1 in db.PORTIs
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

            harboursList.Add(harbours[0].START);
            harboursList.Add(harbours[0].END);
            return harboursList;
        }

        private bool checksSections()
        {
            var start = getHarboursOfSections(selectedSections[0])[0];
            var end = getHarboursOfSections(selectedSections[selectedSections.Count() - 1])[1];

            if ( start.First() != end.First() )
            {
                return false;
            }
            return true;
        }

        private void AddPathBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string pathCode = CodPathTextBox.Text;
                int duration = int.Parse(DurationTextBox.Text);
                string shipName = ShipNameComboPath.SelectedItem.ToString();

                if (!checksSections())
                {
                    throw new ArgumentException("Il porto di partenza della prima tratta deve coincidere con il porto di arrivo dell'ultima");
                }

                /* Inserimento di una nuovo percorso */
                PERCORSI percorso = new PERCORSI
                {
                    CodPercorso = pathCode,
                    NomeNave = shipName,
                    GiorniDurata = duration
                };
                db.PERCORSIs.InsertOnSubmit(percorso);

                /* Inserimento delle nuove sequenze_tratte */
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
                var msg = "Inserimento avvenuto con SUCCESSO";
                MessageBox.Show(msg, "SUCCESSO");
            }
            catch (Exception exc)
            {
                var msg = "Inserimento NON andato a buon fine. Controllare i dati immessi (" + exc.Message + ")";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AddShipPopup_Load(sender, e);
        }

        private void AddShipPopup_Load(object sender, EventArgs e)
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
                string msg = "[" + elem.SEC_CODE + "] "+ elem.DEP_PORT + " -> " + elem.ARR_PORT;
                SectionsListBox.Items.Add(msg);
                sectionsList.Add(elem.SEC_CODE);
            }
            selectedSections.Clear();
            InsertedSections.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SectionsListBox.SelectedIndex != -1)
            {
                InsertedSections.Items.Add(SectionsListBox.SelectedItem.ToString());
                selectedSections.Add(sectionsList.ToArray()[SectionsListBox.SelectedIndex]);
                sectionsList.RemoveAt(SectionsListBox.SelectedIndex);
                SectionsListBox.Items.RemoveAt(SectionsListBox.SelectedIndex);

                Console.WriteLine("---- SELEZIONATI --- ");
                foreach (var elem in selectedSections)
                {
                    Console.WriteLine(elem);
                }
                Console.WriteLine("---------------------");
            } else
            {
                var msg = "Nessuna selezione!";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSectionPathBtn_Click(object sender, EventArgs e)
        {
            if (InsertedSections.SelectedIndex != -1)
            {
                SectionsListBox.Items.Add(InsertedSections.SelectedItem.ToString());
                sectionsList.Add(selectedSections.ToArray()[InsertedSections.SelectedIndex]);
                selectedSections.RemoveAt(InsertedSections.SelectedIndex);
                InsertedSections.Items.RemoveAt(InsertedSections.SelectedIndex);

                Console.WriteLine("---- SELEZIONATI --- ");
                foreach (var elem in selectedSections)
                {
                    Console.WriteLine(elem);
                }
                Console.WriteLine("---------------------");
                Console.WriteLine("---- SELEZIONABILI --- ");
                foreach (var elem in sectionsList)
                {
                    Console.WriteLine(elem);
                }
                Console.WriteLine("---------------------");
            } else
            {
                var msg = "Nessuna selezione!";
                MessageBox.Show(msg, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
