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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace DVDL
{
    public partial class frmShowUserDetails : Form
    {

        DataRow drPersonDetails;
        DataRow drUserDetails;
        public frmShowUserDetails(int UserID)
        {
            InitializeComponent();

            drUserDetails = clsBusiness.clsUsers.GetUserDetailsWithUserID(UserID);
            drPersonDetails = clsBusiness.clsPerson.GetPersonDetailsWithID(frmLogin.clsCurrentUserInfo.PersonID);

            FillCtrlWithUserDetails(drUserDetails, drPersonDetails);

        }


        public frmShowUserDetails(int UserID, int PersonID)
        {
            InitializeComponent();

            drUserDetails = clsBusiness.clsUsers.GetUserDetailsWithUserID(UserID);
            drPersonDetails = clsBusiness.clsPerson.GetPersonDetailsWithID(PersonID);

            FillCtrlWithUserDetails( drUserDetails, drPersonDetails);

        }

        private void FillCtrlWithUserDetails(DataRow drUserDetails, DataRow drPersonDetails)
        {
            this.ctrlPersonDetails.ID = "ID: ";
            this.ctrlUserDetails.UserID = "User ID: ";

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
            this.ctrlUserDetails.UserID += drUserDetails["UserID"];
            this.ctrlUserDetails.Username = drUserDetails["Username"].ToString();
            this.ctrlUserDetails.Status = Convert.ToBoolean(drUserDetails["IsActive"]);
            this.ctrlUserDetails.IsReadOnly = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditPersonInfo_Click(object sender, EventArgs e)
        {   

            frmEditPersonDetails frm1 = new frmEditPersonDetails(Convert.ToInt32(ctrlPersonDetails.ID.Remove(0, 4)), this.drPersonDetails);

            frm1.ShowDialog();

            drUserDetails = clsBusiness.clsUsers.GetUserDetailsWithUserID(Convert.ToInt32(drUserDetails["UserID"]));
            drPersonDetails = clsBusiness.clsPerson.GetPersonDetailsWithID(Convert.ToInt32(drPersonDetails["PersonID"]));

            FillCtrlWithUserDetails(drUserDetails, drPersonDetails);
            this.Refresh();

        }
    }
}
