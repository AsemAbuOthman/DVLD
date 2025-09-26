using DevExpress.Utils;
using DevExpress.XtraEditors;
using DVDL_Busineses;
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

namespace DVDL
{
    public partial class frmEditPersonDetails : DevExpress.XtraEditors.XtraForm
    {
        public frmEditPersonDetails(int PersonID, DataGridViewRow drPersonDetails)
        {
            InitializeComponent();

            WindowsFormsSettings.AllowRoundedWindowCorners = DefaultBoolean.True;

            ctrlPersonDetails.TitleLabel = "Edit Details";

            ctrlPersonDetails.TitleImage = DVDL.Properties.Resources.PersonEditFace;

            this.ctrlPersonDetails.ID += drPersonDetails.Cells["dgvcPersonID"].Value;
            this.ctrlPersonDetails.FirstName = drPersonDetails.Cells["dgvcFirstName"].Value.ToString();
            this.ctrlPersonDetails.SecondName = drPersonDetails.Cells["dgvcSecondName"].Value.ToString();
            this.ctrlPersonDetails.ThirdName = drPersonDetails.Cells["dgvcThirdName"].Value.ToString();
            this.ctrlPersonDetails.LastName = drPersonDetails.Cells["dgvcLastName"].Value.ToString();
            this.ctrlPersonDetails.Nationality = clsBusiness.clsCountry.GetCountryIDByName(drPersonDetails.Cells["dgvcNationality"].Value.ToString());
            this.ctrlPersonDetails.Address = drPersonDetails.Cells["dgvcAddress"].Value.ToString();
            this.ctrlPersonDetails.Email = drPersonDetails.Cells["dgvcEmail"].Value.ToString();
            this.ctrlPersonDetails.Phone = drPersonDetails.Cells["dgvcPhone"].Value.ToString();
            this.ctrlPersonDetails.NationalNo = drPersonDetails.Cells["dgvcNationalNo"].Value.ToString();
            this.ctrlPersonDetails.Gender = Convert.ToByte(drPersonDetails.Cells["dgvcGender"].Value);
            this.ctrlPersonDetails.PersonImagePath = drPersonDetails.Cells["dgvcImagePath"].Value.ToString();
            this.ctrlPersonDetails.DateOfBirth = (DateTime)drPersonDetails.Cells["dgvcDateOfBirth"].Value;
            this.ctrlPersonDetails.IsReadOnly = false;

        }

        public frmEditPersonDetails(int PersonID, DataRow drPersonDetails)
        {
            InitializeComponent();

            ctrlPersonDetails.TitleLabel = "Edit Details";

            ctrlPersonDetails.TitleImage = DVDL.Properties.Resources.PersonEditFace;

            this.ctrlPersonDetails.ID += drPersonDetails["PersonID"];
            this.ctrlPersonDetails.FirstName = drPersonDetails["FirstName"].ToString();
            this.ctrlPersonDetails.SecondName = drPersonDetails["SecondName"].ToString();
            this.ctrlPersonDetails.ThirdName = drPersonDetails["ThirdName"].ToString();
            this.ctrlPersonDetails.LastName = drPersonDetails["LastName"].ToString();
            this.ctrlPersonDetails.Nationality = clsBusiness.clsCountry.GetCountryIDByName(drPersonDetails["Nationality"].ToString());
            this.ctrlPersonDetails.Address = drPersonDetails["Address"].ToString();
            this.ctrlPersonDetails.Email = drPersonDetails["Email"].ToString();
            this.ctrlPersonDetails.Phone = drPersonDetails["Phone"].ToString();
            this.ctrlPersonDetails.NationalNo = drPersonDetails["NationalNo"].ToString();
            this.ctrlPersonDetails.Gender = Convert.ToByte(drPersonDetails["Gendor"]);
            this.ctrlPersonDetails.PersonImagePath = drPersonDetails["ImagePath"].ToString();
            this.ctrlPersonDetails.DateOfBirth = (DateTime)drPersonDetails["DateOfBirth"];
            this.ctrlPersonDetails.IsReadOnly = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string numericValue = Regex.Replace(ctrlPersonDetails.ID, @"[^\d]", "");

            clsBusiness.clsPerson Person = new clsBusiness.clsPerson(Convert.ToInt32(numericValue),
                                                this.ctrlPersonDetails.NationalNo,
                                                this.ctrlPersonDetails.FirstName,
                                                this.ctrlPersonDetails.SecondName,
                                                this.ctrlPersonDetails.ThirdName,
                                                this.ctrlPersonDetails.LastName,
                                                this.ctrlPersonDetails.Gender,
                                                this.ctrlPersonDetails.DateOfBirth,
                                                this.ctrlPersonDetails.Address,
                                                this.ctrlPersonDetails.Nationality,
                                                this.ctrlPersonDetails.Email,
                                                this.ctrlPersonDetails.Phone,
                                                this.ctrlPersonDetails.PersonImagePath);


            if (MessageBox.Show($"Are you sure you want to eidt this Person ? ", "Confirm ? ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Person.Save())
                {
                    MessageBox.Show($"Person With ID : [{Person.PersonID}] Edit Successfully.", "Edit Successfully",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ctrlPersonDetails.IsReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Person was not Edited !", "Editing Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show($"Operation was Canceled", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
