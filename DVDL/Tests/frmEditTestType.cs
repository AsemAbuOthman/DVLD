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
using DevExpress.XtraGauges.Core.Model;

namespace DVDL.Tests
{
    public partial class frmEditTestType : Form
    {
        public frmEditTestType()
        {
            InitializeComponent();
        }

        public string ID
        {
            get
            {
                return lblID.Text;
            }
            set
            {
                lblID.Text += value;
            }
        }

        public string Title
        {
            get
            {
                return txtTitle.Text;
            }
            set
            {
                txtTitle.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return txtDescription.Text;
            }
            set
            {
                txtDescription.Text = value;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ClearField()
        {
            if (!string.IsNullOrEmpty(Title))
            {
                txtTitle.Clear();
                Title = string.Empty;
            }

            if (!string.IsNullOrEmpty(Description))
            {
                txtDescription.Clear();
                Description = string.Empty;
            }

            if (!string.IsNullOrEmpty(Fees.ToString()))
            {
                Fees = 0;
                txtFees.Clear();
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Description))
            {
                txtDescription.BorderColor = Color.FromArgb(255, 8, 8);
                txtDescription.BorderRadius = 0;
                txtDescription.IconRight = DVDL.Properties.Resources.Invalid;
                txtDescription.Tag = false;
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Description))
            {
                txtDescription.BorderColor = Color.FromArgb(39, 201, 63);
                txtDescription.IconRight = DVDL.Properties.Resources.Valid;
                txtDescription.Tag = true;
            }
            else 
            {
                txtDescription.BorderColor = Color.FromArgb(255, 8, 8);
                txtDescription.BorderRadius = 0;
                txtDescription.IconRight = DVDL.Properties.Resources.Invalid;
                txtDescription.Tag = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtTitle.Select();
            txtDescription.Select();
            txtFees.Select();
            btnSave.Focus();

            if (Convert.ToBoolean(txtTitle.Tag) == true
                && Convert.ToBoolean(txtDescription.Tag) == true
                && Convert.ToBoolean(txtFees.Tag) == true)
            {
                DialogResult result = MessageBox.Show("Are you sure want to update this Test Type ? ",
                        "Confirm ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool IsUpdated = clsBusiness.clsTest.UpdateTestType(
                         Convert.ToInt32(ID.Remove(0, 4)),
                         Title,
                         Description,
                         Fees);

                    if (IsUpdated)
                    {
                        MessageBox.Show($"Test type With ID : [{ID.Remove(0, 4)}] Edit Successfully.", "Edited Successfully",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Editing test type was field !",
                            "Editing field ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Operatin was canceled !",
                         "Canceled ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Please fill Missing field and try again !",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();

        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Title))
            {
                txtTitle.BorderColor = Color.FromArgb(255, 8, 8);
                txtTitle.BorderRadius = 0;
                txtTitle.IconRight = DVDL.Properties.Resources.Invalid;
                txtTitle.Tag = false;
            }
        }

        private void txtTitle_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                txtTitle.BorderColor = Color.FromArgb(39, 201, 63);
                txtTitle.IconRight = DVDL.Properties.Resources.Valid;
                txtTitle.Tag = true;
            }
            else 
            {
                txtTitle.BorderColor = Color.FromArgb(255, 8, 8);
                txtTitle.BorderRadius = 0;
                txtTitle.IconRight = DVDL.Properties.Resources.Invalid;
                txtTitle.Tag = false;
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (Fees == 0)
            {
                txtFees.BorderColor = Color.FromArgb(255, 8, 8);
                txtFees.BorderRadius = 0;
                txtFees.IconRight = DVDL.Properties.Resources.Invalid;
                txtFees.Tag = false;
            }
        }

        private void txtFees_Validated(object sender, EventArgs e)
        {
            if (Fees != 0 && !string.IsNullOrEmpty(txtFees.Text))
            {
                txtFees.Text.Insert(0, $"{Currency.USD} ");

                txtFees.BorderColor = Color.FromArgb(39, 201, 63);
                txtFees.IconRight = DVDL.Properties.Resources.Valid;
                txtFees.Tag = true;
            }
            else 
            {
                txtFees.BorderColor = Color.FromArgb(255, 8, 8);
                txtFees.BorderRadius = 0;
                txtFees.IconRight = DVDL.Properties.Resources.Invalid;
                txtFees.Tag = false;
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

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Prevent the character from being entered
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent the input
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

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            txtDescription.Focus();
            txtFees.Focus();
            txtTitle.Focus();
            btnSave.Focus();
        }
    }
}
