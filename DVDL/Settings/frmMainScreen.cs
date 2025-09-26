using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevExpress.XtraReports.Serialization;
using DVDL.Properties;
using DevExpress.XtraTabbedMdi;
using DVDL_Busineses;
using DevExpress.Utils.Extensions;
using DVDL.Applications;
using DVDL.Tests;


namespace DVDL
{
    public partial class frmMainScreen : DevExpress.XtraEditors.XtraForm
    {
        public static DefaultBoolean AllowRoundedWindowCorners { get; set; }
        public frmMainScreen()
        {
            InitializeComponent();

            btnMaximize.PerformClick();

            WindowsFormsSettings.AllowRoundedWindowCorners = DefaultBoolean.True;

            msOptions.Renderer = new CustomToolStripRenderer();

            this.BackColor = Color.FromArgb(215, 215, 215);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPersonDetails frm = new frmAddPersonDetails();

            frm.ShowDialog();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersons frmShowPersonsChild = new frmShowPersons();

            frmShowPersonsChild.MdiParent = this;
            frmShowPersonsChild.StartPosition = FormStartPosition.CenterParent;
            frmShowPersonsChild.Show();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.BackgroundImage = Resources.Maximize;
                //this.TopMost = true;

                tsmApplications.Size = new System.Drawing.Size(382, 120);
                tsmDrivers.Size = new System.Drawing.Size(382, 120);
                tsmPeople.Size = new System.Drawing.Size(382, 120);
                tsmUsers.Size = new System.Drawing.Size(382, 120);
                tsmSettings.Size = new System.Drawing.Size(381, 120);

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;              
                btnMaximize.BackgroundImage = Resources.Square;
                //this.TopMost = false;

                tsmApplications.Size = new System.Drawing.Size(219, 120);
                tsmDrivers.Size = new System.Drawing.Size(219, 120);
                tsmPeople.Size = new System.Drawing.Size(219, 120);
                tsmUsers.Size = new System.Drawing.Size(219, 120);
                tsmSettings.Size = new System.Drawing.Size(219, 120);

            }
        }

        private void HighLightChoosenOption()
        {
            tsmApplications.BackColor = Color.FromArgb(230, 230, 230);
            tsmPeople.BackColor = Color.FromArgb(230, 230, 230);
            tsmDrivers.BackColor = Color.FromArgb(230, 230, 230);
            tsmUsers.BackColor = Color.FromArgb(230, 230, 230);
            tsmSettings.BackColor = Color.FromArgb(230, 230, 230);
         
            if (tsmApplications.Checked)
            {
                tsmApplications.BackColor = Color.FromArgb(35, 0, 0, 0);               
            }
            else if (tsmPeople.Checked)
            {
                tsmPeople.BackColor = Color.FromArgb(35, 0, 0, 0);
            }
            else if (tsmDrivers.Checked)
            {
                tsmDrivers.BackColor = Color.FromArgb(35, 0, 0, 0);
            }
            else if (tsmUsers.Checked)
            {
                tsmUsers.BackColor = Color.FromArgb(35, 0, 0, 0);
            }
            else if (tsmSettings.Checked)
            {
                tsmSettings.BackColor = Color.FromArgb(35, 0, 0, 0);
            }
        }

        private void ShowForm<T>(string Title) where T : Form, new()
        {
            // Check if the form is already open in the MDI manager
            Form existingForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (existingForm != null)
            {
                // Activate the existing form
                existingForm.Activate();
            }
            else
            {
                // Create a new instance if it is not already open
                T newForm = new T
                {
                    MdiParent = this
                };
                newForm.Show();
                newForm.Text = Title;
            }
        
        }
        private bool HasChildTabs()
        {
            // Check if there are any open child forms
            if (xtraTabbedMdiManager1.Pages.Count > 0)
            {
                return true; // There are child tabs
            }
            return false; // No child tabs
        }

        private void tsmApplications_Click(object sender, EventArgs e)
        {
            tsmPeople.Checked = tsmDrivers.Checked = tsmUsers.Checked = tsmSettings.Checked = false;

            HighLightChoosenOption();
        }

        private void tsmPeople_Click(object sender, EventArgs e)
        {

            ShowForm<frmShowPersons>("People");

            tsmApplications.Checked = tsmDrivers.Checked = tsmUsers.Checked = tsmSettings.Checked = false;

            HighLightChoosenOption();

        }
        private void tsmDrivers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drivers");

            tsmPeople.Checked = tsmApplications.Checked = tsmUsers.Checked = tsmSettings.Checked = false;


            HighLightChoosenOption();

            
        }

        private void tsmUsers_Click(object sender, EventArgs e)
        {

            tsmPeople.Checked = tsmApplications.Checked = tsmDrivers.Checked = tsmSettings.Checked = false;

            HighLightChoosenOption();

            ShowForm<frmShowUsers>("Users");
        }

        private void tsmSettings_Click(object sender, EventArgs e)
        {
            tsmPeople.Checked = tsmApplications.Checked = tsmDrivers.Checked = tsmUsers.Checked = false;

            HighLightChoosenOption();

        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        public void tsmMyInfo_Click(object sender, EventArgs e, int UserID = -1)
        {
            if (UserID == -1)
            {
                frmShowUserDetails frm = new frmShowUserDetails(frmLogin.clsCurrentUserInfo.UserID);

                frm.ShowDialog();
            }
            else 
            {
                frmShowUserDetails frm = new frmShowUserDetails(UserID);

                frm.ShowDialog();
            }


        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();

            this.Close();
            frm.Show();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();

            frm.ShowDialog();
        }

        public void AdjustToolStripMenuItemSize()
        {
            int itemCount = msOptions.Items.Count;
            int totalWidth = msOptions.Width;

            // Calculate the width for each item except the last one
            int itemWidth = totalWidth / itemCount;

            // Adjust the width of each item except the last
            for (int i = 0; i < itemCount - 1; i++)
            {
                msOptions.Items[i].Width = itemWidth;
            }

            // Set the last item's width to fill the remaining space
            msOptions.Items[itemCount - 1].Width = totalWidth - (itemWidth * (itemCount - 1));
        }

        private void frmMainScreen_Resize(object sender, EventArgs e)
        {
            AdjustToolStripMenuItemSize();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            if (HasChildTabs())
            {
                xtraTabbedMdiManager1.Appearance.BackColor = Color.FromArgb(238, 238, 238);

            }
            else 
            {
                xtraTabbedMdiManager1.Appearance.BackColor = Color.Empty;
            }
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            if (HasChildTabs())
            {
                xtraTabbedMdiManager1.Appearance.BackColor = Color.FromArgb(238, 238, 238);

            }
            else
            {
                xtraTabbedMdiManager1.Appearance.BackColor = Color.Empty;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void tsmMyInfo_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(frmLogin.clsCurrentUserInfo.UserID);
            frm.ShowDialog();
        }

        private void tsmiLocalLicense_Click(object sender, EventArgs e)
        {

        }

        private void tsmiManageApplicationsTypes_Click(object sender, EventArgs e)
        {
            ShowForm<frmManageApplictionTypes>("Manage Application Types");
        }

        private void tsmiManageTestTypes_Click(object sender, EventArgs e)
        {
            ShowForm<frmManageTestTypes>("Manage Test Types");
        }

        private void tsmiLocalApplications_Click(object sender, EventArgs e)
        {
            ShowForm<frmShowApplication>("Local Driving License Applications");

        }
    }

    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        // Override the menu item background rendering to include hover and rounded corners
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
                {
            // Define the corner radius
            int cornerRadius = 3;

            // Create a rounded rectangle path for the item
            Rectangle itemRect = new Rectangle(Point.Empty, e.Item.Size);
            using (GraphicsPath path = RoundedRect(itemRect, cornerRadius))
            {
                // Check if the item is selected (hovered)
                if (e.Item.Selected)
                {
                    // Use a custom hover background color
                    using (Brush hoverBrush = new SolidBrush(Color.FromArgb(25, 100, 100, 100)))
                    {
                        e.Graphics.FillPath(hoverBrush, path);
                    }
                }
                else
                {
                    // Use the default background if not hovered
                    base.OnRenderMenuItemBackground(e);
                }
            }
        }

        // Method to create a rounded rectangle path
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            float diameter = radius * 2;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(bounds.Location, sizeF);
            GraphicsPath path = new GraphicsPath();

            // Top left arc
            path.AddArc(arc, 180, 90);

            // Top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
