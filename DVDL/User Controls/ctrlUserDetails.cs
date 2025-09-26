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
    public partial class ctrlUserDetails : UserControl
    {
        public ctrlUserDetails()
        {
            InitializeComponent();
        
        }
        private bool _IsReadOnly;
        public bool IsReadOnly
        {
            get
            {
                return _IsReadOnly;
            }
            set
            {
                _IsReadOnly = value;
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


        public bool Status
        {
            get
            {
                if (rdoActive.Checked)
                {
                    return Convert.ToBoolean(rdoActive.Tag);
                }
                else 
                {
                    return Convert.ToBoolean(rdoNotActive.Tag);
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

        private void ucUserDetails_Load(object sender, EventArgs e)
        {
            if (_IsReadOnly)
            {
                txtUsername.ReadOnly = true;


                if (Status)
                {
                    rdoActive.Enabled = true;
                    rdoNotActive.Enabled = false;
                }
                else 
                {
                    rdoNotActive.Enabled = true;
                    rdoActive.Enabled = false;

                }
            }
            else
            {
                txtUsername.ReadOnly = true;
                rdoNotActive.Enabled = true;
                rdoActive.Enabled = true;
            }

        }
    }
}
