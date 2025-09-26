namespace DVDL.User_Controls
{
    partial class ctrlChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlChangePassword));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.epMissing = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuccessed = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epMissing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccessed)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
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
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Animated = true;
            this.txtCurrentPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtCurrentPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCurrentPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPassword.BorderRadius = 2;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.epError.SetIconPadding(this.txtCurrentPassword, 5);
            this.epSuccessed.SetIconPadding(this.txtCurrentPassword, 5);
            this.epMissing.SetIconPadding(this.txtCurrentPassword, 5);
            this.txtCurrentPassword.Location = new System.Drawing.Point(59, 44);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentPassword.MaxLength = 20;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '\0';
            this.txtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPassword.PlaceholderText = "Current Password";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.Size = new System.Drawing.Size(378, 43);
            this.txtCurrentPassword.TabIndex = 7;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            this.txtCurrentPassword.Validated += new System.EventHandler(this.txtCurrentPassword_Validated);
            // 
            // epMissing
            // 
            this.epMissing.BlinkRate = 600;
            this.epMissing.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.epMissing.ContainerControl = this;
            this.epMissing.Icon = ((System.Drawing.Icon)(resources.GetObject("epMissing.Icon")));
            this.epMissing.RightToLeft = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Animated = true;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.BorderRadius = 2;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.epError.SetIconPadding(this.txtConfirmPassword, 5);
            this.epSuccessed.SetIconPadding(this.txtConfirmPassword, 5);
            this.epMissing.SetIconPadding(this.txtConfirmPassword, 5);
            this.txtConfirmPassword.IconRight = global::DVDL.Properties.Resources.invisible;
            this.txtConfirmPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtConfirmPassword.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtConfirmPassword.IconRightSize = new System.Drawing.Size(22, 22);
            this.txtConfirmPassword.Location = new System.Drawing.Point(59, 162);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.MaxLength = 20;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(378, 43);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.Tag = "0";
            this.txtConfirmPassword.IconRightClick += new System.EventHandler(this.txtConfirmPassword_IconRightClick);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            this.txtConfirmPassword.Validated += new System.EventHandler(this.txtConfirmPassword_Validated);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Animated = true;
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.BorderRadius = 2;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.epError.SetIconPadding(this.txtNewPassword, 5);
            this.epSuccessed.SetIconPadding(this.txtNewPassword, 5);
            this.epMissing.SetIconPadding(this.txtNewPassword, 5);
            this.txtNewPassword.IconRight = global::DVDL.Properties.Resources.invisible;
            this.txtNewPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtNewPassword.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtNewPassword.IconRightSize = new System.Drawing.Size(22, 22);
            this.txtNewPassword.Location = new System.Drawing.Point(59, 103);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(378, 43);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.Tag = "0";
            this.txtNewPassword.IconRightClick += new System.EventHandler(this.txtNewPassword_IconRightClick);
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            this.txtNewPassword.Validated += new System.EventHandler(this.txtNewPassword_Validated);
            // 
            // epError
            // 
            this.epError.BlinkRate = 300;
            this.epError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.epError.ContainerControl = this;
            this.epError.Icon = ((System.Drawing.Icon)(resources.GetObject("epError.Icon")));
            this.epError.RightToLeft = true;
            // 
            // epSuccessed
            // 
            this.epSuccessed.BlinkRate = 900;
            this.epSuccessed.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.epSuccessed.ContainerControl = this;
            this.epSuccessed.Icon = ((System.Drawing.Icon)(resources.GetObject("epSuccessed.Icon")));
            // 
            // ctrlChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Name = "ctrlChangePassword";
            this.Size = new System.Drawing.Size(497, 278);
            ((System.ComponentModel.ISupportInitialize)(this.epMissing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuccessed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private System.Windows.Forms.ErrorProvider epMissing;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epSuccessed;
    }
}
