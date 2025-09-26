using DevExpress.Charts.Native;
using DevExpress.XtraEditors.DXErrorProvider;
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

namespace DVDL
{
    public partial class frmChangePassword : Form
    {
        DVDL.Properties.Settings settings = new DVDL.Properties.Settings();

        private int _UserID = -1;

        public frmChangePassword()
        {
            InitializeComponent();

            _UserID = frmLogin.clsCurrentUserInfo.UserID;
            this.ctrlChangePassword.OldPassword = settings.Password;
        }

        public frmChangePassword(int UserID, string CurrentPasswrod)
        {
            InitializeComponent();

            _UserID = UserID;
            this.ctrlChangePassword.OldPassword = CurrentPasswrod;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            this.ctrlChangePassword.ValidateInput();

            if (this.ctrlChangePassword.IsValid())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to change Password ?", "Confirm ?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (clsBusiness.clsUsers.ChangePassword(_UserID, this.ctrlChangePassword.CurrentPassword.Trim(),
                            this.ctrlChangePassword.NewPassword.Trim()))
                    {
                        MessageBox.Show("Password changed Successfully .", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();

                        if (_UserID == frmLogin.clsCurrentUserInfo.UserID) 
                        {
                            settings.Password = this.ctrlChangePassword.NewPassword.Trim();
                            settings.Save();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password changing Failed !", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please check Current Password !", "Wrong Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.ctrlChangePassword.CurrentPassword) &&
                string.IsNullOrEmpty(this.ctrlChangePassword.NewPassword) &&
                string.IsNullOrEmpty(this.ctrlChangePassword.ConfirmPassword))
                {
                    MessageBox.Show("Please fill all field !", "Missing Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (this.ctrlChangePassword.NewPassword.Trim() !=
                    this.ctrlChangePassword.ConfirmPassword.Trim() &&
                    !string.IsNullOrEmpty(this.ctrlChangePassword.ConfirmPassword) && 
                    !string.IsNullOrEmpty(this.ctrlChangePassword.ConfirmPassword))
                {
                    MessageBox.Show("New Password doesn't matching Confrim Password please check and try again !", "Miss Matching",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else 
                {
                    MessageBox.Show("Please fill missing field !", "Missing Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
