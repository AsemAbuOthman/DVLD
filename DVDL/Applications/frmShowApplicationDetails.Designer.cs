namespace DVDL.Applications
{
    partial class frmShowApplicationDetails
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbUsers = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ctrlDrivingLicesnseApplication1 = new DVDL.User_Controls.ctrlDrivingLicesnseApplication();
            this.ctrlApplicationBasic1 = new DVDL.User_Controls.ctrlApplicationBasic();
            this.ctrlAppointment1 = new DVDL.User_Controls.ctrlAppointment();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            this.guna2DragControl1.TransparentWhileDrag = false;
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
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1000, 35);
            this.guna2CustomGradientPanel1.TabIndex = 37;
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
            this.btnClose.Location = new System.Drawing.Point(936, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Transparent;
            this.btnClose.Size = new System.Drawing.Size(64, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 103);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 48);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Manage Application Types";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 181);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(965, 56);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = "Manage Application Types";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUsers
            // 
            this.pbUsers.BackColor = System.Drawing.Color.Transparent;
            this.pbUsers.BackgroundImage = global::DVDL.Properties.Resources.ManageApplicationsTypes;
            this.pbUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbUsers.FillColor = System.Drawing.Color.Transparent;
            this.pbUsers.ImageRotate = 0F;
            this.pbUsers.InitialImage = null;
            this.pbUsers.Location = new System.Drawing.Point(0, 35);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(1000, 68);
            this.pbUsers.TabIndex = 40;
            this.pbUsers.TabStop = false;
            // 
            // ctrlDrivingLicesnseApplication1
            // 
            this.ctrlDrivingLicesnseApplication1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlDrivingLicesnseApplication1.LicenseClass = "";
            this.ctrlDrivingLicesnseApplication1.Location = new System.Drawing.Point(0, 151);
            this.ctrlDrivingLicesnseApplication1.Name = "ctrlDrivingLicesnseApplication1";
            this.ctrlDrivingLicesnseApplication1.Size = new System.Drawing.Size(1000, 211);
            this.ctrlDrivingLicesnseApplication1.TabIndex = 1;
            // 
            // ctrlApplicationBasic1
            // 
            this.ctrlApplicationBasic1.Applicant = "";
            this.ctrlApplicationBasic1.CreatedBy = "";
            this.ctrlApplicationBasic1.Date = new System.DateTime(2024, 10, 27, 23, 9, 48, 713);
            this.ctrlApplicationBasic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlApplicationBasic1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctrlApplicationBasic1.Location = new System.Drawing.Point(0, 362);
            this.ctrlApplicationBasic1.Name = "ctrlApplicationBasic1";
            this.ctrlApplicationBasic1.Size = new System.Drawing.Size(1000, 339);
            this.ctrlApplicationBasic1.Status = "                                            ";
            this.ctrlApplicationBasic1.StatusDate = new System.DateTime(2024, 10, 27, 23, 9, 48, 713);
            this.ctrlApplicationBasic1.TabIndex = 0;
            this.ctrlApplicationBasic1.Type = "";
            // 
            // ctrlAppointment1
            // 
            this.ctrlAppointment1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlAppointment1.Location = new System.Drawing.Point(0, 701);
            this.ctrlAppointment1.Name = "ctrlAppointment1";
            this.ctrlAppointment1.Size = new System.Drawing.Size(1000, 253);
            this.ctrlAppointment1.TabIndex = 41;
            // 
            // frmShowApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 954);
            this.Controls.Add(this.ctrlApplicationBasic1);
            this.Controls.Add(this.ctrlAppointment1);
            this.Controls.Add(this.ctrlDrivingLicesnseApplication1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowApplicationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowApplicationDetails";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private User_Controls.ctrlApplicationBasic ctrlApplicationBasic1;
        private User_Controls.ctrlDrivingLicesnseApplication ctrlDrivingLicesnseApplication1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbUsers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private User_Controls.ctrlAppointment ctrlAppointment1;
    }
}