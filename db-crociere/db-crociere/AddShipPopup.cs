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

        /// <summary>
        /// The routine which inserts a new ship into the database.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
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

        private void ShipNameDeckComboBox_Click(object sender, EventArgs e)
        {
            FillShipNameCombo(ShipNameDeckComboBox);
        }

        private void ShipNameSpaceComboBox_Click(object sender, EventArgs e)
        {
            FillShipNameCombo(ShipNameSpaceComboBox);
        }

        /// <summary>
        /// Insert a new cabin type.
        /// [NOTE] NOT CONCLUDED -- PRICE
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddTypeBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string name = NameTypeTextBox.Text;
                int price = int.Parse(TypePriceTextBox.Text);
                string description = TypeDescriptionTextBox.Text;

                TIPOLOGIE tipologia = new TIPOLOGIE
                {
                    Nome = name,
                    Prezzo = price,
                    Descrizione = description
                };

                db.TIPOLOGIEs.InsertOnSubmit(tipologia);
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
        /// Add a new deck inside the database.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddDeckBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string name = ShipNameDeckComboBox.Text;
                int numOfDecks = int.Parse(DecksNumTextBox.Text);

                for (; numOfDecks > 0; numOfDecks--)
                {
                    PONTI ponto = new PONTI
                    {
                        NomeNave = name,
                        Numero = numOfDecks
                    };

                    db.PONTIs.InsertOnSubmit(ponto);
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
        /// Manages the graphics insertion of cabins or rooms enabling or disabling
        /// the correctly related fields. This routine is activated when cabins insertion
        /// is requested by the user.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void InsertCabinCheckBox_Click(object sender, EventArgs e)
        {
            if (InsertCabinCheckBox.Checked == true)
            {
                InsertRoomCheckBox.Checked = false;
                SpaceCapacityTextBox.Enabled = true;
                CapacitySpaceInfo.Text = "Posti Letto";
                SpacePositionComboBox.Enabled = true;
                SpaceTypeComboBox.Enabled = true;
            }
            else
            {
                SpaceCapacityTextBox.Enabled = false;
                SpaceCapacityTextBox.Clear();

                SpacePositionComboBox.Enabled = false;
                SpacePositionComboBox.SelectedIndex = -1;

                SpaceTypeComboBox.Enabled = false;
                SpaceTypeComboBox.DataSource = null;
            }
        }

        /// <summary>
        /// Manages the graphics insertion of cabins or rooms enabling or disabling
        /// the correctly related fields. This routine is activated when rooms insertion
        /// is requested by the user.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void InsertRoomCheckBox_Click(object sender, EventArgs e)
        {
            if (InsertRoomCheckBox.Checked == true)
            {
                InsertCabinCheckBox.Checked = false;
                SpaceCapacityTextBox.Enabled = true;
                CapacitySpaceInfo.Text = "Capienza";

                SpacePositionComboBox.Enabled = false;
                SpacePositionComboBox.SelectedIndex = -1;

                SpaceTypeComboBox.Enabled = false;
                SpaceTypeComboBox.DataSource = null;
            }
            else
            {
                CapacitySpaceInfo.Text = "Posti Letto";
                SpaceCapacityTextBox.Enabled = false;
                SpaceCapacityTextBox.Clear();
            }
        }

        private void ShipNameSpaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShipNameSpaceComboBox.SelectedIndex != -1)
            {
                var decks = from p in db.PONTIs
                            where p.NomeNave == ShipNameSpaceComboBox.SelectedItem.ToString()
                            select p.Numero;
                if (!decks.Any()) //CHECK
                {
                    DeckNumberSpaceComboBox.SelectedIndex = -1;
                }
                DeckNumberSpaceComboBox.DataSource = decks;
            }
        }

        private void SpaceTypeComboBox_Click(object sender, EventArgs e)
        {
            var types = from t in db.TIPOLOGIEs
                        select t.Nome;
            SpaceTypeComboBox.DataSource = types;
        }

        /// <summary>
        /// Add a new space, cabin or room, depending on which InsertRoomCheckBox 
        /// or InsertCabinCheckBox is checked.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Contains the event data.</param> 
        private void AddSpacesBtn_Click(object sender, EventArgs e)
        {
            string msg;
            try
            {
                string name = ShipNameSpaceComboBox.Text;
                int deck = int.Parse(DeckNumberSpaceComboBox.Text);
                int spacesNum = int.Parse(SpacesNumberTextBox.Text);
                int capacity = int.Parse(SpaceCapacityTextBox.Text);

                var i = (from c in db.CABINEs
                         where c.NomeNave == name && c.NumeroPonte == deck
                         select c.NumeroLocale).OrderByDescending(x => x).FirstOrDefault();

                Console.WriteLine(name + " " + deck + " " + spacesNum + " " + capacity);

                if (InsertCabinCheckBox.Enabled == true)
                {
                    for (var j = i + 1; j <= i + spacesNum; j++)
                    {
                        string position = SpacePositionComboBox.Text;
                        string type = SpaceTypeComboBox.Text;
                        CABINE cabina = new CABINE
                        {
                            NomeNave = name,
                            NumeroPonte = deck,
                            NumeroLocale = j,
                            PostiLetto = capacity,
                            Posizione = position,
                            NomeTipologia = type
                        };
                        db.CABINEs.InsertOnSubmit(cabina);
                    }
                } else
                {
                    for (var j = i + 1; j <= i + spacesNum; j++)
                    {
                        SALE sala = new SALE
                        {
                            NomeNave = name,
                            NumeroPonte = deck,
                            NumeroLocale = j,
                            Capienza = capacity,
                        };
                        db.SALEs.InsertOnSubmit(sala);
                    }
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

    }
}
