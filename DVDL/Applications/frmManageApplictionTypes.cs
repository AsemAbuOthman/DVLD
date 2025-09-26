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
    public partial class frmManageApplictionTypes : Form
    {
        public frmManageApplictionTypes()
        {
            InitializeComponent();
        }

        DataTable dtApplicationTypes = clsBusiness.clsApplication.GetAllApplicationTypesDetails();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageApplictionTypes_Load(object sender, EventArgs e)
        {
            if (dtApplicationTypes != null)
            {
                FilldgvShowApplicationTypes(dtApplicationTypes);
            }
            else
            {
                dgvShowApplicationTypes.Rows.Clear();
            }
        }

        private void FilldgvShowApplicationTypes(DataTable dtApplicationTypes) 
        {
            if (this.dtApplicationTypes != null)
            {
                dgvShowApplicationTypes.Rows.Clear();

                foreach (DataRow row in this.dtApplicationTypes.Rows)
                {
                    float.TryParse(row["ApplicationFees"].ToString(), out float value);

                    dgvShowApplicationTypes.Rows.Add(row["ApplicationTypeID"],
                        row["ApplicationTypeTitle"],
                       value.ToString("C2"));

                }

                lblRecords.Text = lblRecords.Text.Substring(0, 12) + dgvShowApplicationTypes.RowCount.ToString();
            }
        }

        private void cmsManageApplicationTypes_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tsmiEditApplicationType_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType();

            frm.ID = dgvShowApplicationTypes.CurrentRow.Cells["dgvcApplicationID"].Value.ToString();
            frm.Title = dgvShowApplicationTypes.CurrentRow.Cells["dgvcTitle"].Value.ToString();
            float.TryParse(dgvShowApplicationTypes.CurrentRow.Cells["dgvcFees"].Value.ToString().Remove(0, 1), out float value);

            frm.Fees = value;

            frm.ShowDialog();

            dtApplicationTypes = clsBusiness.clsApplication.GetAllApplicationTypesDetails();
            FilldgvShowApplicationTypes(dtApplicationTypes);

        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbUsers_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dgvShowApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void dgvShowUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
