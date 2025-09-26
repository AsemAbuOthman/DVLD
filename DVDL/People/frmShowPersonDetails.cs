using DevExpress.Utils;
using DevExpress.Utils.DirectXPaint;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using DVDL_Busineses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL
{
    public partial class frmShowPersonDetails : Form
    {
        public frmShowPersonDetails(int PersonID, DataGridViewRow drPersonDetails)
        {
            InitializeComponent();

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
            this.ctrlPersonDetails.IsReadOnly = true;

        }

        public frmShowPersonDetails(int PersonID, DataRow drPersonDetails)
        {
            InitializeComponent();

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
            this.ctrlPersonDetails.Gender = Convert.ToByte(drPersonDetails["Gender"]);
            this.ctrlPersonDetails.PersonImagePath = drPersonDetails["ImagePath"].ToString();
            this.ctrlPersonDetails.DateOfBirth = (DateTime)drPersonDetails["DateOfBirth"];
            this.ctrlPersonDetails.IsReadOnly = true;

        }

        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();

            DataRow drPersonDetails = clsBusiness.clsPerson.GetPersonDetailsWithID(PersonID);

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
            this.ctrlPersonDetails.IsReadOnly = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
