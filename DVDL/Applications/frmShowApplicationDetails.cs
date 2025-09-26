using DevExpress.Map.OpenGL;
using DVDL.Tests;
using DVDL.User_Controls;
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

namespace DVDL.Applications
{
    public partial class frmShowApplicationDetails : Form
    {
        public frmShowApplicationDetails()
        {
            InitializeComponent();
        }

        public frmShowApplicationDetails(int LocalDrivingLicenseApplication, string TestTypeTitle, string ClassName)
        {
            InitializeComponent();

            DataTable dtAppointments = null;

            ctrlDrivingLicesnseApplication1.ID = LocalDrivingLicenseApplication;
            ctrlApplicationBasic1.ID = Convert.ToInt32(clsBusiness.clsApplication.GetLocalApplicationDetailsWithID(LocalDrivingLicenseApplication)["ApplicationID"]);
            ctrlAppointment1.FillctrlWithData(dtAppointments = clsBusiness.clsTest.GetAllTestAppointmentsWithSpecific(LocalDrivingLicenseApplication, TestTypeTitle, ClassName));
            
            ctrlAppointment1.LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
            ctrlAppointment1.ClassName = ClassName;
            ctrlAppointment1.TestTypeTitle = TestTypeTitle;

            int TestTypeID = clsBusiness.clsTest.GetTestTypeIDByTitle(TestTypeTitle);
            ctrlAppointment1.HasActiveAppointment = clsBusiness.clsTest.CheckAppointmentIfActive(LocalDrivingLicenseApplication, TestTypeID);
            byte CountOfTrails = clsBusiness.clsTest.CheckTestTypeIsAlreadyTaken(LocalDrivingLicenseApplication, TestTypeID);

            if (clsBusiness.clsTest.CheckTestTypeWeatherPassed(LocalDrivingLicenseApplication, TestTypeID))
            {
                ctrlAppointment1.HasPassedTest = true;               
            }
            else if (CountOfTrails > 0)
            {
                ctrlAppointment1.ScheduleTest = new frmScheduleTest(TestTypeTitle, LocalDrivingLicenseApplication, ClassName, CountOfTrails, ctrlApplicationBasic1.Applicant, ctrlApplicationBasic1.Fees);                  
            }
            else if (dtAppointments == null)
            {
                ctrlAppointment1.ScheduleTest = new frmScheduleTest(TestTypeTitle, LocalDrivingLicenseApplication, ClassName, CountOfTrails, ctrlApplicationBasic1.Applicant, ctrlApplicationBasic1.Fees);
            }
            else
            {
                ctrlAppointment1.ScheduleTest = new frmScheduleTest(TestTypeTitle, LocalDrivingLicenseApplication, ClassName, CountOfTrails, ctrlApplicationBasic1.Applicant, ctrlApplicationBasic1.Fees);
            }

            ctrlAppointment1.ScheduledTest = new frmScheduledTest(TestTypeTitle, LocalDrivingLicenseApplication, ClassName, CountOfTrails, ctrlApplicationBasic1.Applicant, ctrlApplicationBasic1.Fees);

            this.ctrlAppointment1.OnFormClose += frmShowApplicationDetails_OnFormClose;
        }

        private void frmShowApplicationDetails_OnFormClose() 
        {
            this.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
