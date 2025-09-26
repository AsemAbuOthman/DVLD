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
    public partial class ctrlAddUser : UserControl
    {
        public ctrlAddUser()
        {
            InitializeComponent();
        }

        private bool _IsReadOnly; 

        public string UserID 
        {
            get 
            {
                return lblUserID.Text;
            }
            set 
            {
                lblUserID.Text = value;
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

        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return txtConfrimPassword.Text;
            }
            set
            {
                txtConfrimPassword.Text = value;
            }
        }

        public bool Status
        {
            get
            {
                if (rdoActive.Checked)
                {
                    return Convert.ToBoolean(rdoActive.Tag);
                }
                else if (rdoNotActive.Checked)
                {
                    return Convert.ToBoolean(rdoNotActive.Tag);
                }
                else
                {

                    rdoActive.Enabled = false;
                    rdoNotActive.Enabled = false;

                    return false;
                }
            }
            set
            {
                if (value == Convert.ToBoolean(rdoActive.Tag))
                {
                    rdoActive.Checked = true;
                }
                else if (value == Convert.ToBoolean(rdoNotActive.Tag))
                {
                    rdoNotActive.Checked = true;
                }
            }
        }

        private void ctrlAddUser_Load(object sender, EventArgs e)
        {
            if (_IsReadOnly)
            {
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtConfrimPassword.ReadOnly = true;

                if (Status == Convert.ToBoolean(rdoActive.Tag))
                {
                    rdoActive.Enabled = true;
                    rdoNotActive.Enabled = false;
                }
                else if (Status == Convert.ToBoolean(rdoNotActive.Tag))
                {
                    rdoNotActive.Enabled = true;
                    rdoActive.Enabled = false;

                }
                else
                {
                    rdoNotActive.Enabled = false;
                    rdoActive.Enabled = false;
                }
            }
            else
            {
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtConfrimPassword.ReadOnly = false;
            }
        }
    }
}
