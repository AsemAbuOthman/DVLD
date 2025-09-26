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


namespace DVDL
{
    public partial class frmShowUsers : Form
    {
        public frmShowUsers()
        {
            InitializeComponent();
        }

        DataTable dtUsers;


        public DateTime DateOfBirth
        {
            get
            {

                return (DateTime)dgvShowUser.CurrentRow.Cells["dgvcDateOfBirth"].Value;
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FilldgvShowPerson(DataTable dtPeople)
        {
            if (this.dtUsers != null)
            {
                dgvShowUser.Rows.Clear();

                foreach (DataRow row in this.dtUsers.Rows)
                {
                    dgvShowUser.Rows.Add(row["UserID"],
                        row["PersonID"],
                        row["FullName"],
                        row["Username"],
                        row["Password"],
                        Convert.ToBoolean(row["IsActive"]) == true ? "Yes" : "No");
                }

                lblRecords.Text = lblRecords.Text.Substring(0, 12) + dgvShowUser.RowCount.ToString();
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
            dtUsers = clsBusiness.clsUsers.GetAllUsersDetails();

            FilldgvShowPerson(dtUsers);
        }

        private void tsmEditPerson_Click(object sender, EventArgs e)
        {

            frmShowUserDetails frm = new frmShowUserDetails(Convert.ToInt32(dgvShowUser.CurrentRow.Cells["dgvcUserID"].Value), Convert.ToInt32(dgvShowUser.CurrentRow.Cells["dgvcPersonID"].Value));
            frm.ShowDialog();

            RefreshUsersData();
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();

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
                cmbFilterBy.Tag = "UserID";
                txtFilterBy.MaxLength = 10;
            }
            else if (cmbFilterBy.SelectedIndex == 2)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "PersonID";
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
                cmbFilterBy.Tag = "Username";
                txtFilterBy.MaxLength = 20;

            }
            else if (cmbFilterBy.SelectedIndex == 5)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "IsActive";
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

                if (dtUsers != null)
                {
                    dtUsers.Rows.Clear();

                }

                switch (cmbFilterBy.Tag.ToString())
                {
                    case "UserID":

                        Pattern = @"^\d+$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            drUser = clsBusiness.clsUsers.GetUserDetailsWithUserID(Convert.ToInt32(txtFilterBy.Text.ToString()));
                            dtUsers.ImportRow(drUser);
                        }

                        break;

                    case "PersonID":

                        Pattern = @"^\d+$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            drUser = clsBusiness.clsUsers.GetUserDetailsWithPersonID(Convert.ToInt32(txtFilterBy.Text.Trim()));
                            dtUsers.ImportRow(drUser);
                        }

                        break;

                    case "FullName":

                        Pattern = @"^[A-Za-z]+(?:[-' ]?[A-Za-z]+)*$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            dtUsers = clsBusiness.clsUsers.GetAllUsersDetailsWithFullName(txtFilterBy.Text.Trim());
                        }

                        break;

                    case "Username":

                        Pattern = @"^[a-zA-Z][a-zA-Z0-9_]{0,19}$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            dtUsers = clsBusiness.clsUsers.GetUsersDetailsWithUsername(txtFilterBy.Text.Trim());
                        }

                        break;

                    case "IsActive":
                        dtUsers = clsBusiness.clsUsers.GetAllUsersDetailsWithStatus(Convert.ToBoolean(txtFilterBy.Text.Trim()));

                        break;

                    default:

                        dtUsers = null;

                        break;
                }
            }
            else if (string.IsNullOrEmpty(txtFilterBy.Text.ToString()))
            {
                dtUsers = clsBusiness.clsUsers.GetAllUsersDetails();
            }

            if (dtUsers != null)
            {
                FilldgvShowPerson(dtUsers);
            }
            else
            {
                dgvShowUser.Rows.Clear();
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
                dtUsers = clsBusiness.clsUsers.GetAllUsersDetails();

            }
            else if (cmbStatus.SelectedIndex == 1)
            {
                dtUsers = clsBusiness.clsUsers.GetAllUsersDetailsWithStatus(true);

            }
            else if (cmbStatus.SelectedIndex == 2)
            {
                dtUsers = clsBusiness.clsUsers.GetAllUsersDetailsWithStatus(false);
            }

            if (dtUsers != null)
            {
                FilldgvShowPerson(dtUsers);
            }
            else
            {
                dgvShowUser.Rows.Clear();
            }
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(Convert.ToInt32(dgvShowUser.CurrentRow.Cells["dgvcUserID"].Value), Convert.ToInt32(dgvShowUser.CurrentRow.Cells["dgvcPersonID"].Value));
            frm.ShowDialog();
        }

        private void tsmiAddNewUser_Click(object sender, EventArgs e)
        {

            this.btnAddUser.PerformClick();
        }

        private void tsmiDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this User ? ", "Confirm",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(dgvShowUser.CurrentRow.Cells["dgvcUserID"].Value);

                if (clsBusiness.clsUsers.DeleteUser(ID))
                {
                    MessageBox.Show($"User with ID : {ID} Deleted Successfully !", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshUsersData();
                }
                else
                {
                    MessageBox.Show("User was not Deleted !", "Deletion Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operation was Canceled !", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {

            frmChangePassword frm = new frmChangePassword(Convert.ToInt32(dgvShowUser.CurrentRow.Cells["dgvcUserID"].Value), dgvShowUser.CurrentRow.Cells["dgvcPassword"].Value.ToString());
            frm.ShowDialog();
        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }

        private void cmsUsers_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvShowUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {

        }

        private void pbUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
