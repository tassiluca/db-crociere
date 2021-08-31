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
    }
}
