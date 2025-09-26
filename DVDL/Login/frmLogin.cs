using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Portable.Input.Internal;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker.Parser;
using DVDL_Busineses;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace DVDL
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();

            WindowsFormsSettings.AllowRoundedWindowCorners = DefaultBoolean.True;
            ApplyRoundedCorners(pnlSginIn, 3);
        }

        public static DefaultBoolean AllowRoundedWindowCorners { get; set; }
        DVDL.Properties.Settings settings = new DVDL.Properties.Settings();
        public static class clsCurrentUserInfo
        {
            public static int UserID { get; set; } = -1;
            public static int PersonID { get; set; } = -1;
            public static string Username { get; set; }
            public static string Password { get; set; }
            public static bool IsActive { get; set; } = false;

        }

        private void ApplyRoundedCorners(Guna.UI2.WinForms.Guna2CustomGradientPanel panel, int borderRadius)
        {
            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                DataRow drUserInfo = clsBusiness.clsLogin.CheckLoginCredintial(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (drUserInfo != null)
                {
                    if (Convert.ToBoolean(drUserInfo["IsActive"]))
                    {
                        clsCurrentUserInfo.UserID = Convert.ToInt32(drUserInfo["UserID"]);
                        clsCurrentUserInfo.PersonID = Convert.ToInt32(drUserInfo["PersonID"]);
                        clsCurrentUserInfo.Username = drUserInfo["Username"].ToString();
                        clsCurrentUserInfo.Password = drUserInfo["Password"].ToString();
                        clsCurrentUserInfo.IsActive = Convert.ToBoolean(drUserInfo["IsActive"]);

                        if (clsCurrentUserInfo.UserID != -1)
                        {
                            if (chkRemmberMe.Checked)
                            {
                                settings.Username = clsCurrentUserInfo.Username;
                                settings.Password = clsCurrentUserInfo.Password;
                                settings.RemmberMe = chkRemmberMe.Checked;
                            }
                            else
                            {
                                settings.Username = null;
                                settings.Password = null;
                                settings.RemmberMe = false;
                            }

                            settings.Save();

                            frmMainScreen frm = new frmMainScreen();

                            this.Hide();
                            frm.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("This User is not Active please contact\n your Admin . ",
                            "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else 
                {
                    txtPassword.BorderColor = Color.FromArgb(255, 65, 65);
                    txtUsername.BorderColor = Color.FromArgb(255, 65, 65);

                    lblMessage.Visible = true;
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

            txtPassword.BorderColor = Color.DarkGray;
            txtUsername.BorderColor = Color.DarkGray;

            lblMessage.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (settings.RemmberMe)
            {

                txtUsername.Text = settings.Username;
                txtPassword.Text = settings.Password;
                chkRemmberMe.Checked = settings.RemmberMe;

                btnSignIn.Select();
            }
            else
            {
                txtUsername.Focus();
            }
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            object obj = "0";

            if (txtPassword.Tag == obj)
            {
                txtPassword.IconRight = DVDL.Properties.Resources.eye;
                txtPassword.PasswordChar = '\0';
                txtPassword.Tag = "1";
            }
            else 
            {
                txtPassword.IconRight = DVDL.Properties.Resources.invisible;
                txtPassword.PasswordChar = '*';
                txtPassword.Tag = "0";

            }
        }

        private void lnkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
