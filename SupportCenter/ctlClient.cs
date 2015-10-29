using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportCenter
{
    public partial class ctlClient : UserControl
    {
        private ctlConnectionInfo mctlConnectionInfo;
        private clsClient mobjClient;
        private string mstrClientCode;

        public ctlClient()
        {
            InitializeComponent();
        }

        public string ClientCode {
            get
            {
                return mobjClient.ClientCode;
            }
            set
            {
                mobjClient.ClientCode = value;
            }
        }

        private void ctlClient_Load(object sender, EventArgs e)
        {
            //init
            mctlConnectionInfo = new ctlConnectionInfo();

            //query


            //fill data into sections

            //add settings to Connection Info Panel
            pnlConnectionInfo.Controls.Add(mctlConnectionInfo);
            pnlConnectionInfo.Controls[pnlConnectionInfo.Controls.GetChildIndex(mctlConnectionInfo)].Dock = DockStyle.Fill;
            pnlConnectionInfo.Refresh();

        }

        public void SwitchClientTo(string pstrClientCode)
        {
            //load new client

        }

        private void rbtnSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSettings.Checked == true)   //Show settings if btn is checked
            {
                Control ctl = pnlConnectionInfo.Controls[pnlConnectionInfo.Controls.GetChildIndex(mctlConnectionInfo)];
                ctl.BringToFront();
            }
        }

        private void rbtnOtherInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOtherInfo.Checked == true)  //Hide Settings Panel
            {
                Control ctl = pnlConnectionInfo.Controls[pnlConnectionInfo.Controls.GetChildIndex(mctlConnectionInfo)];
                ctl.SendToBack();
            }
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            // show item control for current client
        }
    }
}
