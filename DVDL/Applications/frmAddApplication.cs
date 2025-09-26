using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DVDL.User_Controls;
using DVDL_Busineses;
using static DevExpress.Utils.MVVM.Internal.ILReader;

namespace DVDL.Users
{
    public partial class frmAddApplication : Form
    {
        public frmAddApplication()
        {
            InitializeComponent();

            ctrlAddPerson.IsReadOnly = true;
            tabApplicatoinDetails.PageEnabled = false;
        }

        DataRow drPerson;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillShowPerson(DataRow drPerson)
        {
            ctrlAddPerson.ID = "ID: ";
            ctrlAddPerson.FirstName = string.Empty;
            ctrlAddPerson.SecondName = string.Empty;
            ctrlAddPerson.ThirdName = string.Empty;
            ctrlAddPerson.LastName = string.Empty;
            ctrlAddPerson.Nationality = 0;
            ctrlAddPerson.Address = string.Empty;
            ctrlAddPerson.Email = string.Empty;
            ctrlAddPerson.Phone = string.Empty;
            ctrlAddPerson.NationalNo = string.Empty;
            ctrlAddPerson.Gender = Convert.ToByte(2);
            ctrlAddPerson.PersonImagePath = string.Empty;
            ctrlAddPerson.IsReadOnly = true;

            if (drPerson != null)
            {
                ctrlAddPerson.ID += drPerson["PersonID"];
                ctrlAddPerson.FirstName = drPerson["FirstName"].ToString();
                ctrlAddPerson.SecondName = drPerson["SecondName"].ToString();
                ctrlAddPerson.ThirdName = drPerson["ThirdName"].ToString();
                ctrlAddPerson.LastName = drPerson["LastName"].ToString();
                ctrlAddPerson.Nationality = clsBusiness.clsCountry.GetCountryIDByName(drPerson["Nationality"].ToString());
                ctrlAddPerson.Address = drPerson["Address"].ToString();
                ctrlAddPerson.Email = drPerson["Email"].ToString();
                ctrlAddPerson.Phone = drPerson["Phone"].ToString();
                ctrlAddPerson.NationalNo = drPerson["NationalNo"].ToString();
                ctrlAddPerson.Gender = Convert.ToByte(drPerson["Gendor"]);
                ctrlAddPerson.PersonImagePath = drPerson["ImagePath"].ToString();
                ctrlAddPerson.DateOfBirth = (DateTime)drPerson["DateOfBirth"];
                ctrlAddPerson.IsReadOnly = true;

            }
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Clear();

            if (cmbFilterBy.SelectedIndex == 0)
            {
                txtFilterBy.Visible = false;
                cmbFilterBy.Tag = "FilterBy";
                txtFilterBy.Text = "";
            }
            else if (cmbFilterBy.SelectedIndex == 1)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "PersonID";
                txtFilterBy.MaxLength = 10;

            }
            else if (cmbFilterBy.SelectedIndex == 2)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "Phone";
                txtFilterBy.MaxLength = 10;

            }
            else if (cmbFilterBy.SelectedIndex == 3)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "Email";
                txtFilterBy.MaxLength = 50;
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilterBy.Text.ToString()))
            {
                string Pattern;

                switch (cmbFilterBy.Tag.ToString())
                {
                    case "PersonID":

                        Pattern = @"^\d+$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            drPerson = clsBusiness.clsPerson.GetPersonDetailsWithID(Convert.ToInt32(txtFilterBy.Text.ToString()));
                            drPerson = drPerson != null ? drPerson : null;
                        }

                        break;

                    case "Phone":

                        Pattern = @"^\d+$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            drPerson = clsBusiness.clsPerson.GetPersonDetailsWithPhone(txtFilterBy.Text.Trim());
                            drPerson = drPerson != null ? drPerson : null;
                        }

                        break;

                    case "Email":

                        Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                        if (Regex.IsMatch(txtFilterBy.Text.Trim(), Pattern))
                        {
                            drPerson = clsBusiness.clsPerson.GetPersonDetailsWithEmail(txtFilterBy.Text.Trim());
                            drPerson = drPerson != null ? drPerson : null;
                        }

                        break;

                    default:
                        drPerson = null;

                        break;
                }

                if (drPerson != null)
                {
                    tabApplicatoinDetails.PageEnabled = true;
                }
                else
                {
                    tabApplicatoinDetails.PageEnabled = false;
                }
            }
            else
            {
                drPerson = null;
                tabApplicatoinDetails.PageEnabled = false;
            }

            FillShowPerson(drPerson);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPersonDetails frm = new frmAddPersonDetails();

            cmbFilterBy.SelectedIndex = 1;

            frm.PersonAdded += frmAddPersonDetails_PersonAdded;

            frm.ShowDialog();
        }

        private void frmAddPersonDetails_PersonAdded(int personId)
        {
            txtFilterBy.Text = personId.ToString();
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
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            int LocalApplicationID;

            int PersonID = Convert.ToInt32(ctrlAddPerson.ID.Remove(0, 4));

            if (PersonID != -1)
            {
                if (MessageBox.Show($"Are you sure you want to add this Application to this Person ? ", "Confirm ? ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (clsBusiness.clsApplication.CheckIfApplicationWithThisPersonIsExist(Convert.ToInt32(ctrlAddPerson.ID.Remove(0, 4)), this.ctrlAddNewApplication.Classes))
                    {
                        MessageBox.Show("Application With this Person is already Exist !", "Invalid Application",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((LocalApplicationID = (clsBusiness.clsApplication.AddNewLocalApplication(Convert.ToInt32(ctrlAddPerson.ID.Remove(0, 4)), 1, 15, frmLogin.clsCurrentUserInfo.UserID, this.ctrlAddNewApplication.Classes))) != -1)
                    {
                        MessageBox.Show($"Application With ID : [{LocalApplicationID}] Added Successfully.", "Added Successfully",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Application was not Added !", "Addition Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Operation was Canceled", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Application With this Person ID is already Exist !", "Invalid Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
