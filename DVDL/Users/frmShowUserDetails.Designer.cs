using System;

namespace DVDL
{
    partial class frmShowUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUserDetails));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditPersonInfo = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlUserDetails = new DVDL.ctrlUserDetails();
            this.ctrlPersonDetails = new DVDL.ctrlAddPerson();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditPersonInfo
            // 
            this.btnEditPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPersonInfo.BorderRadius = 5;
            this.btnEditPersonInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPersonInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditPersonInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditPersonInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditPersonInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnEditPersonInfo.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnEditPersonInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditPersonInfo.IndicateFocus = true;
            this.btnEditPersonInfo.Location = new System.Drawing.Point(405, 504);
            this.btnEditPersonInfo.Name = "btnEditPersonInfo";
            this.btnEditPersonInfo.Size = new System.Drawing.Size(160, 45);
            this.btnEditPersonInfo.TabIndex = 38;
            this.btnEditPersonInfo.Text = "Edit Person";
            this.btnEditPersonInfo.UseTransparentBackground = true;
            this.btnEditPersonInfo.Click += new System.EventHandler(this.btnEditPersonInfo_Click);
            // 
            // ctrlUserDetails
            // 
            this.ctrlUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ctrlUserDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlUserDetails.IsReadOnly = false;
            this.ctrlUserDetails.Location = new System.Drawing.Point(0, 555);
            this.ctrlUserDetails.Name = "ctrlUserDetails";
            this.ctrlUserDetails.Size = new System.Drawing.Size(981, 131);
            this.ctrlUserDetails.Status = false;
            this.ctrlUserDetails.TabIndex = 37;
            this.ctrlUserDetails.UserID = "User ID : ";
            this.ctrlUserDetails.Username = "";
            // 
            // ctrlPersonDetails
            // 
            this.ctrlPersonDetails.Address = "";
            this.ctrlPersonDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonDetails.DateOfBirth = new System.DateTime(2006, 10, 29, 23, 0, 13, 467);
            this.ctrlPersonDetails.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.ctrlPersonDetails.Size = new System.Drawing.Size(981, 461);
            this.ctrlPersonDetails.TabIndex = 36;
            this.ctrlPersonDetails.ThirdName = "";
            this.ctrlPersonDetails.TitleImage = ((System.Drawing.Image)(resources.GetObject("ctrlPersonDetails.TitleImage")));
            this.ctrlPersonDetails.TitleLabel = "Person Details";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 686);
            this.Controls.Add(this.btnEditPersonInfo);
            this.Controls.Add(this.ctrlUserDetails);
            this.Controls.Add(this.ctrlPersonDetails);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowUserDetails";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ctrlAddPerson ctrlPersonDetails;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private ctrlUserDetails ctrlUserDetails;
        private Guna.UI2.WinForms.Guna2Button btnEditPersonInfo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}