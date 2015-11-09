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
            // init comboboxs


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

        private void btnSetStart_Click(object sender, EventArgs e)
        {
            dtpStartTime.Value = DateTime.Now;
            btnSetStart.Text = "In Progress";
            btnSetStart.Enabled = false;

        }

        private void btnSetEnd_Click(object sender, EventArgs e)
        {
            //set end time and calculate minutes
            dtpEndTime.Value = DateTime.Now;
            txtMinutes.Text = dtpEndTime.Value.Subtract(dtpStartTime.Value).Minutes.ToString();

            if (SaveEntry())
            {
                //reset form if save successful
                ResetForm();
            }
        }

        /// <summary>
        /// attempts to save the timesheet entry
        /// </summary>
        /// <returns>true if successful, else false</returns>
        private bool SaveEntry()
        {
            if (ValidateSave())
            {
                //save entry


                return true;
            }

            return false;
        }

        /// <summary>
        /// Reset form for new entry
        /// </summary>
        private void ResetForm()
        {
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;
            rtbIssue.Text = "";
            txtMinutes.Text = "";
            txtSubject.Text = "";
        }

        /// <summary>
        /// Validates form state for saving
        /// </summary>
        /// <returns>True if form is ready to save, else false</returns>
        private bool ValidateSave()
        {
            if (txtSubject.Text == "" || txtMinutes.Text == "" || rtbIssue.Text == "")
            {
                return false;
            }
            else if (cboDeveloper.SelectedValue != Global.DeveloperCode)
            {
                MessageBox.Show("You cannot enter time for someone else.");
                return false;
            }

            return true;
        }
    }
}
