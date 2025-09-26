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
    public partial class ctrlAddNewApplication : UserControl
    {
        public ctrlAddNewApplication()
        {
            InitializeComponent();
        }

        DataTable dtClasses = new DataTable();

        public string ApplicationID
        {
            get
            {
                return lblApplicationID.Text;
            }
            set
            {
                lblApplicationID.Text = value;
            }
        }

        public DateTime ApplicationDate
        {
            get
            {
                return dtpApplicationDate.Value;
            }
        }


        public int Classes
        {
            get
            {
                return cmbClasses.SelectedIndex + 1;
            }
            set
            {
                cmbClasses.SelectedIndex = value - 1;
            }
        }

        public float Fees
        {
            get
            {
                if (string.IsNullOrEmpty(txtFees.Text))
                {
                    return 0;
                }
                else if (txtFees.Text == "$")
                {
                    return 0;
                }
                else if (txtFees.Text.Contains("$"))
                {
                    float value;
                    float.TryParse(txtFees.Text.Substring(1), out value);

                    return value;
                }

                return Convert.ToSingle(txtFees.Text);
            }
            set
            {
                if (txtFees.Text.Contains("$"))
                {
                    txtFees.Text.Remove(0, 1);
                    txtFees.Text = value.ToString();
                }

                txtFees.Text = value.ToString();
            }
        }

        public string Username
        {
            get
            {
                return txtUsername.Text;
            }
            set
            {
                txtUsername.Text = value;
            }
        }

        private void ctrlAddNewApplication_Load(object sender, EventArgs e)
        {
            FillcmbClassesWithValues();
            txtUsername.Text = frmLogin.clsCurrentUserInfo.Username;
            cmbClasses.SelectedIndex = 2;
        }

        private void FillcmbClassesWithValues()
        {
            dtClasses = clsBusiness.clsLicenseClasses.GetAllLicenseClassesName();

            cmbClasses.Items.Clear();

            foreach (DataRow row in dtClasses.Rows)
            {
                cmbClasses.Items.Add(row["ClassName"]);
            }

        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbClasses.SelectedIndex == 0)
            {
                txtFees.Text = dtClasses.Rows[0][1].ToString();
                cmbClasses.Tag = "1";

            }
            else if (cmbClasses.SelectedIndex == 1)
            {
                txtFees.Text = dtClasses.Rows[1][1].ToString();
                cmbClasses.Tag = "2";
            }
            else if (cmbClasses.SelectedIndex == 2)
            {

                txtFees.Text = dtClasses.Rows[2][1].ToString();

                cmbClasses.Tag = "3";

            }
            else if (cmbClasses.SelectedIndex == 3)
            {
                txtFees.Text = dtClasses.Rows[3][1].ToString();
                cmbClasses.Tag = "4";

            }
            else if (cmbClasses.SelectedIndex == 4)
            {

                txtFees.Text = dtClasses.Rows[4][1].ToString();
                cmbClasses.Tag = "5";

            }
            else if (cmbClasses.SelectedIndex == 5)
            {
                txtFees.Text = dtClasses.Rows[5][1].ToString();
                cmbClasses.Tag = "6";

            }
            else if (cmbClasses.SelectedIndex == 6)
            {
                txtFees.Text = dtClasses.Rows[6][1].ToString();
                cmbClasses.Tag = "7";
            }
            else 
            {
                txtFees.Text = "0";
                cmbClasses.Tag = "";
            }

        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {
            string fixedText = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

            if (!txtFees.Text.StartsWith(fixedText))
            {
                txtFees.Text = fixedText + txtFees.Text.TrimStart();
                txtFees.SelectionStart = txtFees.Text.Length; // Move caret to the end
            }
        }

        private void txtFees_KeyDown(object sender, KeyEventArgs e)
        {
            // Define the fixed text (currency symbol)
            string fixedText = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

            // Prevent caret movement into the fixed text area using arrow keys
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Home) && txtFees.SelectionStart <= fixedText.Length)
            {
                e.SuppressKeyPress = true; // Block the key action
            }

            // Prevent Backspace or Delete if caret is in the fixed text area
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) &&
                txtFees.SelectionStart <= fixedText.Length)
            {
                e.SuppressKeyPress = true; // Block the key action
            }
        }
    }
}
