using DevExpress.XtraSpreadsheet.Model;
using DVDL_Busineses;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Native.Json;

namespace DVDL
{
    public partial class ctrlAddPerson : UserControl
    {
        public ctrlAddPerson()
        {
            InitializeComponent();

            FillcmbNationalityWithValues();

        }

        private bool _IsReadOnly;
        DataTable dtCountries;
        public bool IsReadOnly
        {
            get
            {
                return _IsReadOnly;
            }
            set
            {
                _IsReadOnly = value;
                ActivateReadOnly();
            }
        }

        public string ID
        {
            get
            {
                return lblID.Text;
            }
            set
            {
                lblID.Text = value;
            }
        }

        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }

        public string SecondName
        {
            get
            {
                return txtSecondName.Text;
            }
            set
            {
                txtSecondName.Text = value;
            }
        }

        public string ThirdName
        {
            get
            {
                return txtThirdName.Text;
            }
            set
            {
                txtThirdName.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
            }
        }


        public int Nationality
        {
            get
            {
                return cmbNationality.SelectedIndex + 1;
            }
            set
            {
                cmbNationality.SelectedIndex = value - 1;
            }
        }

        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                txtAddress.Text = value;
            }
        }

        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
            set
            {
                txtEmail.Text = value;
            }
        }

        public string Phone
        {
            get
            {
                return txtPhone.Text;
            }
            set
            {
                txtPhone.Text = value;
            }
        }

        public string NationalNo
        {
            get
            {
                return txtNationalNo.Text;
            }
            set
            {
                txtNationalNo.Text = value;
            }
        }

        public string TitleLabel
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public Image TitleImage
        {
            get => pbTitle.BackgroundImage;
            set => pbTitle.BackgroundImage = value;
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dtpDateOfBirth.Value;
            }
            set
            {
                dtpDateOfBirth.Value = value;
            }
        }

        public string PersonImagePath
        {
            get
            {
                return btnAddImage.Tag != null ? btnAddImage.Tag.ToString() : string.Empty;
            }
            set
            {
                try
                {
                    if (File.Exists(value))
                    {
                        btnAddImage.Tag = value;
                        btnAddImage.BackgroundImage = Image.FromFile(btnAddImage.Tag.ToString());
                    }
                    else if (String.IsNullOrEmpty(value))
                    {
                        btnAddImage.Tag = "DVDL.Properties.Resources.person";
                        btnAddImage.BackgroundImage = DVDL.Properties.Resources.person;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public byte Gender
        {
            get
            {
                if (rdoMale.Checked)
                {
                    return Convert.ToByte(rdoMale.Tag);
                }
                else if (rdoFemale.Checked)
                {
                    return Convert.ToByte(rdoFemale.Tag);
                }
                else
                {
                    return 2;
                }
            }
            set
            {
                if (value == Convert.ToByte(rdoMale.Tag))
                {
                    rdoMale.Checked = true;
                    rdoFemale.Checked = false;

                }
                else if (value == Convert.ToByte(rdoFemale.Tag))
                {
                    rdoFemale.Checked = true;
                    rdoMale.Checked = false;

                }
                else
                {
                    rdoMale.Checked = false;
                    rdoFemale.Checked = false;

                }
            }
        }
        public bool IsValid
        {
            get
            {
                if (CheckValdiation() && Gender != 2)
                {

                    return true;
                }

                txtFirstName.Select();
                txtSecondName.Select();
                txtThirdName.Select();
                txtLastName.Select();
                txtEmail.Select();
                txtPhone.Select();
                txtAddress.Select();
                txtNationalNo.Select();
                gbGender.Select();
                txtFirstName.Select();

                return false;
            }
        }

        private void FillcmbNationalityWithValues()
        {
            dtCountries = clsBusiness.clsCountry.GetAllCountries();

            cmbNationality.Items.Clear();

            foreach (DataRow row in dtCountries.Rows)
            {
                cmbNationality.Items.Add(row["CountryName"]);
            }

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPersonImage = new OpenFileDialog();

            ofdPersonImage.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.bmp";

            ofdPersonImage.ShowDialog();

            try
            {
                if (ofdPersonImage.FileName != null && File.Exists(ofdPersonImage.FileName))
                    btnAddImage.BackgroundImage = Image.FromFile(ofdPersonImage.FileName);

                this.PersonImagePath = ofdPersonImage.FileName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void ActivateReadOnly()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            if (_IsReadOnly)
            {
                txtFirstName.ReadOnly = true;
                txtSecondName.ReadOnly = true;
                txtThirdName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtNationalNo.ReadOnly = true;
                dtpDateOfBirth.Enabled = false;
                cmbNationality.Enabled = false;
                btnAddImage.Click -= btnAddImage_Click;

                if (Gender == Convert.ToByte(rdoMale.Tag))
                {
                    rdoMale.Enabled = true;
                    rdoFemale.Enabled = false;
                }
                else if (Gender == Convert.ToByte(rdoFemale.Tag))
                {
                    rdoFemale.Enabled = true;
                    rdoMale.Enabled = false;
                }
                else
                {
                    rdoFemale.Enabled = false;
                    rdoMale.Enabled = false;
                }
            }
            else
            {
                txtFirstName.ReadOnly = false;
                txtSecondName.ReadOnly = false;
                txtThirdName.ReadOnly = false;
                txtLastName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtPhone.ReadOnly = false;
                dtpDateOfBirth.Enabled = true;
                rdoMale.Enabled = true;
                rdoFemale.Enabled = true;
                txtNationalNo.ReadOnly = false;
                btnAddImage.Enabled = true;
                cmbNationality.Enabled = true;

            }
        }

        private void ctrlAddPerson_Load(object sender, EventArgs e)
        {
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ctrlAddPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent the input
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Prevent the character from being entered
            }
        }

        private void CheckPersonDetails()
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                txtFirstName.BorderColor = Color.Red;
            }

        }

        private void cmbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text.Length < 3)
            {
                txtFirstName.BorderColor = Color.FromArgb(255, 8, 8);
                txtFirstName.BorderRadius = 0;
                txtFirstName.IconRight = DVDL.Properties.Resources.Invalid;
                txtFirstName.Tag = false;

            }
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length >= 3)
            {
                txtFirstName.BorderColor = Color.FromArgb(39, 201, 63);
                txtFirstName.IconRight = DVDL.Properties.Resources.Valid;
                txtFirstName.Tag = true;
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(SecondName))
            {
                txtSecondName.BorderColor = Color.FromArgb(255, 8, 8);
                txtSecondName.BorderRadius = 0;
                txtSecondName.IconRight = DVDL.Properties.Resources.Invalid;
                txtSecondName.Tag = false;
            }
        }

        private void txtSecondName_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SecondName))
            {
                txtSecondName.BorderColor = Color.FromArgb(39, 201, 63);
                txtSecondName.IconRight = DVDL.Properties.Resources.Valid;
                txtSecondName.Tag = true;
            }
        }

        private void txtThirdName_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ThirdName))
            {
                txtThirdName.BorderColor = Color.FromArgb(39, 201, 63);
                txtThirdName.IconRight = DVDL.Properties.Resources.Valid;
                txtThirdName.Tag = true;
            }
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ThirdName))
            {
                txtThirdName.BorderColor = Color.FromArgb(255, 8, 8);
                txtThirdName.BorderRadius = 0;
                txtThirdName.IconRight = DVDL.Properties.Resources.Invalid;
                txtThirdName.Tag = false;

            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LastName))
            {
                txtLastName.BorderColor = Color.FromArgb(39, 201, 63);
                txtLastName.IconRight = DVDL.Properties.Resources.Valid;
                txtLastName.Tag = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LastName))
            {
                txtLastName.BorderColor = Color.FromArgb(255, 8, 8);
                txtLastName.BorderRadius = 0;
                txtLastName.IconRight = DVDL.Properties.Resources.Invalid;
                txtLastName.Tag = false;
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(Address))
            {
                txtAddress.BorderColor = Color.FromArgb(39, 201, 63);
                txtAddress.IconRight = DVDL.Properties.Resources.Valid;
                txtAddress.Tag = true;
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Address))
            {
                txtAddress.BorderColor = Color.FromArgb(255, 8, 8);
                txtAddress.BorderRadius = 0;
                txtAddress.IconRight = DVDL.Properties.Resources.Invalid;
                txtAddress.Tag = false;
            }
        }

        private void txtNationalNo_Validated(object sender, EventArgs e)
        {
            if (txtNationalNo.Text.Length >= 9)
            {
                txtNationalNo.BorderColor = Color.FromArgb(39, 201, 63);
                txtNationalNo.IconRight = DVDL.Properties.Resources.Valid;
                txtNationalNo.Tag = true;
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtNationalNo.Text.Length < 9)
            {
                txtNationalNo.BorderColor = Color.FromArgb(255, 8, 8);
                txtNationalNo.BorderRadius = 0;
                txtNationalNo.IconRight = DVDL.Properties.Resources.Invalid;
                txtNationalNo.Tag = false;
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 10)
            {
                txtPhone.BorderColor = Color.FromArgb(39, 201, 63);
                txtPhone.IconRight = DVDL.Properties.Resources.Valid;
                txtPhone.Tag = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Length < 10)
            {
                txtPhone.BorderColor = Color.FromArgb(255, 8, 8);
                txtPhone.BorderRadius = 0;
                txtPhone.IconRight = DVDL.Properties.Resources.Invalid;
                txtPhone.Tag = false;
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length >= 6 && IsValidEmail(txtEmail.Text.Trim()))
            {

                txtEmail.BorderColor = Color.FromArgb(39, 201, 63);
                txtEmail.IconRight = DVDL.Properties.Resources.Valid;
                txtEmail.Tag = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Length < 6 || IsValidEmail(txtEmail.Text.Trim()) == false)
            {
                txtEmail.BorderColor = Color.FromArgb(255, 8, 8);
                txtEmail.BorderRadius = 0;
                txtEmail.IconRight = DVDL.Properties.Resources.Invalid;
                txtEmail.Tag = false;
            }
        }

        private void txtNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Prevent the character from being entered
            }
        }

        private bool CheckValdiation()
        {
            if (Convert.ToBoolean(txtFirstName.Tag) == true &&
                Convert.ToBoolean(txtSecondName.Tag) == true &&
                Convert.ToBoolean(txtThirdName.Tag) == true &&
                Convert.ToBoolean(txtLastName.Tag) == true &&
                Convert.ToBoolean(txtEmail.Tag) == true &&
                Convert.ToBoolean(txtPhone.Tag) == true &&
                Convert.ToBoolean(txtAddress.Tag) == true &&
                Convert.ToBoolean(txtNationalNo.Tag) == true)
            {
                return true;
            }

            return false;
        }

        private void gbGender_Validating(object sender, CancelEventArgs e)
        {
            if (rdoMale.Checked == false && rdoFemale.Checked == false)
            {
                gbGender.BorderColor = Color.FromArgb(255, 8, 8);
                gbGender.BorderRadius = 0;
            }
            else 
            {
                txtEmail.BorderColor = Color.FromArgb(39, 201, 63);
            }
        }

        private void gbGender_Validated(object sender, EventArgs e)
        {
            if (rdoMale.Checked || rdoFemale.Checked)
            {
                txtEmail.BorderColor = Color.FromArgb(39, 201, 63);
            }
        }
    }
}
