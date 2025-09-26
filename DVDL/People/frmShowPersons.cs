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


namespace DVDL
{
    public partial class frmShowPersons : Form
    {
        public frmShowPersons()
        {
            InitializeComponent();
        }

        DataTable dtPeople;

        public string PersonID
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcPersonID"].Value.ToString();
            }
        }

        public string FirstName
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcFirstName"].Value.ToString();
            }
        }

        public string SecondName
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcSecondName"].Value.ToString();
            }
        }

        public string ThirdName
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcThirdName"].Value.ToString();

            }        
        }

        public string LastName
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcLastName"].Value.ToString();

            }
        }

        public string Address
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcAddress"].Value.ToString();

            }

        }

        public string Email
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcEmail"].Value.ToString();

            }

        }

        public string Phone
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcPhone"].Value.ToString();

            }

        }

        public string NationalNo
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcNationalNo"].Value.ToString();

            }

        }

        public string Nationality
        {
            get
            {
                return dgvShowPerson.CurrentRow.Cells["dgvcNationality"].Value.ToString();

            }

        }

        public string Gender
        {
            get
            {

                return dgvShowPerson.CurrentRow.Cells["dgvcGender"].Value.ToString();

            }

        }


        public string PersonImagePath 
        {
            get
            {

                return dgvShowPerson.CurrentRow.Cells["dgvcImagePath"].Value.ToString();
            }

        }

        public DateTime DateOfBirth
        {
            get
            {

                return (DateTime)dgvShowPerson.CurrentRow.Cells["dgvcDateOfBirth"].Value;
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
            if (this.dtPeople != null)
            {
                dgvShowPerson.Rows.Clear();

                foreach (DataRow row in this.dtPeople.Rows)
                {
                    dgvShowPerson.Rows.Add(row["PersonID"], row["NationalNo"], row["FirstName"],
                            row["SecondName"], row["ThirdName"], row["LastName"], row["Gendor"],
                            row["DateOfBirth"], row["Address"], row["Phone"], row["Email"],
                            row["Nationality"], row["ImagePath"]);
                }

                lblRecords.Text = lblRecords.Text.Substring(0, 12) + dgvShowPerson.RowCount.ToString();
            }
        }

        private void frmShowPersons_Load(object sender, EventArgs e)
        {
            dtPeople = clsBusiness.clsPerson.GetAllPersonsDetails();

            FilldgvShowPerson(dtPeople);

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddPersonDetails frm = new frmAddPersonDetails();

            frm.ShowDialog();
        }


        private void tsmShowPerson_Click(object sender, EventArgs e)
        {

            frmShowPersonDetails frm = new frmShowPersonDetails(Convert.ToInt32(this.PersonID), dgvShowPerson.SelectedRows[0]);


            frm.ShowDialog();
        }

        private void tsmDeletePerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this person ? ", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(dgvShowPerson.CurrentRow.Cells["dgvcPersonID"].Value);

                if (clsBusiness.clsPerson.DeletePerson(ID))
                {
                    MessageBox.Show($"Person with ID : {ID} Deleted Successfully !", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtPeople = clsBusiness.clsPerson.GetAllPersonsDetails();

                    FilldgvShowPerson(dtPeople);
                }
                else
                {
                    MessageBox.Show("Person was not Deleted !", "Deletion Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Operation was Canceled !", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmEditPerson_Click(object sender, EventArgs e)
        {
            frmEditPersonDetails frm = new frmEditPersonDetails(Convert.ToInt32(this.PersonID), dgvShowPerson.SelectedRows[0]);

            frm.ShowDialog();

            dtPeople = clsBusiness.clsPerson.GetAllPersonsDetails();

            FilldgvShowPerson(dtPeople);
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            frmAddPersonDetails frm = new frmAddPersonDetails();


            frm.ShowDialog();

            dtPeople = clsBusiness.clsPerson.GetAllPersonsDetails();

            FilldgvShowPerson(dtPeople);
        }

        private void tsmAddPerson_Click(object sender, EventArgs e)
        {
            frmAddPersonDetails frm = new frmAddPersonDetails();

            frm.ShowDialog();

            dtPeople = clsBusiness.clsPerson.GetAllPersonsDetails();

            FilldgvShowPerson(dtPeople);
        }

        private void cmbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterBy.Clear();

            if (cmbFilterBy.SelectedIndex == 0)
            {
                txtFilterBy.Visible = false;
                cmbFilterBy.Tag = "";
                txtFilterBy.Text = "";

            }
            else if (cmbFilterBy.SelectedIndex == 1) 
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "PersonID";
            }
            else if (cmbFilterBy.SelectedIndex == 2)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "NatinoalNo";

            }
            else if (cmbFilterBy.SelectedIndex == 3)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "FirstName";

            }
            else if (cmbFilterBy.SelectedIndex == 4)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "SecondName";

            }
            else if (cmbFilterBy.SelectedIndex == 5)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "ThirdName";

            }
            else if (cmbFilterBy.SelectedIndex == 6)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "LastName";

            }
            else if (cmbFilterBy.SelectedIndex == 7)
            {


                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "Gendor";

            }
            else if (cmbFilterBy.SelectedIndex == 8)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "DateOfBirth";

            }
            else if (cmbFilterBy.SelectedIndex == 9)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "Nationality";

            }
            else if (cmbFilterBy.SelectedIndex == 10)
            {
                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "Phone";

            }
            else if (cmbFilterBy.SelectedIndex == 11)
            {

                txtFilterBy.Visible = true;
                txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
                cmbFilterBy.Tag = "Email";

            }
            //else if (cmbFilterBy.SelectedIndex == 11)
            //{
            //    txtFilterBy.Visible = true;
            //    txtFilterBy.PlaceholderText = cmbFilterBy.SelectedItem.ToString();
            //}
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilterBy.Text.ToString())) 
            {


                switch (cmbFilterBy.Tag.ToString())
                {

                    case "PersonID":
                            dtPeople = clsBusiness.clsPerson.GetAllPersonWithID(Convert.ToInt32(txtFilterBy.Text.ToString()));
                        break;

                    case "NatinoalNo":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithNationalNo(Convert.ToInt32(txtFilterBy.Text.Trim()));

                        break;

                    case "FirstName":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithFirstName(txtFilterBy.Text.Trim());

                        break;

                    case "SecondName":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithSecondName(txtFilterBy.Text.Trim());

                        break;

                    case "ThirdName":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithThirdName(txtFilterBy.Text.Trim());

                        break;

                    case "LastName":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithLastName(txtFilterBy.Text.Trim());

                        break;

                    case "Gendor":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithGender(Convert.ToByte(txtFilterBy.Text.Trim()));

                        break;

                    case "DateOfBirth":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithDateOfBirth(Convert.ToDateTime(txtFilterBy.Text.Trim()));

                        break;

                    case "Nationality":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithNationality(txtFilterBy.Text.Trim());

                        break;

                    case "Phone":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithPhone(txtFilterBy.Text.Trim());

                        break;

                    case "Email":
                        dtPeople = clsBusiness.clsPerson.GetAllPersonWithEmail(txtFilterBy.Text.Trim());

                        break;

                    default:
                        dtPeople = clsBusiness.clsPerson.GetAllPersonsDetails();

                        break;
                }

            }
            else
            {
                dtPeople = clsBusiness.clsPerson.GetAllPersonsDetails();
            }

            FilldgvShowPerson(dtPeople);

        }

        private void tsmSendEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
