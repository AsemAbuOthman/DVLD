using DVDL.Tests;
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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        DataTable dtTestTypes = clsBusiness.clsTest.GetAllTestTypesDetails();

        private void FilldgvShowTestTypes(DataTable dtApplicationTypes)
        {
            if (this.dtTestTypes != null)
            {
                dgvShowTestTypes.Rows.Clear();

                foreach (DataRow row in this.dtTestTypes.Rows)
                {
                    float.TryParse(row["TestTypeFees"].ToString(), out float value);

                    dgvShowTestTypes.Rows.Add(row["TestTypeID"],
                        row["TestTypeTitle"],
                        row["TestTypeDescription"],
                       value.ToString("C2"));

                }

                lblRecords.Text = lblRecords.Text.Substring(0, 12) + dgvShowTestTypes.RowCount.ToString();
            }
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            if (dtTestTypes != null)
            {
                FilldgvShowTestTypes(dtTestTypes);
            }
            else
            {
                dgvShowTestTypes.Rows.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEditTestType_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType();

            frm.ID = dgvShowTestTypes.CurrentRow.Cells["dgvcTestID"].Value.ToString();
            frm.Title = dgvShowTestTypes.CurrentRow.Cells["dgvcTestTitle"].Value.ToString();
            frm.Description = dgvShowTestTypes.CurrentRow.Cells["dgvcTestDescription"].Value.ToString();
            float.TryParse(dgvShowTestTypes.CurrentRow.Cells["dgvcTestFees"].Value.ToString().Remove(0, 1), out float value);

            frm.Fees = value;

            frm.ShowDialog();

            dtTestTypes = clsBusiness.clsTest.GetAllTestTypesDetails();
            FilldgvShowTestTypes(dtTestTypes);
        }
    }
}
