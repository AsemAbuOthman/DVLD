namespace DVDL
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.tsmApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsApplications = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiDrivingLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDrivingLicensesServices = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbNewDrivingLicense = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGlobalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReplacementLostOrDamaged = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReleaseDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbManageApplications = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiLocalApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGlobalApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageApplicationsTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSettings = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmMyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.msOptions.SuspendLayout();
            this.cmsApplications.SuspendLayout();
            this.cmsDrivingLicensesServices.SuspendLayout();
            this.cmbNewDrivingLicense.SuspendLayout();
            this.cmbManageApplications.SuspendLayout();
            this.cmsSettings.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            this.toolTipController1.KeepWhileHovered = true;
            this.toolTipController1.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.RightCenter;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // msOptions
            // 
            this.msOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.msOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msOptions.GripMargin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.msOptions.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmApplications,
            this.tsmPeople,
            this.tsmDrivers,
            this.tsmUsers,
            this.tsmSettings});
            this.msOptions.Location = new System.Drawing.Point(0, 474);
            this.msOptions.Name = "msOptions";
            this.msOptions.Padding = new System.Windows.Forms.Padding(0);
            this.msOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msOptions.Size = new System.Drawing.Size(1106, 114);
            this.msOptions.TabIndex = 0;
            this.msOptions.Text = "menuStrip1";
            // 
            // tsmApplications
            // 
            this.tsmApplications.AutoSize = false;
            this.tsmApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmApplications.CheckOnClick = true;
            this.tsmApplications.DropDown = this.cmsApplications;
            this.tsmApplications.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmApplications.Image = ((System.Drawing.Image)(resources.GetObject("tsmApplications.Image")));
            this.tsmApplications.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmApplications.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmApplications.MergeIndex = 0;
            this.tsmApplications.Name = "tsmApplications";
            this.tsmApplications.Padding = new System.Windows.Forms.Padding(0);
            this.tsmApplications.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmApplications.Size = new System.Drawing.Size(219, 114);
            this.tsmApplications.Text = "Applications";
            this.tsmApplications.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmApplications.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmApplications.Click += new System.EventHandler(this.tsmApplications_Click);
            // 
            // cmsApplications
            // 
            this.cmsApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cmsApplications.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDrivingLicensesServices,
            this.toolStripSeparator2,
            this.tsmiManageApplications,
            this.toolStripSeparator1,
            this.tsmiDetainLicense,
            this.tsmiManageApplicationsTypes,
            this.tsmiManageTestTypes});
            this.cmsApplications.Name = "guna2ContextMenuStrip1";
            this.cmsApplications.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsApplications.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsApplications.RenderStyle.ColorTable = null;
            this.cmsApplications.RenderStyle.RoundedEdges = true;
            this.cmsApplications.RenderStyle.SelectionArrowColor = System.Drawing.SystemColors.GrayText;
            this.cmsApplications.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsApplications.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsApplications.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsApplications.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmsApplications.Size = new System.Drawing.Size(369, 284);
            // 
            // tsmiDrivingLicensesServices
            // 
            this.tsmiDrivingLicensesServices.AutoSize = false;
            this.tsmiDrivingLicensesServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmiDrivingLicensesServices.DropDown = this.cmsDrivingLicensesServices;
            this.tsmiDrivingLicensesServices.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiDrivingLicensesServices.Image = global::DVDL.Properties.Resources.DrivingLicenseServices;
            this.tsmiDrivingLicensesServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiDrivingLicensesServices.MergeIndex = 0;
            this.tsmiDrivingLicensesServices.Name = "tsmiDrivingLicensesServices";
            this.tsmiDrivingLicensesServices.Padding = new System.Windows.Forms.Padding(0);
            this.tsmiDrivingLicensesServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmiDrivingLicensesServices.Size = new System.Drawing.Size(368, 50);
            this.tsmiDrivingLicensesServices.Text = "       Driving Licenses Services";
            this.tsmiDrivingLicensesServices.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // cmsDrivingLicensesServices
            // 
            this.cmsDrivingLicensesServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmsDrivingLicensesServices.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.cmsDrivingLicensesServices.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cmsDrivingLicensesServices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmsDrivingLicensesServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewDrivingLicense,
            this.tsmiRenewDrivingLicense,
            this.toolStripSeparator4,
            this.tsmiReplacementLostOrDamaged,
            this.toolStripSeparator3,
            this.tsmiReleaseDetainLicense,
            this.tsmiRetakeTest});
            this.cmsDrivingLicensesServices.Name = "guna2ContextMenuStrip1";
            this.cmsDrivingLicensesServices.OwnerItem = this.tsmiDrivingLicensesServices;
            this.cmsDrivingLicensesServices.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsDrivingLicensesServices.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsDrivingLicensesServices.RenderStyle.ColorTable = null;
            this.cmsDrivingLicensesServices.RenderStyle.RoundedEdges = true;
            this.cmsDrivingLicensesServices.RenderStyle.SelectionArrowColor = System.Drawing.SystemColors.GrayText;
            this.cmsDrivingLicensesServices.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsDrivingLicensesServices.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsDrivingLicensesServices.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsDrivingLicensesServices.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmsDrivingLicensesServices.Size = new System.Drawing.Size(461, 195);
            // 
            // tsmiNewDrivingLicense
            // 
            this.tsmiNewDrivingLicense.AutoSize = false;
            this.tsmiNewDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmiNewDrivingLicense.DropDown = this.cmbNewDrivingLicense;
            this.tsmiNewDrivingLicense.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiNewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNewDrivingLicense.Image")));
            this.tsmiNewDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiNewDrivingLicense.MergeIndex = 0;
            this.tsmiNewDrivingLicense.Name = "tsmiNewDrivingLicense";
            this.tsmiNewDrivingLicense.Padding = new System.Windows.Forms.Padding(0);
            this.tsmiNewDrivingLicense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmiNewDrivingLicense.Size = new System.Drawing.Size(460, 35);
            this.tsmiNewDrivingLicense.Text = "       New Driving License";
            this.tsmiNewDrivingLicense.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // cmbNewDrivingLicense
            // 
            this.cmbNewDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmbNewDrivingLicense.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbNewDrivingLicense.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cmbNewDrivingLicense.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbNewDrivingLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalLicense,
            this.tsmiGlobalLicense});
            this.cmbNewDrivingLicense.Name = "guna2ContextMenuStrip1";
            this.cmbNewDrivingLicense.OwnerItem = this.tsmiNewDrivingLicense;
            this.cmbNewDrivingLicense.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmbNewDrivingLicense.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbNewDrivingLicense.RenderStyle.ColorTable = null;
            this.cmbNewDrivingLicense.RenderStyle.RoundedEdges = true;
            this.cmbNewDrivingLicense.RenderStyle.SelectionArrowColor = System.Drawing.SystemColors.GrayText;
            this.cmbNewDrivingLicense.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbNewDrivingLicense.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmbNewDrivingLicense.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmbNewDrivingLicense.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbNewDrivingLicense.Size = new System.Drawing.Size(222, 64);
            // 
            // tsmiLocalLicense
            // 
            this.tsmiLocalLicense.AutoSize = false;
            this.tsmiLocalLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmiLocalLicense.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLocalLicense.Image = global::DVDL.Properties.Resources.Local;
            this.tsmiLocalLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiLocalLicense.MergeIndex = 0;
            this.tsmiLocalLicense.Name = "tsmiLocalLicense";
            this.tsmiLocalLicense.Padding = new System.Windows.Forms.Padding(0);
            this.tsmiLocalLicense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmiLocalLicense.Size = new System.Drawing.Size(460, 30);
            this.tsmiLocalLicense.Text = "       Local License";
            this.tsmiLocalLicense.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmiLocalLicense.Click += new System.EventHandler(this.tsmiLocalLicense_Click);
            // 
            // tsmiGlobalLicense
            // 
            this.tsmiGlobalLicense.AutoSize = false;
            this.tsmiGlobalLicense.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiGlobalLicense.Image = global::DVDL.Properties.Resources.Global;
            this.tsmiGlobalLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiGlobalLicense.Name = "tsmiGlobalLicense";
            this.tsmiGlobalLicense.Size = new System.Drawing.Size(460, 30);
            this.tsmiGlobalLicense.Text = "       Global License";
            this.tsmiGlobalLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmiRenewDrivingLicense
            // 
            this.tsmiRenewDrivingLicense.AutoSize = false;
            this.tsmiRenewDrivingLicense.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tsmiRenewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRenewDrivingLicense.Image")));
            this.tsmiRenewDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiRenewDrivingLicense.Name = "tsmiRenewDrivingLicense";
            this.tsmiRenewDrivingLicense.Size = new System.Drawing.Size(460, 35);
            this.tsmiRenewDrivingLicense.Text = "       Renew Driving License";
            this.tsmiRenewDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(457, 10);
            // 
            // tsmiReplacementLostOrDamaged
            // 
            this.tsmiReplacementLostOrDamaged.AutoSize = false;
            this.tsmiReplacementLostOrDamaged.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tsmiReplacementLostOrDamaged.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReplacementLostOrDamaged.Image")));
            this.tsmiReplacementLostOrDamaged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiReplacementLostOrDamaged.Name = "tsmiReplacementLostOrDamaged";
            this.tsmiReplacementLostOrDamaged.Size = new System.Drawing.Size(460, 35);
            this.tsmiReplacementLostOrDamaged.Text = "       Replacement for Lost or Damaged License ";
            this.tsmiReplacementLostOrDamaged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(457, 6);
            // 
            // tsmiReleaseDetainLicense
            // 
            this.tsmiReleaseDetainLicense.AutoSize = false;
            this.tsmiReleaseDetainLicense.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tsmiReleaseDetainLicense.Image = global::DVDL.Properties.Resources.Release;
            this.tsmiReleaseDetainLicense.Name = "tsmiReleaseDetainLicense";
            this.tsmiReleaseDetainLicense.Size = new System.Drawing.Size(460, 35);
            this.tsmiReleaseDetainLicense.Text = "       Release Detain Driving License";
            // 
            // tsmiRetakeTest
            // 
            this.tsmiRetakeTest.AutoSize = false;
            this.tsmiRetakeTest.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tsmiRetakeTest.Image = global::DVDL.Properties.Resources.RetakeTest;
            this.tsmiRetakeTest.Name = "tsmiRetakeTest";
            this.tsmiRetakeTest.Size = new System.Drawing.Size(460, 35);
            this.tsmiRetakeTest.Text = "       Retake Test";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(365, 15);
            // 
            // tsmiManageApplications
            // 
            this.tsmiManageApplications.AutoSize = false;
            this.tsmiManageApplications.DropDown = this.cmbManageApplications;
            this.tsmiManageApplications.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tsmiManageApplications.Image = global::DVDL.Properties.Resources.ManageApplications;
            this.tsmiManageApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiManageApplications.Name = "tsmiManageApplications";
            this.tsmiManageApplications.Size = new System.Drawing.Size(368, 50);
            this.tsmiManageApplications.Text = "       Manage Applications";
            this.tsmiManageApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbManageApplications
            // 
            this.cmbManageApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmbManageApplications.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.cmbManageApplications.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cmbManageApplications.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbManageApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalApplications,
            this.tsmiGlobalApplications,
            this.toolStripSeparator6});
            this.cmbManageApplications.Name = "guna2ContextMenuStrip1";
            this.cmbManageApplications.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmbManageApplications.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbManageApplications.RenderStyle.ColorTable = null;
            this.cmbManageApplications.RenderStyle.RoundedEdges = true;
            this.cmbManageApplications.RenderStyle.SelectionArrowColor = System.Drawing.SystemColors.GrayText;
            this.cmbManageApplications.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbManageApplications.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmbManageApplications.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmbManageApplications.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbManageApplications.Size = new System.Drawing.Size(401, 80);
            // 
            // tsmiLocalApplications
            // 
            this.tsmiLocalApplications.AutoSize = false;
            this.tsmiLocalApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmiLocalApplications.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLocalApplications.Image = global::DVDL.Properties.Resources.LocalApplicatoins;
            this.tsmiLocalApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiLocalApplications.MergeIndex = 0;
            this.tsmiLocalApplications.Name = "tsmiLocalApplications";
            this.tsmiLocalApplications.Padding = new System.Windows.Forms.Padding(0);
            this.tsmiLocalApplications.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmiLocalApplications.Size = new System.Drawing.Size(460, 35);
            this.tsmiLocalApplications.Text = "       Local Driving License Applications";
            this.tsmiLocalApplications.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmiLocalApplications.Click += new System.EventHandler(this.tsmiLocalApplications_Click);
            // 
            // tsmiGlobalApplications
            // 
            this.tsmiGlobalApplications.AutoSize = false;
            this.tsmiGlobalApplications.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tsmiGlobalApplications.Image = global::DVDL.Properties.Resources.GlobalApplicatinos;
            this.tsmiGlobalApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiGlobalApplications.Name = "tsmiGlobalApplications";
            this.tsmiGlobalApplications.Size = new System.Drawing.Size(460, 35);
            this.tsmiGlobalApplications.Text = "       Global Driving License Applications";
            this.tsmiGlobalApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(397, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(365, 15);
            // 
            // tsmiDetainLicense
            // 
            this.tsmiDetainLicense.AutoSize = false;
            this.tsmiDetainLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tsmiDetainLicense.Image = global::DVDL.Properties.Resources.DetainCard;
            this.tsmiDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiDetainLicense.Name = "tsmiDetainLicense";
            this.tsmiDetainLicense.Size = new System.Drawing.Size(368, 50);
            this.tsmiDetainLicense.Text = "       Detain Licenses";
            this.tsmiDetainLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmiDetainLicense.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // tsmiManageApplicationsTypes
            // 
            this.tsmiManageApplicationsTypes.AutoSize = false;
            this.tsmiManageApplicationsTypes.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tsmiManageApplicationsTypes.Image = global::DVDL.Properties.Resources.ManageApplicationsTypes;
            this.tsmiManageApplicationsTypes.Name = "tsmiManageApplicationsTypes";
            this.tsmiManageApplicationsTypes.Size = new System.Drawing.Size(368, 50);
            this.tsmiManageApplicationsTypes.Text = "       Manage Applications Types";
            this.tsmiManageApplicationsTypes.Click += new System.EventHandler(this.tsmiManageApplicationsTypes_Click);
            // 
            // tsmiManageTestTypes
            // 
            this.tsmiManageTestTypes.AutoSize = false;
            this.tsmiManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tsmiManageTestTypes.Image = global::DVDL.Properties.Resources.ManageTestTypes;
            this.tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            this.tsmiManageTestTypes.Size = new System.Drawing.Size(368, 50);
            this.tsmiManageTestTypes.Text = "       Manage Test Types";
            this.tsmiManageTestTypes.Click += new System.EventHandler(this.tsmiManageTestTypes_Click);
            // 
            // tsmPeople
            // 
            this.tsmPeople.AutoSize = false;
            this.tsmPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmPeople.CheckOnClick = true;
            this.tsmPeople.DoubleClickEnabled = true;
            this.tsmPeople.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmPeople.Image = ((System.Drawing.Image)(resources.GetObject("tsmPeople.Image")));
            this.tsmPeople.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmPeople.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmPeople.MergeIndex = 0;
            this.tsmPeople.Name = "tsmPeople";
            this.tsmPeople.Padding = new System.Windows.Forms.Padding(0);
            this.tsmPeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmPeople.Size = new System.Drawing.Size(219, 114);
            this.tsmPeople.Text = "People";
            this.tsmPeople.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmPeople.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmPeople.Click += new System.EventHandler(this.tsmPeople_Click);
            // 
            // tsmDrivers
            // 
            this.tsmDrivers.AutoSize = false;
            this.tsmDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmDrivers.CheckOnClick = true;
            this.tsmDrivers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmDrivers.Image = ((System.Drawing.Image)(resources.GetObject("tsmDrivers.Image")));
            this.tsmDrivers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmDrivers.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmDrivers.MergeIndex = 0;
            this.tsmDrivers.Name = "tsmDrivers";
            this.tsmDrivers.Padding = new System.Windows.Forms.Padding(0);
            this.tsmDrivers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmDrivers.Size = new System.Drawing.Size(219, 114);
            this.tsmDrivers.Text = "Drivers";
            this.tsmDrivers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmDrivers.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmDrivers.Click += new System.EventHandler(this.tsmDrivers_Click);
            // 
            // tsmUsers
            // 
            this.tsmUsers.AutoSize = false;
            this.tsmUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmUsers.CheckOnClick = true;
            this.tsmUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsmUsers.Image")));
            this.tsmUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmUsers.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmUsers.MergeIndex = 0;
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Padding = new System.Windows.Forms.Padding(0);
            this.tsmUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmUsers.Size = new System.Drawing.Size(219, 114);
            this.tsmUsers.Text = "Users";
            this.tsmUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmUsers.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmUsers.Click += new System.EventHandler(this.tsmUsers_Click);
            // 
            // tsmSettings
            // 
            this.tsmSettings.AutoSize = false;
            this.tsmSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmSettings.CheckOnClick = true;
            this.tsmSettings.DropDown = this.cmsSettings;
            this.tsmSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tsmSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsmSettings.Image")));
            this.tsmSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmSettings.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Padding = new System.Windows.Forms.Padding(0);
            this.tsmSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmSettings.Size = new System.Drawing.Size(219, 114);
            this.tsmSettings.Text = "Settings";
            this.tsmSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmSettings.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmSettings.Click += new System.EventHandler(this.tsmSettings_Click);
            // 
            // cmsSettings
            // 
            this.cmsSettings.AutoSize = false;
            this.cmsSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cmsSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMyInfo,
            this.tsmChangePassword,
            this.toolStripMenuItem1,
            this.tsmSignOut});
            this.cmsSettings.Name = "guna2ContextMenuStrip1";
            this.cmsSettings.OwnerItem = this.tsmSettings;
            this.cmsSettings.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsSettings.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsSettings.RenderStyle.ColorTable = null;
            this.cmsSettings.RenderStyle.RoundedEdges = true;
            this.cmsSettings.RenderStyle.SelectionArrowColor = System.Drawing.SystemColors.GrayText;
            this.cmsSettings.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsSettings.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsSettings.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsSettings.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmsSettings.Size = new System.Drawing.Size(240, 165);
            // 
            // tsmMyInfo
            // 
            this.tsmMyInfo.AutoSize = false;
            this.tsmMyInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tsmMyInfo.Image = global::DVDL.Properties.Resources.userInfo;
            this.tsmMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmMyInfo.Name = "tsmMyInfo";
            this.tsmMyInfo.Padding = new System.Windows.Forms.Padding(0);
            this.tsmMyInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmMyInfo.Size = new System.Drawing.Size(250, 50);
            this.tsmMyInfo.Text = "       My Information";
            this.tsmMyInfo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmMyInfo.Click += new System.EventHandler(this.tsmMyInfo_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.AutoSize = false;
            this.tsmChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tsmChangePassword.Image = global::DVDL.Properties.Resources.passwordReset;
            this.tsmChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(250, 50);
            this.tsmChangePassword.Text = "       Change Password";
            this.tsmChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.AutoSize = false;
            this.tsmSignOut.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tsmSignOut.Image = global::DVDL.Properties.Resources.signOut;
            this.tsmSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(250, 50);
            this.tsmSignOut.Text = "       Sign Out";
            this.tsmSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::DVDL.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClose.BorderRadius = 2;
            this.btnClose.BorderThickness = 2;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(1033, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Transparent;
            this.btnClose.Size = new System.Drawing.Size(73, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.btnMaximize);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlTopBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlTopBar.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlTopBar.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1106, 48);
            this.pnlTopBar.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::DVDL.Properties.Resources.Minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnMinimize.BorderRadius = 2;
            this.btnMinimize.BorderThickness = 2;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.IndicateFocus = true;
            this.btnMinimize.Location = new System.Drawing.Point(895, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Size = new System.Drawing.Size(65, 48);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Visible = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::DVDL.Properties.Resources.Square;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnMaximize.BorderRadius = 2;
            this.btnMaximize.BorderThickness = 2;
            this.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximize.IndicateFocus = true;
            this.btnMaximize.Location = new System.Drawing.Point(960, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.PressedColor = System.Drawing.Color.Empty;
            this.btnMaximize.Size = new System.Drawing.Size(73, 48);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 3;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xtraTabbedMdiManager1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.ForeColor = System.Drawing.Color.White;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.PageClient.BackColor = System.Drawing.Color.Black;
            this.xtraTabbedMdiManager1.AppearancePage.PageClient.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabbedMdiManager1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager1.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.OnMouseDown;
            this.xtraTabbedMdiManager1.FloatMDIChildDockDelay = 1000;
            this.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.HeaderButtons = DevExpress.XtraTab.TabButtons.None;
            this.xtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never;
            this.xtraTabbedMdiManager1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabbedMdiManager1.MaxTabPageWidth = 300;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabbedMdiManager1.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.PreviewPageZoomRatio = 0.25F;
            this.xtraTabbedMdiManager1.ShowFloatingDropHint = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageAdded);
            this.xtraTabbedMdiManager1.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageRemoved);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel1.Enabled = false;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 445);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1106, 29);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 588);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.msOptions);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msOptions;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.Resize += new System.EventHandler(this.frmMainScreen_Resize);
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.cmsApplications.ResumeLayout(false);
            this.cmsDrivingLicensesServices.ResumeLayout(false);
            this.cmbNewDrivingLicense.ResumeLayout(false);
            this.cmbManageApplications.ResumeLayout(false);
            this.cmsSettings.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmSettings;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTopBar;
        private Guna.UI2.WinForms.Guna2Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmMyInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivingLicensesServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplicationsTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewDrivingLicense;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsDrivingLicensesServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenewDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplacementLostOrDamaged;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiRetakeTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmbNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiGlobalLicense;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmbManageApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiGlobalApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

