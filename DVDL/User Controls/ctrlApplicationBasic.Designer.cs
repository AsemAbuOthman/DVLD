namespace DVDL.User_Controls
{
    partial class ctrlApplicationBasic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApplicationID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblApplicationBasicInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnShowPerson = new Guna.UI2.WinForms.Guna2Button();
            this.txtCreatedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStatusDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApplicant = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblApplicationID.Location = new System.Drawing.Point(40, 74);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(146, 32);
            this.lblApplicationID.TabIndex = 55;
            this.lblApplicationID.Text = "Application ID : ";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblStatus.Location = new System.Drawing.Point(40, 125);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 32);
            this.lblStatus.TabIndex = 56;
            this.lblStatus.Text = "Status  :  ";
            // 
            // lblApplicationBasicInfo
            // 
            this.lblApplicationBasicInfo.AutoSize = false;
            this.lblApplicationBasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblApplicationBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApplicationBasicInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationBasicInfo.ForeColor = System.Drawing.Color.Red;
            this.lblApplicationBasicInfo.Location = new System.Drawing.Point(0, 0);
            this.lblApplicationBasicInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationBasicInfo.Name = "lblApplicationBasicInfo";
            this.lblApplicationBasicInfo.Size = new System.Drawing.Size(965, 43);
            this.lblApplicationBasicInfo.TabIndex = 63;
            this.lblApplicationBasicInfo.Text = "Application Basic Info";
            this.lblApplicationBasicInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowPerson
            // 
            this.btnShowPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPerson.BorderRadius = 5;
            this.btnShowPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnShowPerson.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnShowPerson.ForeColor = System.Drawing.Color.White;
            this.btnShowPerson.IndicateFocus = true;
            this.btnShowPerson.Location = new System.Drawing.Point(524, 273);
            this.btnShowPerson.Name = "btnShowPerson";
            this.btnShowPerson.Size = new System.Drawing.Size(402, 45);
            this.btnShowPerson.TabIndex = 64;
            this.btnShowPerson.Text = "Show Person Info";
            this.btnShowPerson.UseTransparentBackground = true;
            this.btnShowPerson.Click += new System.EventHandler(this.btnShowPerson_Click);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Animated = true;
            this.txtCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.txtCreatedBy.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCreatedBy.BorderRadius = 2;
            this.txtCreatedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreatedBy.DefaultText = "";
            this.txtCreatedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreatedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreatedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatedBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.txtCreatedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtCreatedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreatedBy.Location = new System.Drawing.Point(524, 169);
            this.txtCreatedBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PasswordChar = '\0';
            this.txtCreatedBy.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCreatedBy.PlaceholderText = "CreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.ShadowDecoration.Depth = 15;
            this.txtCreatedBy.ShadowDecoration.Enabled = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(402, 43);
            this.txtCreatedBy.TabIndex = 65;
            // 
            // dtpDate
            // 
            this.dtpDate.AllowDrop = true;
            this.dtpDate.Animated = true;
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BorderColor = System.Drawing.Color.DarkGray;
            this.dtpDate.BorderRadius = 2;
            this.dtpDate.BorderThickness = 1;
            this.dtpDate.Checked = true;
            this.dtpDate.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.dtpDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.dtpDate.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.dtpDate.Enabled = false;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtpDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(524, 74);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Depth = 15;
            this.dtpDate.ShadowDecoration.Enabled = true;
            this.dtpDate.Size = new System.Drawing.Size(402, 38);
            this.dtpDate.TabIndex = 66;
            this.dtpDate.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.dtpDate.Value = new System.DateTime(2024, 10, 27, 23, 9, 48, 713);
            // 
            // dtpStatusDate
            // 
            this.dtpStatusDate.AllowDrop = true;
            this.dtpStatusDate.Animated = true;
            this.dtpStatusDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpStatusDate.BorderColor = System.Drawing.Color.DarkGray;
            this.dtpStatusDate.BorderRadius = 2;
            this.dtpStatusDate.BorderThickness = 1;
            this.dtpStatusDate.Checked = true;
            this.dtpStatusDate.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.dtpStatusDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.dtpStatusDate.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.dtpStatusDate.Enabled = false;
            this.dtpStatusDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.dtpStatusDate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtpStatusDate.ForeColor = System.Drawing.Color.Black;
            this.dtpStatusDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStatusDate.Location = new System.Drawing.Point(524, 122);
            this.dtpStatusDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStatusDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpStatusDate.Name = "dtpStatusDate";
            this.dtpStatusDate.ShadowDecoration.Depth = 15;
            this.dtpStatusDate.ShadowDecoration.Enabled = true;
            this.dtpStatusDate.Size = new System.Drawing.Size(402, 37);
            this.dtpStatusDate.TabIndex = 67;
            this.dtpStatusDate.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.dtpStatusDate.Value = new System.DateTime(2024, 10, 27, 23, 9, 48, 713);
            // 
            // txtFees
            // 
            this.txtFees.Animated = true;
            this.txtFees.BackColor = System.Drawing.Color.Transparent;
            this.txtFees.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFees.BorderRadius = 2;
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.DefaultText = "$";
            this.txtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtFees.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtFees.IconRightSize = new System.Drawing.Size(22, 22);
            this.txtFees.Location = new System.Drawing.Point(40, 172);
            this.txtFees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFees.MaxLength = 5;
            this.txtFees.Name = "txtFees";
            this.txtFees.PasswordChar = '\0';
            this.txtFees.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFees.PlaceholderText = "Fees";
            this.txtFees.ReadOnly = true;
            this.txtFees.SelectedText = "";
            this.txtFees.ShadowDecoration.Depth = 15;
            this.txtFees.ShadowDecoration.Enabled = true;
            this.txtFees.Size = new System.Drawing.Size(402, 40);
            this.txtFees.TabIndex = 68;
            this.txtFees.Tag = "0";
            // 
            // txtType
            // 
            this.txtType.Animated = true;
            this.txtType.BackColor = System.Drawing.Color.Transparent;
            this.txtType.BorderColor = System.Drawing.Color.DarkGray;
            this.txtType.BorderRadius = 2;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.DefaultText = "";
            this.txtType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.Location = new System.Drawing.Point(40, 222);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtType.PlaceholderText = "Type";
            this.txtType.ReadOnly = true;
            this.txtType.SelectedText = "";
            this.txtType.ShadowDecoration.Depth = 15;
            this.txtType.ShadowDecoration.Enabled = true;
            this.txtType.Size = new System.Drawing.Size(402, 43);
            this.txtType.TabIndex = 69;
            // 
            // txtApplicant
            // 
            this.txtApplicant.Animated = true;
            this.txtApplicant.BackColor = System.Drawing.Color.Transparent;
            this.txtApplicant.BorderColor = System.Drawing.Color.DarkGray;
            this.txtApplicant.BorderRadius = 2;
            this.txtApplicant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApplicant.DefaultText = "";
            this.txtApplicant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApplicant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApplicant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApplicant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApplicant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.txtApplicant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApplicant.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtApplicant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApplicant.Location = new System.Drawing.Point(40, 275);
            this.txtApplicant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApplicant.Name = "txtApplicant";
            this.txtApplicant.PasswordChar = '\0';
            this.txtApplicant.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtApplicant.PlaceholderText = "Applicant";
            this.txtApplicant.ReadOnly = true;
            this.txtApplicant.SelectedText = "";
            this.txtApplicant.ShadowDecoration.Depth = 15;
            this.txtApplicant.ShadowDecoration.Enabled = true;
            this.txtApplicant.Size = new System.Drawing.Size(402, 43);
            this.txtApplicant.TabIndex = 70;
            // 
            // ctrlApplicationBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtApplicant);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.dtpStatusDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.btnShowPerson);
            this.Controls.Add(this.lblApplicationBasicInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblApplicationID);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "ctrlApplicationBasic";
            this.Size = new System.Drawing.Size(965, 334);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblApplicationID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApplicationBasicInfo;
        private Guna.UI2.WinForms.Guna2Button btnShowPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedBy;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStatusDate;
        private Guna.UI2.WinForms.Guna2TextBox txtFees;
        private Guna.UI2.WinForms.Guna2TextBox txtType;
        private Guna.UI2.WinForms.Guna2TextBox txtApplicant;
    }
}
