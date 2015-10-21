using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportCenter
{
    public partial class frmChooseDatabase : Form
    {
        public frmChooseDatabase()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Test db connection
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //if connect to database
                //save db list
                //this.Close();
        }

        public bool OpenSupportDatabase()
        {
            //load saved database list
            this.Show();

            return true;
        }

        private void LoadSavedDatabaseList()
        {
            //GetSetting(App name, "Connections", DB + intIndex)

            //fill grid
        }

        private bool ConnectToDB()
        {
            //set global connection properties

            //attempt to connect
            return true;
        }
    }
}
