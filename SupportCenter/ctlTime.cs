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
    public partial class ctlTime : UserControl
    {
        public ctlTime()
        {
            InitializeComponent();
        }

        private void ctlTime_Load(object sender, EventArgs e)
        {
            //if new init


            //else get data
                //set fields 

        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartTime.Value.ToShortDateString() != dtpEndTime.Value.ToShortDateString()) {    // update date of dtpEndTime
                dtpEndTime.Value = dtpStartTime.Value;
            }
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartTime.Value.ToShortDateString() != dtpEndTime.Value.ToShortDateString()) {    // update date of dtpStartTime
                dtpStartTime.Value = dtpEndTime.Value;
            }
        }



    }
}
