namespace DVDL.Users
{
    partial class frmAddApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddApplication));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tabApplicatoinDetails = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnAddApplication = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlAddNewApplication = new DVDL.User_Controls.ctrlAddNewApplication();
            this.tabPersonDetails = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ctrlAddPerson = new DVDL.ctrlAddPerson();
            this.tabPane2 = new DevExpress.XtraBars.Navigation.TabPane();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.tabApplicatoinDetails.SuspendLayout();
            this.tabPersonDetails.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).BeginInit();
            this.tabPane2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 3;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.btnClose);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(981, 35);
            this.guna2CustomGradientPanel1.TabIndex = 36;
            // 
            // btnClose
            // 
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
            this.btnClose.Location = new System.Drawing.Point(917, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Transparent;
            this.btnClose.Size = new System.Drawing.Size(64, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(981, 45);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Add New Application";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // tabApplicatoinDetails
            // 
            this.tabApplicatoinDetails.Caption = "Applicatoin Details";
            this.tabApplicatoinDetails.Controls.Add(this.btnAddApplication);
            this.tabApplicatoinDetails.Controls.Add(this.ctrlAddNewApplication);
            this.tabApplicatoinDetails.Name = "tabApplicatoinDetails";
            this.tabApplicatoinDetails.Size = new System.Drawing.Size(981, 522);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApplication.BorderRadius = 5;
            this.btnAddApplication.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddApplication.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddApplication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddApplication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddApplication.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnAddApplication.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnAddApplication.ForeColor = System.Drawing.Color.White;
            this.btnAddApplication.IndicateFocus = true;
            this.btnAddApplication.Location = new System.Drawing.Point(412, 465);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(147, 45);
            this.btnAddApplication.TabIndex = 52;
            this.btnAddApplication.Text = "Add";
            this.btnAddApplication.UseTransparentBackground = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // ctrlAddNewApplication
            // 
            this.ctrlAddNewApplication.ApplicationID = "Application ID :  ???";
            this.ctrlAddNewApplication.Classes = 0;
            this.ctrlAddNewApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAddNewApplication.Fees = 0F;
            this.ctrlAddNewApplication.Location = new System.Drawing.Point(0, 0);
            this.ctrlAddNewApplication.Name = "ctrlAddNewApplication";
            this.ctrlAddNewApplication.Size = new System.Drawing.Size(981, 522);
            this.ctrlAddNewApplication.TabIndex = 53;
            this.ctrlAddNewApplication.Username = "";
            // 
            // tabPersonDetails
            // 
            this.tabPersonDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPersonDetails.Appearance.Options.UseFont = true;
            this.tabPersonDetails.Caption = "Person Details";
            this.tabPersonDetails.Controls.Add(this.btnAddPerson);
            this.tabPersonDetails.Controls.Add(this.guna2CustomGradientPanel5);
            this.tabPersonDetails.Controls.Add(this.ctrlAddPerson);
            this.tabPersonDetails.Name = "tabPersonDetails";
            this.tabPersonDetails.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPersonDetails.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabPersonDetails.Size = new System.Drawing.Size(981, 522);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BorderRadius = 5;
            this.btnAddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.IndicateFocus = true;
            this.btnAddPerson.Location = new System.Drawing.Point(413, 468);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(147, 45);
            this.btnAddPerson.TabIndex = 44;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseTransparentBackground = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2CustomGradientPanel5.Controls.Add(this.txtFilterBy);
            this.guna2CustomGradientPanel5.Controls.Add(this.cmbFilterBy);
            this.guna2CustomGradientPanel5.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.FillColor3 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(36, 19);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(257, 78);
            this.guna2CustomGradientPanel5.TabIndex = 39;
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Animated = true;
            this.txtFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterBy.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFilterBy.BorderRadius = 2;
            this.txtFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.DefaultText = "";
            this.txtFilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.txtFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterBy.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtFilterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterBy.Location = new System.Drawing.Point(0, 26);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterBy.MaxLength = 10;
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.ShadowDecoration.Depth = 15;
            this.txtFilterBy.ShadowDecoration.Enabled = true;
            this.txtFilterBy.Size = new System.Drawing.Size(257, 33);
            this.txtFilterBy.TabIndex = 35;
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterBy.BorderRadius = 2;
            this.cmbFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFilterBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cmbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterBy.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbFilterBy.ItemHeight = 20;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Filter By (None)",
            "Person ID",
            "Phone",
            "Email"});
            this.cmbFilterBy.Location = new System.Drawing.Point(0, 0);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(257, 26);
            this.cmbFilterBy.StartIndex = 0;
            this.cmbFilterBy.TabIndex = 32;
            this.cmbFilterBy.Tag = "FilterBy";
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // ctrlAddPerson
            // 
            this.ctrlAddPerson.Address = "";
            this.ctrlAddPerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlAddPerson.DateOfBirth = new System.DateTime(2006, 11, 10, 21, 16, 26, 924);
            this.ctrlAddPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAddPerson.Email = "";
            this.ctrlAddPerson.FirstName = "";
            this.ctrlAddPerson.Gender = ((byte)(2));
            this.ctrlAddPerson.ID = "ID : ";
            this.ctrlAddPerson.IsReadOnly = false;
            this.ctrlAddPerson.LastName = "";
            this.ctrlAddPerson.Location = new System.Drawing.Point(0, 0);
            this.ctrlAddPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAddPerson.Name = "ctrlAddPerson";
            this.ctrlAddPerson.Nationality = 0;
            this.ctrlAddPerson.NationalNo = "";
            this.ctrlAddPerson.PersonImagePath = "DVDL.Properties.Resources.person";
            this.ctrlAddPerson.Phone = "";
            this.ctrlAddPerson.SecondName = "";
            this.ctrlAddPerson.Size = new System.Drawing.Size(981, 522);
            this.ctrlAddPerson.TabIndex = 0;
            this.ctrlAddPerson.ThirdName = "";
            this.ctrlAddPerson.TitleImage = ((System.Drawing.Image)(resources.GetObject("ctrlAddPerson.TitleImage")));
            this.ctrlAddPerson.TitleLabel = "Person Details";
            // 
            // tabPane2
            // 
            this.tabPane2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPane2.Appearance.Options.UseFont = true;
            this.tabPane2.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPane2.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane2.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane2.AppearanceButton.Normal.Options.UseFont = true;
            this.tabPane2.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPane2.AppearanceButton.Pressed.Options.UseFont = true;
            this.tabPane2.Controls.Add(this.tabPersonDetails);
            this.tabPane2.Controls.Add(this.tabApplicatoinDetails);
            this.tabPane2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabPane2.Location = new System.Drawing.Point(0, 83);
            this.tabPane2.Name = "tabPane2";
            this.tabPane2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabPersonDetails,
            this.tabApplicatoinDetails});
            this.tabPane2.RegularSize = new System.Drawing.Size(981, 555);
            this.tabPane2.SelectedPage = this.tabPersonDetails;
            this.tabPane2.Size = new System.Drawing.Size(981, 555);
            this.tabPane2.TabIndex = 38;
            this.tabPane2.Text = "tabPane2";
            // 
            // frmAddApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 638);
            this.Controls.Add(this.tabPane2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTest";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.tabApplicatoinDetails.ResumeLayout(false);
            this.tabPersonDetails.ResumeLayout(false);
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).EndInit();
            this.tabPane2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPersonDetails;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterBy;
        private ctrlAddPerson ctrlAddPerson;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabApplicatoinDetails;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private Guna.UI2.WinForms.Guna2Button btnAddApplication;
        private User_Controls.ctrlAddNewApplication ctrlAddNewApplication;
    }
}