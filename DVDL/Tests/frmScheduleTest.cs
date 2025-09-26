using DevExpress.XtraBars.Docking2010.DragEngine;
using DevExpress.XtraReports.Native.PrintingAsync;
using DVDL.Applications;
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

namespace DVDL.Tests
{

    public partial class frmScheduleTest : Form
    {
        public delegate void RefreshData();
        public event RefreshData OnFormClose;

        public frmScheduleTest()
        {
            InitializeComponent();

            dtpDate.Value = DateTime.Now;

        }

        private int _LocalApplicationID;
        public bool IsUpdateState = false;
        public int TestAppointmentID = -1;
        public byte IsLocked = 0;
         
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

        public frmScheduleTest(string TestType, int LocalApplicationID, string Class, int Trail, string Name, float Fees, int RetakeFees = 0, int RetakeTestAppID = -1)
        {

            InitializeComponent();

            switch (TestType)
            {
                case "Vision Test":
                    lblScheduleTest.Text = "Vision Test";
                    lblTitle.BackgroundImage = DVDL.Properties.Resources.VisionTest;
                    lblScheduleTest.Tag = 1;

                    break;

                case "Written (Theory) Test":
                    lblScheduleTest.Text = "Written (Theory) Test";
                    lblTitle.BackgroundImage = DVDL.Properties.Resources.WrittenTest;
                    lblScheduleTest.Tag = 2;

                    break;

                case "Practical (Street) Test":
                    lblScheduleTest.Text = "Practical (Street) Test";
                    lblTitle.BackgroundImage = DVDL.Properties.Resources.DrivingTest;
                    lblScheduleTest.Tag = 3;

                    break;
            }

            _LocalApplicationID = LocalApplicationID;

            lblDLApplicationID.Text += LocalApplicationID;
            txtClass.Text += Class;
            lblTrail.Text += Trail;
            txtName.Text += Name;
            txtFees.Text += Fees.ToString("C");
            lblRetakeFees.Text += RetakeFees.ToString("C");
            lblTotalFees.Text += (RetakeFees + Fees).ToString("C");
            lblRetakeTestAppID.Text += RetakeTestAppID;

            if (RetakeTestAppID != -1)
            {
                lblRetakeFees.ForeColor = Color.FromArgb(60,60,60);
                lblRetakeTestAppID.ForeColor = Color.FromArgb(60, 60, 60);
                lblTotalFees.ForeColor = Color.FromArgb(60, 60, 60);                    
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            OnFormClose?.Invoke();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsBusiness.clsTest.CheckAppointmentIfActive(_LocalApplicationID, Convert.ToInt32(lblScheduleTest.Tag)) || IsUpdateState)
            {
                if (clsBusiness.clsTest.UpdateTestAppointment(TestAppointmentID, dtpDate.Value, IsLocked)) 
                {
                    MessageBox.Show("This Appointment has Updated Successfully .",
                        "Updated Successed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("This Appointment hasn't Updated !",
                        "Updated Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                IsUpdateState = false;
            }
            else
            {
                if (clsBusiness.clsTest.AddNewTestAppointment(Convert.ToInt32(lblScheduleTest.Tag),
                        _LocalApplicationID,
                        dtpDate.Value,
                        Convert.ToSingle(lblTotalFees.Text.Remove(0, 16)),
                        frmLogin.clsCurrentUserInfo.UserID))
                {
                    MessageBox.Show("Appointment for this Person has Added Successfully .",
                        "Added Successed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Appointment for this Person hasn't Added !",
                        "Added Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
