namespace DVDL
{
    partial class ctrlUserDetails
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoNotActive = new Guna.UI2.WinForms.Guna2Button();
            this.rdoActive = new Guna.UI2.WinForms.Guna2Button();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.BorderRadius = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(258, 45);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Depth = 15;
            this.txtUsername.ShadowDecoration.Enabled = true;
            this.txtUsername.Size = new System.Drawing.Size(217, 43);
            this.txtUsername.TabIndex = 29;
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblUserID.Location = new System.Drawing.Point(40, 50);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(82, 32);
            this.lblUserID.TabIndex = 31;
            this.lblUserID.Text = "User ID : ";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.Transparent;
            this.gbStatus.BorderColor = System.Drawing.Color.DarkGray;
            this.gbStatus.BorderRadius = 2;
            this.gbStatus.Controls.Add(this.rdoNotActive);
            this.gbStatus.Controls.Add(this.rdoActive);
            this.gbStatus.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.gbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.gbStatus.Location = new System.Drawing.Point(499, 7);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.ShadowDecoration.Depth = 15;
            this.gbStatus.ShadowDecoration.Enabled = true;
            this.gbStatus.Size = new System.Drawing.Size(443, 109);
            this.gbStatus.TabIndex = 32;
            this.gbStatus.Text = "Status";
            // 
            // rdoNotActive
            // 
            this.rdoNotActive.Animated = true;
            this.rdoNotActive.AnimatedGIF = true;
            this.rdoNotActive.BackColor = System.Drawing.Color.Transparent;
            this.rdoNotActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdoNotActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rdoNotActive.BorderRadius = 2;
            this.rdoNotActive.BorderThickness = 2;
            this.rdoNotActive.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdoNotActive.CheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoNotActive.CheckedState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.rdoNotActive.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.rdoNotActive.CheckedState.Image = global::DVDL.Properties.Resources.On;
            this.rdoNotActive.DisabledState.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoNotActive.DisabledState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.rdoNotActive.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.rdoNotActive.FillColor = System.Drawing.Color.Empty;
            this.rdoNotActive.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.rdoNotActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdoNotActive.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoNotActive.Image = global::DVDL.Properties.Resources.Off;
            this.rdoNotActive.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rdoNotActive.ImageSize = new System.Drawing.Size(44, 44);
            this.rdoNotActive.IndicateFocus = true;
            this.rdoNotActive.Location = new System.Drawing.Point(232, 50);
            this.rdoNotActive.Name = "rdoNotActive";
            this.rdoNotActive.PressedColor = System.Drawing.SystemColors.Control;
            this.rdoNotActive.Size = new System.Drawing.Size(173, 51);
            this.rdoNotActive.TabIndex = 35;
            this.rdoNotActive.Tag = "false";
            this.rdoNotActive.Text = "Not Active";
            this.rdoNotActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rdoNotActive.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.rdoNotActive.UseTransparentBackground = true;
            // 
            // rdoActive
            // 
            this.rdoActive.Animated = true;
            this.rdoActive.AnimatedGIF = true;
            this.rdoActive.BackColor = System.Drawing.Color.Transparent;
            this.rdoActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdoActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rdoActive.BorderRadius = 2;
            this.rdoActive.BorderThickness = 2;
            this.rdoActive.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdoActive.CheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoActive.CheckedState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.rdoActive.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.rdoActive.CheckedState.Image = global::DVDL.Properties.Resources.On;
            this.rdoActive.DisabledState.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoActive.DisabledState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.rdoActive.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.rdoActive.FillColor = System.Drawing.Color.Empty;
            this.rdoActive.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.rdoActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdoActive.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoActive.Image = global::DVDL.Properties.Resources.Off;
            this.rdoActive.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rdoActive.ImageSize = new System.Drawing.Size(44, 44);
            this.rdoActive.IndicateFocus = true;
            this.rdoActive.Location = new System.Drawing.Point(50, 50);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.PressedColor = System.Drawing.SystemColors.Control;
            this.rdoActive.Size = new System.Drawing.Size(131, 51);
            this.rdoActive.TabIndex = 34;
            this.rdoActive.Tag = "true";
            this.rdoActive.Text = "Active";
            this.rdoActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rdoActive.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.rdoActive.UseTransparentBackground = true;
            // 
            // ctrlUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtUsername);
            this.Name = "ctrlUserDetails";
            this.Size = new System.Drawing.Size(981, 120);
            this.Load += new System.EventHandler(this.ucUserDetails_Load);
            this.gbStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserID;
        private Guna.UI2.WinForms.Guna2GroupBox gbStatus;
        private Guna.UI2.WinForms.Guna2Button rdoNotActive;
        private Guna.UI2.WinForms.Guna2Button rdoActive;
    }
}
