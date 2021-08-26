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

        private Dictionary<Label, string> getShipCode(string shipName)
        {
            var shipInfos = new Dictionary<Label, string>();
            
            shipInfos.Add(ShipNameLabel, shipName);

            var code = from navi in db.NAVIs
                        where String.Equals(navi.Nome, shipName) == true
                        select navi.CodNave;
            shipInfos.Add(ShipCodeLabel, code.First().ToString());

            var width = from navi in db.NAVIs
                        where navi.Nome == shipName
                        select navi.Larghezza;
            shipInfos.Add(WidthLabel, width.First().ToString());

            var length = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Lunghezza;
            shipInfos.Add(LengthLabel, length.First().ToString());

            var weight = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Peso;
            shipInfos.Add(WeightLabel, weight.First().ToString());

            var height = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.Altezza;
            shipInfos.Add(HeightLabel, height.First().ToString());

            var cabins = from navi in db.NAVIs
                         where navi.Nome == shipName
                         select navi.NumeroCabine;
            shipInfos.Add(CabinsNumLabel, cabins.First().ToString());

            return shipInfos;
        }

        private void fillShipInfo(String shipName)
        {
            var shipInfos = getShipCode(shipName);
            foreach (KeyValuePair<Label, string> elem in shipInfos)
            {
                elem.Key.Text = elem.Value;
            }
        }

        private void initPathInfo()
        {

        }

        private void updateShipList(object sender, EventArgs e)
        {
            var ships = from navi in db.NAVIs
                        select navi.Nome;
            shipListBox.DataSource = ships;
            fillShipInfo(ships.ToArray()[0]);
            initPathInfo();
            initNavigation();
        }

        private void shipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("INDEX SHIPLIST CHANGED");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddShipBtnClick(object sender, EventArgs e)
        {
            var addShipPopup = new AddShipPopup(db);
            addShipPopup.ShowDialog(this);
        }

        private void App_Activated(object sender, EventArgs e)
        {
            updateShipList(sender, e);
        }

        private void shipListBox_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(shipListBox.SelectedItem.ToString());
            fillShipInfo(shipListBox.SelectedItem.ToString());
        }
    }
}
