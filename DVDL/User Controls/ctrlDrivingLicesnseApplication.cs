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

namespace DVDL.User_Controls
{
    public partial class ctrlDrivingLicesnseApplication : UserControl
    {
        public ctrlDrivingLicesnseApplication()
        {
            InitializeComponent();
        }

        DataRow drLDApplicationBasic;

        public int ID
        {
            get
            {
                return Convert.ToInt32(lblDLApplicationID.Text.Remove(0, 23));
            }
            set
            {
                lblDLApplicationID.Text += value;
                FillctrlDrivingLicenseApplicationDetailsWithData(ID);
            }
        }

        public string LicenseClass
        {
            get
            {
                return txtAppliedForLicense.Text;
            }
            set
            {
                txtAppliedForLicense.Text = value;
            }
        }

        public int TestsPassed
        {
            get
            {
                return Convert.ToInt32(lblTestsPassed.Text.Remove(0, 15).Substring(0,1));
            }
            set
            {
                lblTestsPassed.Text += value + "/3";

            }
        }

        private void FillctrlDrivingLicenseApplicationDetailsWithData(int LDApplicationID)
        {
            drLDApplicationBasic = clsBusiness.clsApplication.GetLocalApplicationViewDetailsWithID(LDApplicationID);

            if (drLDApplicationBasic != null)
            {
                this.LicenseClass = drLDApplicationBasic["ClassName"].ToString();
                MessageBox.Show(drLDApplicationBasic["PassedTestCount"].ToString());
                this.TestsPassed = Convert.ToInt32(drLDApplicationBasic["PassedTestCount"].ToString());
            }

        }

    }
}
