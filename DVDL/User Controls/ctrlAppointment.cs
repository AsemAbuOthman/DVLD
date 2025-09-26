using DVDL.Applications;
using DVDL.Tests;
using DVDL_Busineses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL.User_Controls
{
    public partial class ctrlAppointment : UserControl
    {
        public delegate void RefreshData();
        public event RefreshData OnFormClose;

        public ctrlAppointment()
        {
            InitializeComponent();
        }

        public frmScheduleTest ScheduleTest = null;
        public frmScheduledTest ScheduledTest = null;
        public int SelectedRowAppointmetnID = -1;
        public bool HasActiveAppointment = false;
        public bool HasPassedTest = false;
        public int LocalDrivingLicenseApplication = -1;
        public string TestTypeTitle = "";
        public string ClassName = "";
        public void FillctrlWithData(DataTable dtAppointments) 
        {
            if (dtAppointments != null)
            {
                dgvShowLocalApplications.Rows.Clear();

                foreach (DataRow row in dtAppointments.Rows)
                {
                    float.TryParse(row["PaidFees"].ToString(), out float value);

                    dgvShowLocalApplications.Rows.Add(row["TestAppointmentID"],
                        row["AppointmentDate"],
                       value.ToString("C2"),
                        row["IsLocked"]);
                }

                lblRecords.Text = lblRecords.Text.Substring(0, 12) + dgvShowLocalApplications.RowCount.ToString();
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (HasPassedTest)
            {
                MessageBox.Show(@"Person Already has Passed this Test, You can't Add/Edit an Appointment for this Test with this Person !",
                    "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (HasActiveAppointment == true)
            {
                MessageBox.Show(@"Person Already has an active Appointment for this Test, You can't Add new Appointment !",
                "Not Allowed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else  
            {
                frmScheduleTest frm = this.ScheduleTest;

                frm.OnFormClose += frmScheduleTest_OnFormClose;

                frm.ShowDialog();
            }

        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (HasPassedTest)
            {
                MessageBox.Show(@"Person Already has Passed this Test, You can't Add/Edit an Appointment for this Test with this Person !",
                    "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else if (dgvShowLocalApplications.SelectedRows[0].Cells[3].Value.ToString() == "False")
            {
                frmScheduleTest frm = this.ScheduleTest;

                frm.IsUpdateState = true;
                frm.TestAppointmentID = Convert.ToInt32(dgvShowLocalApplications.SelectedRows[0].Cells[0].Value);
                frm.Date = Convert.ToDateTime(dgvShowLocalApplications.SelectedRows[0].Cells[1].Value);
                frm.IsLocked = Convert.ToByte(dgvShowLocalApplications.SelectedRows[0].Cells[3].Value);

                frm.OnFormClose += frmScheduleTest_OnFormClose;

                frm.ShowDialog();
            }
            else if (HasActiveAppointment == true) 
            {
                MessageBox.Show(@"Person Already has an active Appointment for this Test, You can't Add new Appointment !",
                "Not Allowed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void frmScheduleTest_OnFormClose()
        {
            RefreshForm();
        }

        private void frmScheduledTest_OnFormClose()
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            this.FillctrlWithData(clsBusiness.clsTest.GetAllTestAppointmentsWithSpecific(LocalDrivingLicenseApplication, TestTypeTitle, ClassName));

            OnFormClose?.Invoke();
        }

        private void dgvShowLocalApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SelectedRowAppointmetnID = Convert.ToInt32(dgvShowLocalApplications.SelectedRows[0].Cells[0].Value);
        }

        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            if (HasPassedTest)
            {
                MessageBox.Show(@"Person Already has Passed this Test, You can't Add/Edit an Appointment for this Test with this Person !",
                "Not Allowed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (dgvShowLocalApplications.SelectedRows[0].Cells[3].Value.ToString() == "False")
            {
                frmScheduledTest frm = this.ScheduledTest;

                frm.TestAppointmentID = Convert.ToInt32(dgvShowLocalApplications.SelectedRows[0].Cells[0].Value);
                frm.Date = Convert.ToDateTime(dgvShowLocalApplications.SelectedRows[0].Cells[1].Value);

                frm.OnFormClose += frmScheduledTest_OnFormClose;

                frm.ShowDialog();

                HasPassedTest = frm.IsPassed;
            }
            else if (HasActiveAppointment == true) 
            {
                MessageBox.Show(@"Person Already has an active Appointment for this Test, You can't Add new Appointment !",
                "Not Allowed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
