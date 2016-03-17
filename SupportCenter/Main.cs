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
        private clsClientIssues mobjClientIssues;
        private clsClientList mobjClientList;

        private ServerClient client;

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
            // open client control with current client
            OpenClient();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e) // Item
        {
            // create new Item control if necessary
            OpenItem();
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

        private void devDocViewMenuItem_Click(object sender, EventArgs e)
        {
            // create new Timesheet control if necessary
            if (mctlDevDoc == null || this.pnlControlPanel.Controls.Contains(mctlDevDoc) == false)
            {
                CreateNewDevDoc();
            }

            // Show timesheet
            Control ctl = pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlDevDoc)];
            ctl.BringToFront();
        }

        #region Create Controls
        private void OpenClient(string pstrClientCode = "")
        {
            // create new Client control if necessary
            if (this.pnlControlPanel.Controls.Contains(mctlClient) == false)
            {
                mctlClient = new ctlClient();
                pnlControlPanel.Controls.Add(mctlClient);
                pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlClient)].Dock = DockStyle.Fill;
                pnlControlPanel.Refresh();
            }
            else
            {
                if (mctlClient.ClientCode != pstrClientCode){   // if the Client Code is different, switch clients
                    mctlClient.SwitchClientTo(pstrClientCode);
                }
            }

            // Show Client cotrol
            Control ctl = pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlClient)];
            ctl.BringToFront();
        }

        private void OpenItem()
        {
            // create new Item control if necessary
            if (this.pnlControlPanel.Controls.Contains(mctlItem) == false)
            {
                mctlItem = new ctlItem();
                pnlControlPanel.Controls.Add(mctlItem);
                pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlItem)].Dock = DockStyle.Fill;
                pnlControlPanel.Refresh();
            }
            else
            {
                //if (mctlItem.ClientCode != pstrClientCode)
                //{   // if the Item is different, switch Items
                //    mctlItem.SwitchClientTo(pstrClientCode);
                //}
            }

            // Show Item cotrol
            Control ctl = pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlItem)];
            ctl.BringToFront();
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
            mctlDevDoc = new ctlDevDoc();
            pnlControlPanel.Controls.Add(mctlDevDoc);
            pnlControlPanel.Controls[pnlControlPanel.Controls.GetChildIndex(mctlDevDoc)].Dock = DockStyle.Fill;
            pnlControlPanel.Refresh();
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
            // Choose Database
            if (ConnectToDB())
            {
                //init
                mobjClientIssues = new clsClientIssues();
                mobjClientList = new clsClientList();

                //load preferences, security


                //fill data
                RefreshOpenItems();

                // add initial panel based on preferences
                //CreateNewClient();
            }
        }

        private static bool ConnectToDB()
        {
            string strConnString = "Data Source=Jma-sql2012dev\\dev12;Initial Catalog=ClaimsSupport;Integrated Security=True;";
            Global.ConnectionString = strConnString;
            Global.Connection = new SqlConnection(strConnString);

            if (Global.Connection == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void RefreshOpenItems()
        {
            grdOpenItems.Rows.Clear();

            // timesheet?

            // client issues
            mdtOpenItems = mobjClientIssues.GetOpenItemsForDeveloper("ES"); //mobjDeveloper.DeveloperCode
            grdOpenItems.DataSource = mdtOpenItems;
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

        private void grdOpenItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdOpenItems_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = grdOpenItems.Rows[e.RowIndex];
            string strCurrentClientCode = selectedRow.Cells["ClientCode"].Value.ToString();

            // set current client
            mobjClientList.SetCurrentClient(strCurrentClientCode);

            // set client property of client control
            OpenClient(strCurrentClientCode);
        }

        private void lblCurrentClient_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectChat_Click(object sender, EventArgs e)
        {

            if (client == null)
            {
                client = new ServerClient();
            }

            client.Connect();

            lblChatConnection.Text = "C";

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string answer = client.getPayloadAnswer("jones");
            MessageBox.Show(answer);
        }

        //  System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        //NetworkStream serverStream = default(NetworkStream);
        //string readData = null;
        //public Form1()        //{
        //    InitializeComponent();
        //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
        //    serverStream.Write(outStream, 0, outStream.Length);
        //    serverStream.Flush();
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    readData = "Conected to Chat Server ...";
        //    msg();
        //    clientSocket.Connect("127.0.0.1", 8888);
        //    serverStream = clientSocket.GetStream();
        //    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox3.Text + "$");
        //    serverStream.Write(outStream, 0, outStream.Length);
        //    serverStream.Flush();
        //    Thread ctThread = new Thread(getMessage);
        //    ctThread.Start();
        //}
        //private void getMessage()
        //{
        //    while (true)
        //    {
        //        serverStream = clientSocket.GetStream();
        //        int buffSize = 0;
        //        byte[] inStream = new byte[10025];
        //        buffSize = clientSocket.ReceiveBufferSize;
        //        serverStream.Read(inStream, 0, buffSize);
        //        string returndata = System.Text.Encoding.ASCII.GetString(inStream);
        //        readData = "" + returndata;
        //        msg();
        //    }
        //}

        //private void msg()
        //{
        //    if (this.InvokeRequired)
        //        this.Invoke(new MethodInvoker(msg));
        //    else
        //        textBox1.Text = textBox1.Text + Environment.NewLine + " >> " + readData;
        //} 

    }
}
