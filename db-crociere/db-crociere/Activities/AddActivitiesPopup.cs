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
                RoomComboBox.DataSource = rooms;
            } else
            {
                NavigationTextBox.Clear();
                RoomComboBox.DataSource = null;
                RoomComboBox.SelectedIndex = -1;
            }
        }
    }
}
