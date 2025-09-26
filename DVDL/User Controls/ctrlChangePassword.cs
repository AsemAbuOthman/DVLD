using DevExpress.XtraReports.Configuration;
using DVDL_Busineses;
using Guna.UI2.WinForms;
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
    public partial class ctrlChangePassword : UserControl
    {
        public ctrlChangePassword()
        {
            InitializeComponent();

        }

        

        private string _OldPassword = "-1";

        public string OldPassword
        {
            get
            {

                return _OldPassword;
            }

            set
            {
                _OldPassword = value;
            }
        }

        public string CurrentPassword
        {
            get
            {

                return txtCurrentPassword.Text;
            }

            set
            {
                txtCurrentPassword.Text = value;
            }
        }

        public string NewPassword
        {
            get
            {
                return txtNewPassword.Text;
            }

            set
            {
                txtNewPassword.Text = value;
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return txtConfirmPassword.Text;
            }

            set
            {
                txtConfirmPassword.Text = value;
            }
        }

        public void ValidateInput()
        {
          txtCurrentPassword.Focus();
          txtNewPassword.Focus();
          txtConfirmPassword.Focus();
          txtCurrentPassword.Focus();

        }

        private void txtNewPassword_IconRightClick(object sender, EventArgs e)
        {
            object obj = "0";

            if (txtNewPassword.Tag == obj)
            {
                txtNewPassword.IconRight = DVDL.Properties.Resources.eye;
                txtNewPassword.PasswordChar = '\0';
                txtNewPassword.Tag = "1";
            }
            else
            {
                txtNewPassword.IconRight = DVDL.Properties.Resources.invisible;
                txtNewPassword.PasswordChar = '*';
                txtNewPassword.Tag = "0";
            }
        }

        private void txtConfirmPassword_IconRightClick(object sender, EventArgs e)
        {
            object obj = "0";

            if (txtConfirmPassword.Tag == obj)
            {
                txtConfirmPassword.IconRight = DVDL.Properties.Resources.eye;
                txtConfirmPassword.PasswordChar = '\0';
                txtConfirmPassword.Tag = "1";
            }
            else
            {
                txtConfirmPassword.IconRight = DVDL.Properties.Resources.invisible;
                txtConfirmPassword.PasswordChar = '*';
                txtConfirmPassword.Tag = "0";
            }
        }

        private void ValidateForm(Guna2TextBox myControl) 
        {
            if (string.IsNullOrEmpty(myControl.Text.Trim()))
            {
                epMissing.SetError(myControl, "");
                epSuccessed.SetError(myControl, "");

                epError.SetError(myControl, "Required !");

                myControl.BorderColor = Color.FromArgb(255, 8, 8);
                myControl.BorderRadius = 0;
                myControl.Tag = false;
            }
            else if (myControl.Text.Length < 8)
            {
                epError.SetError(myControl, "");
                epSuccessed.SetError(myControl, "");

                epMissing.SetError(myControl, "Plesae enter you password !");

                myControl.BorderColor = Color.Gold;
                myControl.BorderRadius = 0;
                myControl.Tag = false;
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateForm(txtCurrentPassword);
        }

        private void txtCurrentPassword_Validated(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text.Length >= 8 && txtCurrentPassword.Text.Trim() == _OldPassword)
            {
                epSuccessed.SetError(txtCurrentPassword, "Done Successfully");

                epMissing.SetError(txtCurrentPassword, "");
                epError.SetError(txtCurrentPassword, "");

                txtCurrentPassword.BorderColor = Color.FromArgb(39, 201, 63);
                txtCurrentPassword.BorderRadius = 2;
                txtCurrentPassword.Tag = true;
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateForm(txtNewPassword);
        }

        private void txtNewPassword_Validated(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length >= 8)
            {
                epMissing.SetError(txtNewPassword, "");
                epError.SetError(txtNewPassword, "");

                epSuccessed.SetError(txtNewPassword, "Done Successfully");

                txtNewPassword.BorderColor = Color.FromArgb(39, 201, 63);
                txtNewPassword.BorderRadius = 2;
                txtNewPassword.Tag = true;
            }
        }



        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateForm(txtConfirmPassword);
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text.Length >= 8 && txtConfirmPassword.Text.Trim() == txtNewPassword.Text.Trim())
            {
                epMissing.SetError(txtConfirmPassword, "");
                epError.SetError(txtConfirmPassword, "");

                epSuccessed.SetError(txtConfirmPassword, "Done Successfully");

                txtConfirmPassword.BorderColor = Color.FromArgb(39, 201, 63);
                txtConfirmPassword.BorderRadius = 2;
                txtConfirmPassword.Tag = true;
            }
        }

        public bool IsValid() 
        {
            if (Convert.ToBoolean(txtCurrentPassword.Tag) == true &&
                Convert.ToBoolean(txtNewPassword.Tag) == true &&
                Convert.ToBoolean(txtConfirmPassword.Tag) == true) 
            {
                return true;
            }

            return false;
        }
    }
}
