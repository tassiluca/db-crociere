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
    public partial class App : Form
    {
        DataClassesDBCrociereDataContext db = new DataClassesDBCrociereDataContext();
        public App()
        {
            InitializeComponent();
        }

        private void initNavigation()
        {
            var res = from porti in db.PORTIs
                      select new { porti.CodPorto };
            NavigationDropDownMenu.DataSource = res;
        }

        private Dictionary<TextBox, string> getShipCode(string shipName)
        {
            var shipInfos = new Dictionary<TextBox, string>();
            
            shipInfos.Add(ShipNameTextBox, shipName);

            var code = from navi in db.NAVIs
                        where String.Equals(navi.Nome, shipName) == true
                        select navi.CodNave;
            shipInfos.Add(ShipCodeTextBox, code.First().ToString());

            var width = from navi in db.NAVIs
                        where navi.Nome == shipName
                        select navi.Larghezza;
            shipInfos.Add(WidthTextBox, width.First().ToString());

            var length = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Lunghezza;
            shipInfos.Add(LengthTextBox, length.First().ToString());

            var weight = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Peso;
            shipInfos.Add(WeightTextBox, weight.First().ToString());

            var height = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Altezza;
            shipInfos.Add(HeightTextBox, height.First().ToString());

            var cabins = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.NumeroCabine;
            shipInfos.Add(CabinsNumTextBox, cabins.First().ToString());

            return shipInfos;
        }

        private void initShipInfo(String shipName)
        {
            var shipInfos = getShipCode(shipName);
            foreach (KeyValuePair<TextBox, string> elem in shipInfos)
            {
                elem.Key.Text = elem.Value;
            }
        }

        private void initPathInfo()
        {

        }

        private void onShipTabClick(object sender, EventArgs e)
        {
            var ships = from navi in db.NAVIs
                        select navi.Nome;
            shipListBox.DataSource = ships;
            initShipInfo(ships.ToArray()[0]);
            initPathInfo();
            initNavigation();
        }

        private void shipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Console.WriteLine("" + lb.SelectedIndex);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddShipBtnClick(object sender, EventArgs e)
        {
            var addShipPopup = new AddShipPopup(db);
            addShipPopup.ShowDialog(this);
        }

        private void shipListBox_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
