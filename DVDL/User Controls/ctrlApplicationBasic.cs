using DevExpress.Utils.DirectXPaint;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVDL.User_Controls
{
    public partial class ctrlApplicationBasic : UserControl
    {
        DataRow drApplicationBasic;

        public ctrlApplicationBasic()
        {
            InitializeComponent();

        }

        public ctrlApplicationBasic(int ApplicationID)
        {
            InitializeComponent();

            FillctrlApplicationDetailsWithData(ApplicationID);
        }

        private void FillctrlApplicationDetailsWithData(int ApplicationID) 
        {
            drApplicationBasic = clsBusiness.clsApplication.GetApplicationDetailsWithID(ApplicationID);

            if (drApplicationBasic != null) 
            {
                this.Status = drApplicationBasic["ApplicationStatus"].ToString() == "0" ||
                            drApplicationBasic["ApplicationStatus"].ToString() == "1" ||
                            drApplicationBasic["ApplicationStatus"].ToString() == "2" ? "New" :
                            drApplicationBasic["ApplicationStatus"].ToString() == "3" ? "Completed" 
                            : "Canceled";

                this.Fees = Convert.ToInt32(drApplicationBasic["PaidFees"]);
                this.Type = clsBusiness.clsApplication.GetApplicationTypeDetailsWithID(Convert.ToInt32(drApplicationBasic["ApplicationTypeID"]))["ApplicationTypeTitle"].ToString();
                this.Applicant = clsBusiness.clsPerson.GetFullNameDetailsWithID(Convert.ToInt32(drApplicationBasic["ApplicantPersonID"]))["FullName"].ToString();
                this.Date = (DateTime)drApplicationBasic["ApplicationDate"];
                this.StatusDate = (DateTime)drApplicationBasic["LastStatusDate"];
                this.CreatedBy = clsBusiness.clsUsers.GetUserDetailsWithUserID(Convert.ToInt32(drApplicationBasic["CreatedByUserID"]))["UserName"].ToString();

            }

        }

        public int ID
        {
            get
            {
                return Convert.ToInt32(lblApplicationID.Text.Remove(0, 17));
            }
            set
            {
                lblApplicationID.Text += value;
                FillctrlApplicationDetailsWithData(ID);
            }
        }

        public string Status
        {
            get
            {
                return lblStatus.Text.Remove(0, 9);
            }
            set
            {
                lblStatus.Text += value;
            }
        }

        public int Fees
        {
            get
            {
                return Convert.ToInt32(txtFees.Text.Remove(0, 1));
            }
            set
            {
                txtFees.Text += value;
            }
        }

        public string Type
        {
            get
            {
                return txtType.Text;
            }
            set
            {
                txtType.Text = value;
            }
        }

        public string Applicant
        {
            get
            {
                return txtApplicant.Text;
            }
            set
            {
                txtApplicant.Text = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return dtpDate.Value;
            }
            set
            {
                dtpDate.Value = value;
            }
        }

        public DateTime StatusDate
        {
            get
            {
                return dtpStatusDate.Value;
            }
            set
            {
                dtpStatusDate.Value = value;
            }
        }

        public string CreatedBy
        {
            get
            {
                return txtCreatedBy.Text;
            }
            set
            {
                txtCreatedBy.Text = value;
            }
        }

        private void btnShowPerson_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails(Convert.ToInt32(drApplicationBasic["ApplicantPersonID"]));
        
            frm.ShowDialog();   
        }
    }
}
