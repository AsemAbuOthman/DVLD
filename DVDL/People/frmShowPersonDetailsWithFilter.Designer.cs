namespace DVDL.People
{
    partial class frmShowPersonDetailsWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonDetailsWithFilter));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ctrlPersonDetails = new DVDL.ctrlAddPerson();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFilter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 3;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // ctrlPersonDetails
            // 
            this.ctrlPersonDetails.Address = "";
            this.ctrlPersonDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonDetails.DateOfBirth = new System.DateTime(2006, 10, 29, 23, 0, 13, 467);
            this.ctrlPersonDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonDetails.Email = "";
            this.ctrlPersonDetails.FirstName = "";
            this.ctrlPersonDetails.Gender = ((byte)(2));
            this.ctrlPersonDetails.ID = "ID : ";
            this.ctrlPersonDetails.IsReadOnly = false;
            this.ctrlPersonDetails.LastName = "";
            this.ctrlPersonDetails.Location = new System.Drawing.Point(0, 35);
            this.ctrlPersonDetails.Name = "ctrlPersonDetails";
            this.ctrlPersonDetails.Nationality = 0;
            this.ctrlPersonDetails.NationalNo = "National No. : ";
            this.ctrlPersonDetails.PersonImagePath = "DVDL.Properties.Resources.person";
            this.ctrlPersonDetails.Phone = "";
            this.ctrlPersonDetails.SecondName = "";
            this.ctrlPersonDetails.Size = new System.Drawing.Size(981, 524);
            this.ctrlPersonDetails.TabIndex = 36;
            this.ctrlPersonDetails.ThirdName = "";
            this.ctrlPersonDetails.TitleImage = ((System.Drawing.Image)(resources.GetObject("ctrlPersonDetails.TitleImage")));
            this.ctrlPersonDetails.TitleLabel = "Person Details";
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
            this.guna2CustomGradientPanel1.TabIndex = 35;
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
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlFilter.Controls.Add(this.txtFilterBy);
            this.pnlFilter.Controls.Add(this.cmbFilterBy);
            this.pnlFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlFilter.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlFilter.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlFilter.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlFilter.Location = new System.Drawing.Point(2, 41);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(257, 78);
            this.pnlFilter.TabIndex = 37;
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
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Gender",
            "Date of birth",
            "Nationality",
            "Phone",
            "Email"});
            this.cmbFilterBy.Location = new System.Drawing.Point(0, 0);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(257, 26);
            this.cmbFilterBy.StartIndex = 0;
            this.cmbFilterBy.TabIndex = 32;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BorderRadius = 5;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.IndicateFocus = true;
            this.btnAddUser.Location = new System.Drawing.Point(413, 503);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(147, 45);
            this.btnAddUser.TabIndex = 38;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseTransparentBackground = true;
            // 
            // frmShowPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 559);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.ctrlPersonDetails);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowPersonDetailsWithFilter";
            this.Text = "frmShowPersonDetailsWithFilter";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private ctrlAddPerson ctrlPersonDetails;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterBy;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
    }
}