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
using static DevExpress.Xpo.Helpers.CannotLoadObjectsHelper;

namespace DVDL.Tests
{
    public partial class frmScheduledTest : Form
    {
        public delegate void RefreshData();
        public event RefreshData OnFormClose;

        public frmScheduledTest()
        {
            InitializeComponent();
        }

        public int TestAppointmentID;
        public bool IsPassed = false;

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

        public frmScheduledTest(string TestType, int LocalApplicationID, string Class, int Trail, string Name, float Fees)
        {
            InitializeComponent();


            switch (TestType)
            {
                case "Vision Test":
                    lblScheduleTest.Text = "Sceduled Vision Test";
                    lblTitle.BackgroundImage = DVDL.Properties.Resources.VisionTest;
                    lblScheduleTest.Tag = 1;
                    break;

                case "Written (Theory) Test":
                    lblScheduleTest.Text = "Sceduled Written (Theory) Test";
                    lblTitle.BackgroundImage = DVDL.Properties.Resources.WrittenTest;
                    lblScheduleTest.Tag = 2;

                    break;

                case "Practical (Street) Test":
                    lblScheduleTest.Text = "Sceduled Practical (Street) Test";
                    lblTitle.BackgroundImage = DVDL.Properties.Resources.DrivingTest;
                    lblScheduleTest.Tag = 3;

                    break;

            }

            lblDLApplicationID.Text += LocalApplicationID;
            txtClass.Text += Class;
            lblTrail.Text += Trail;
            txtName.Text += Name;
            txtFees.Text += Fees.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            OnFormClose?.Invoke();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdoPass.Checked)
            {
                gbResults.Tag = 1;
                IsPassed = true;
            }
            else if (rdoFail.Checked) 
            {
                gbResults.Tag = 0;
                IsPassed = false;
            }

            if (clsBusiness.clsTest.AddNewTest(TestAppointmentID, Convert.ToByte(gbResults.Tag), txtNotes.Text.Trim(), frmLogin.clsCurrentUserInfo.UserID))
            {
                MessageBox.Show("Result for this Person has Added Successfully .",
                    "Result Added Successfully",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else 
            {
                MessageBox.Show("Result for this Person has failed to Save .",
                    "Result Failed ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}
