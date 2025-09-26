using DevExpress.Utils.DirectXPaint;
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
using DVDL_Busineses;
using DevExpress.DataAccess.Sql;
using System.Net;
using System.Net.Mail;
using System.IO;
using DVDL.Users;
using System.Text.RegularExpressions;
using DVDL.Applications;


namespace DVDL
{
    public partial class frmShowApplication : Form
    {
        public frmShowApplication()
        {
            InitializeComponent();
        }

        DataTable dtLocalApplications;


        public DateTime DateOfBirth
        {
            get
            {

                return (DateTime)dgvShowLocalApplications.CurrentRow.Cells["dgvcDateOfBirth"].Value;
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FilldgvShowApplication(DataTable dtPeople)
        {
            if (this.dtLocalApplications != null)
            {
                dgvShowLocalApplications.Rows.Clear();

                foreach (DataRow row in this.dtLocalApplications.Rows)
                {
                    dgvShowLocalApplications.Rows.Add(row["LocalDrivingLicenseApplicationID"],
                        row["NationalNo"],
                        row["ClassName"],
                        row["FullName"],
                        row["ApplicationDate"],
                        row["PassedTestCount"],
                        row["Status"]);
                }

                lblRecords.Text = lblRecords.Text.Substring(0, 12) + dgvShowLocalApplications.RowCount.ToString();
            }
        }

        private void frmShowPersons_Load(object sender, EventArgs e)
        {
            RefreshUsersData();

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddPersonDetails frm = new frmAddPersonDetails();

            frm.ShowDialog();
        }
        private void RefreshUsersData()
        {
            dtLocalApplications = clsBusiness.clsApplication.GetAllLocalDrivingLicenseApplicationDetails();

            FilldgvShowApplication(dtLocalApplications);
        }

        private void tsmEditPerson_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcUserID"].Value), Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcPersonID"].Value));
            frm.ShowDialog();

            RefreshUsersData();
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            frmAddApplication frm = new frmAddApplication();

            frm.ShowDialog();

            RefreshUsersData();

        }

        private void cmbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterBy.Clear();
            cmbStatus.Visible = false;

            if (cmbFilterBy.SelectedIndex == 0)
            {
                txtFilterBy.Visible = false;
                cmbFilterBy.Tag = "";
                txtFilterBy.Text = "";

                cmbStatus.SelectedIndex = 0;
            }
            else if (cmbFilterBy.SelectedIndex == 1)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "ApplicationID";
                txtFilterBy.MaxLength = 10;
            }
            else if (cmbFilterBy.SelectedIndex == 2)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "NationalNo.";
                txtFilterBy.MaxLength = 10;

            }
            else if (cmbFilterBy.SelectedIndex == 3)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "FullName";
                txtFilterBy.MaxLength = 50;

            }
            else if (cmbFilterBy.SelectedIndex == 4)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "Status";
                txtFilterBy.Visible = false;
                cmbStatus.Visible = true;
            }

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilterBy.Text.ToString()))
            {
                DataRow drUser = null;
                string Pattern;

                if (dtLocalApplications != null)
                {
                    dtLocalApplications.Rows.Clear();

                }

                switch (cmbFilterBy.Tag.ToString())
                {
                    case "ApplicationID":

                        Pattern = @"^\d+$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            dtLocalApplications = clsBusiness.clsApplication.GetAllLocalApplicationsDetailsWithApplicationID(Convert.ToInt32(txtFilterBy.Text.ToString()));
                        }

                        break;

                    case "NationalNo.":

                        Pattern = @"^\d+$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            dtLocalApplications = clsBusiness.clsApplication.GetAllLocalApplicationsDetailsWithNationalNo(Convert.ToInt32(txtFilterBy.Text.Trim()));
                        }

                        break;

                    case "FullName":

                        Pattern = @"^[A-Za-z]+(?:[-' ]?[A-Za-z]+)*$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            dtLocalApplications = clsBusiness.clsApplication.GetAllLocalApplicationsDetailsWithFullName(txtFilterBy.Text.Trim());
                        }

                        break;

                    case "Status":
                        dtLocalApplications = clsBusiness.clsUsers.GetAllUsersDetailsWithStatus(Convert.ToBoolean(txtFilterBy.Text.Trim()));

                        break;

                    default:

                        dtLocalApplications = null;

                        break;
                }
            }
            else if (string.IsNullOrEmpty(txtFilterBy.Text.ToString()))
            {
                dtLocalApplications = clsBusiness.clsApplication.GetAllLocalDrivingLicenseApplicationDetails();
            }

            if (dtLocalApplications != null)
            {
                FilldgvShowApplication(dtLocalApplications);
            }
            else
            {
                dgvShowLocalApplications.Rows.Clear();
            }
        }
        private void tsmSendEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.SelectedIndex == 1)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;  // Prevent the character from being entered
                }
            }
            else if (cmbFilterBy.SelectedIndex == 2)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;  // Prevent the character from being entered
                }
            }
            else if (cmbFilterBy.SelectedIndex == 3)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex == 0)
            {
                dtLocalApplications = clsBusiness.clsApplication.GetAllLocalDrivingLicenseApplicationDetails();

            }
            else if (cmbStatus.SelectedIndex == 1)
            {

                dtLocalApplications = clsBusiness.clsApplication.GetAllLocalApplicationsDetailsWithStatus(cmbStatus.SelectedItem.ToString());

            }
            else if (cmbStatus.SelectedIndex == 2)
            {
                dtLocalApplications = clsBusiness.clsApplication.GetAllLocalApplicationsDetailsWithStatus(cmbStatus.SelectedItem.ToString());
            }
            else if (cmbStatus.SelectedIndex == 3)
            {
                dtLocalApplications = clsBusiness.clsApplication.GetAllLocalApplicationsDetailsWithStatus(cmbStatus.SelectedItem.ToString());
            }

            if (dtLocalApplications != null)
            {
                FilldgvShowApplication(dtLocalApplications);
            }
            else
            {
                dgvShowLocalApplications.Rows.Clear();
            }
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcUserID"].Value), Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcPersonID"].Value));
            frm.ShowDialog();
        }

        private void tsmiAddNewUser_Click(object sender, EventArgs e)
        {

            this.btnAddUser.PerformClick();
        }



        private void tsmiVisionTest_Click(object sender, EventArgs e)
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails(Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcLDLapplicationID"].Value), tsmiVisionTest.Text.Trim(), dgvShowLocalApplications.CurrentRow.Cells["dgvcDrivingClass"].Value.ToString());
            frm.ShowDialog();

            RefreshUsersData();

        }

        private void tsmiWrittenTest_Click(object sender, EventArgs e)
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails(Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcLDLapplicationID"].Value), tsmiWrittenTest.Text.Trim(), dgvShowLocalApplications.CurrentRow.Cells["dgvcDrivingClass"].Value.ToString());

            frm.ShowDialog();

            RefreshUsersData();

        }

        private void tsmiPracticalTest_Click(object sender, EventArgs e)
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails(Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcLDLapplicationID"].Value), tsmiPracticalTest.Text.Trim(), dgvShowLocalApplications.CurrentRow.Cells["dgvcDrivingClass"].Value.ToString());
            frm.ShowDialog();

            RefreshUsersData();

        }

        private void cmsSchaduleTests_Opening(object sender, CancelEventArgs e)
        {
            if (dgvShowLocalApplications.CurrentRow.Cells["dgvcPassedTests"].Value.ToString() == "0")
            {
                cmsSchaduleTests.Items["tsmiVisionTest"].Enabled = true;
                cmsSchaduleTests.Items["tsmiWrittenTest"].Enabled = false;
                cmsSchaduleTests.Items["tsmiPracticalTest"].Enabled = false;
            }
            else if (dgvShowLocalApplications.CurrentRow.Cells["dgvcPassedTests"].Value.ToString() == "1")
            {
                cmsSchaduleTests.Items["tsmiVisionTest"].Enabled = false;
                cmsSchaduleTests.Items["tsmiWrittenTest"].Enabled = true;
                cmsSchaduleTests.Items["tsmiPracticalTest"].Enabled = false;
            }
            else if (dgvShowLocalApplications.CurrentRow.Cells["dgvcPassedTests"].Value.ToString() == "2")
            {
                cmsSchaduleTests.Items["tsmiVisionTest"].Enabled = false;
                cmsSchaduleTests.Items["tsmiWrittenTest"].Enabled = false;
                cmsSchaduleTests.Items["tsmiPracticalTest"].Enabled = true;
            }
            else if (dgvShowLocalApplications.CurrentRow.Cells["dgvcPassedTests"].Value.ToString() == "3")
            {
                cmsSchaduleTests.Items["tsmiVisionTest"].Enabled = false;
                cmsSchaduleTests.Items["tsmiWrittenTest"].Enabled = false;
                cmsSchaduleTests.Items["tsmiPracticalTest"].Enabled = false;
            }
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells[0].Value);
        }

        private void tsmiDeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this Application ? ", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int LocalApplicationID = Convert.ToInt32(dgvShowLocalApplications.CurrentRow.Cells["dgvcLDLapplicationID"].Value);

                if (clsBusiness.clsTest.DeleteApplication(LocalApplicationID))
                {
                    MessageBox.Show($"Application with LocalApplicationID : {LocalApplicationID} Deleted Successfully !", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshUsersData();
                }
                else
                {
                    MessageBox.Show("Application was not Deleted !", "Deletion Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operation was Canceled !", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmsLocalApplications_Opening(object sender, CancelEventArgs e)
        {
            if (dgvShowLocalApplications.CurrentRow.Cells["dgvcStatus"].Value.ToString() == "Completed")
            {
                cmsLocalApplications.Items["tsmiDeleteApplication"].Enabled = false;
            }
            else 
            {
                cmsLocalApplications.Items["tsmiDeleteApplication"].Enabled = true;

            }

            if (dgvShowLocalApplications.CurrentRow.Cells["dgvcPassedTests"].Value.ToString() == "3")
            {
                cmsLocalApplications.Items["tsmiSchaduleTests"].Enabled = false;

                if (dgvShowLocalApplications.CurrentRow.Cells["dgvcStatus"].Value.ToString() == "New")
                {
                    cmsLocalApplications.Items["tsmiShowDetails"].Enabled = true;
                    cmsLocalApplications.Items["tsmiEditApplication"].Enabled = true;
                    cmsLocalApplications.Items["tsmiDeleteApplication"].Enabled = true;
                    cmsLocalApplications.Items["tsmiCancelApplication"].Enabled = true;
                    cmsLocalApplications.Items["tsmiIssueDrivingLicense"].Enabled = true;
                    cmsLocalApplications.Items["tsmiShowLicense"].Enabled = false;
                    cmsLocalApplications.Items["tsmiShowPersonLicenseHistory"].Enabled = false;
                }
                else if (dgvShowLocalApplications.CurrentRow.Cells["dgvcStatus"].Value.ToString() == "Completed")
                {
                    cmsLocalApplications.Items["tsmiShowDetails"].Enabled = true;
                    cmsLocalApplications.Items["tsmiEditApplication"].Enabled = false;
                    cmsLocalApplications.Items["tsmiDeleteApplication"].Enabled = false;
                    cmsLocalApplications.Items["tsmiCancelApplication"].Enabled = false;
                    cmsLocalApplications.Items["tsmiIssueDrivingLicense"].Enabled = false;
                    cmsLocalApplications.Items["tsmiShowLicense"].Enabled = true;
                    cmsLocalApplications.Items["tsmiShowPersonLicenseHistory"].Enabled = true;

                }
                else
                {
                    cmsLocalApplications.Items["tsmiShowDetails"].Enabled = true;
                    cmsLocalApplications.Items["tsmiEditApplication"].Enabled = true;
                    cmsLocalApplications.Items["tsmiDeleteApplication"].Enabled = true;
                    cmsLocalApplications.Items["tsmiCancelApplication"].Enabled = true;
                    cmsLocalApplications.Items["tsmiIssueDrivingLicense"].Enabled = false;
                    cmsLocalApplications.Items["tsmiShowLicense"].Enabled = false;
                    cmsLocalApplications.Items["tsmiShowPersonLicenseHistory"].Enabled = false;
                }

            }
            else
            {
                cmsLocalApplications.Items["tsmiShowDetails"].Enabled = true;
                cmsLocalApplications.Items["tsmiEditApplication"].Enabled = true;
                cmsLocalApplications.Items["tsmiDeleteApplication"].Enabled = true;
                cmsLocalApplications.Items["tsmiCancelApplication"].Enabled = true;
                cmsLocalApplications.Items["tsmiSchaduleTests"].Enabled = true;
                cmsLocalApplications.Items["tsmiIssueDrivingLicense"].Enabled = false;
                cmsLocalApplications.Items["tsmiShowLicense"].Enabled = false;
                cmsLocalApplications.Items["tsmiShowPersonLicenseHistory"].Enabled = false;
            }

            dgvShowLocalApplications.CurrentRow.Cells["dgvcNationalNo"].Value.ToString();
        }

        private void tsmiShowDetails_Click_1(object sender, EventArgs e)
        {

        }
    }
}
