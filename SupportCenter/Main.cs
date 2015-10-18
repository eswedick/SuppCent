using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportCenter
{
    public partial class frmMain : Form
    {
        private ctlClient mctlClient;
        private ctlTime mctlTime;
        private ctlItem mctlItem;
        private ctlDevDoc mctlDevDoc;
        //private ToolStripDropDown ddNewMessage;

        private clsDeveloper mobjDeveloper;

        private DataTable mdtOpenItems;

        public frmMain()
        {
            InitializeComponent();

            // handler for key events
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmMain_KeyDown);

        }

        //-----------------------------------------------
        // Menu Items
        //-----------------------------------------------
        private void clientToolStripMenuItem1_Click(object sender, EventArgs e) // Show Client
        {
            // create new Client control if necessary
            if (this.pnlControlPanel.Controls.Contains(mctlClient) == false)         
            {
                CreateNewClient();
            }

            // Show Client cotrol
            Control ctl = pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlClient)];
            ctl.BringToFront();

        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e) // Item
        {
            // create new Item control if necessary
            if (this.pnlControlPanel.Controls.Contains(mctlItem) == false)
            {
                CreateNewItem();
            }

            // Show Client cotrol
            Control ctl = pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlItem)];
            ctl.BringToFront();
        }

        private void bugToolStripMenuItem1_Click(object sender, EventArgs e) // Bug
        {

        }

        private void timesheetToolStripMenuItem_Click(object sender, EventArgs e) // Timesheet
        {
            // create new Timesheet control if necessary
            if (mctlTime == null || this.pnlControlPanel.Controls.Contains(mctlTime) == false)
            {
                CreateNewTimesheet();
            }

            // Show timesheet
            Control ctl = pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlTime)];
            ctl.BringToFront();

        }

        #region Create Controls
        private void CreateNewClient()
        {
            mctlClient = new ctlClient();
            pnlControlPanel.Controls.Add(mctlClient);
            pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlClient)].Dock = DockStyle.Fill;
            pnlControlPanel.Refresh();
        }

        private void CreateNewItem()
        {
            mctlItem = new ctlItem();
            pnlControlPanel.Controls.Add(mctlItem);
            pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlItem)].Dock = DockStyle.Fill;
            pnlControlPanel.Refresh();
        }

        private void CreateNewTimesheet()
        {
            mctlTime = new ctlTime();
            pnlControlPanel.Controls.Add(mctlTime);
            pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlTime)].Dock = DockStyle.Fill;
            pnlControlPanel.Refresh();
        }

        private void CreateNewDevDoc()
        {
            if (this.pnlControlPanel.Controls.Contains(mctlDevDoc) == false)
            {
                mctlDevDoc = new ctlDevDoc();
                
            }
        }
        #endregion

        private void frmMain_KeyDown(object sender, KeyEventArgs e) // Hot keys
        {
            Control ctlCurrent;

            // e.SuppressKeyPress = true; Stops bing! and sets handled = true which stops event bubbling
            if (e.Control && e.Shift && e.KeyCode == Keys.A)            // Ctrl-Shift-A: something
            {
                e.SuppressKeyPress = true;  
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.C)            // Ctrl-Shift-C: Open/Show Client screen
            {
                e.SuppressKeyPress = true;
                clientToolStripMenuItem1_Click(this, new EventArgs());
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.T)            // Ctrl-Shift-T: Timesheet screen
            {
                e.SuppressKeyPress = true;
                timesheetToolStripMenuItem_Click(this, new EventArgs());
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.D)            // Ctrl-Shift-D: Item Database screen
            {
                e.SuppressKeyPress = true;
                itemToolStripMenuItem1_Click(this, new EventArgs());
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.M)        // Ctrl-Shift-M: Messages
            {
                e.SuppressKeyPress = true;
                //tsddNewMessage_Click(this.tsddNewMessage, new EventArgs());
            }
            else if (e.Control && e.KeyCode == Keys.S)        // Ctrl-S: Save
            {
                e.SuppressKeyPress = true;
            }
            else if (e.Shift && e.KeyCode == Keys.W)        // Ctrl-Shift-W: Close Top Control in Control Panel
            {
                e.SuppressKeyPress = true;  //TODO find why this keypress isnt suppressed
                #region Close Control if one exists
                if (pnlControlPanel.Controls.Count > 0)    
                {
                    ctlCurrent = pnlControlPanel.Controls[0];
                    if (ctlCurrent != null)
                    {
                        pnlControlPanel.Controls.Remove(ctlCurrent);
                        ctlCurrent = null;
                    }
                }
                #endregion
            }

            // remove charcter if focused on a textbox
            //ctlCurrent = FindFocusedControl(pnlControlPanel.Controls[0]);
            //if (ctlCurrent != null && ctlCurrent.GetType().ToString() == "System.Windows.Forms.TextBox")
            //{
                //ctlCurrent.Text = replace(ctlCurrent.Text.substr(ctlCurrent.Text.length() - 1), "");
            //}
        }

        //public static Control FindFocusedControl(Control control)
        //{
        //    var container = control as IContainerControl;
        //    while (container != null)
        //    {
        //        control = container.ActiveControl;
        //        container = control as IContainerControl;
        //    }
        //    return control;
        //}


        private void frmMain_Load(object sender, EventArgs e)
        {
            //init


            //load preferences, security


            //fill data
            RefreshOpenItems();

            // add initial panel
            CreateNewClient();

        }

        //private void tsddNewMessage_Click(object sender, EventArgs e)
        //{
        //    //ToolStripButton tsbtn = new ToolStripButton();
        //    //tsbtn.Text = "Dan";
        //    //ToolStripButton tsbtn1 = new ToolStripButton();
        //    //tsbtn1.Text = "Jonesy";
        //    //ToolStripButton tsbtn2 = new ToolStripButton();
        //    //tsbtn2.Text = "Steve";

        //    //ToolStripDropDown dd = new ToolStripDropDown();
        //    //dd.Items.AddRange(new ToolStripItem[] { tsbtn, tsbtn1, tsbtn2 });
        //    //dd.Items[0].Select();

        //    //tsddNewMessage.DropDown = dd;
        //    //tsddNewMessage.DropDown.DefaultDropDownDirection = ToolStripDropDownDirection.AboveLeft;
        //    //tsddNewMessage.ShowDropDown();


        //}

        private void RefreshOpenItems()
        {
            grdOpenItems.Rows.Clear();

            // timesheet?

            // client issues
            //mdtOpenItems = mobjClientList.
        }

        private void showCurrentMenuItem_Click(object sender, EventArgs e)
        {
            // Show Open Items for this dev cycle and High Importance Client Issues
        }

        private void showAllOpenMenuItem_Click(object sender, EventArgs e)
        {
            // Show all Open Items assigned to the current developer
        }

        private void showAllClientIssuesMenuItem_Click(object sender, EventArgs e)
        {
            // Show all client Issues for the current developer
        }



    }
}
