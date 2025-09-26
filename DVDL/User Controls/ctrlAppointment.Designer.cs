namespace DVDL.User_Controls
{
    partial class ctrlAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAppointments = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvShowLocalApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvcAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAppoinmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIsLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmAppointment = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAppointment = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLocalApplications)).BeginInit();
            this.cmAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = false;
            this.lblRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblRecords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecords.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRecords.Location = new System.Drawing.Point(0, 285);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(965, 31);
            this.lblRecords.TabIndex = 34;
            this.lblRecords.Text = "# Records : ";
            this.lblRecords.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = false;
            this.lblAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppointments.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.ForeColor = System.Drawing.Color.Red;
            this.lblAppointments.Location = new System.Drawing.Point(0, 0);
            this.lblAppointments.Margin = new System.Windows.Forms.Padding(0);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(965, 52);
            this.lblAppointments.TabIndex = 64;
            this.lblAppointments.Text = "Appointments";
            this.lblAppointments.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvShowLocalApplications
            // 
            this.dgvShowLocalApplications.AllowDrop = true;
            this.dgvShowLocalApplications.AllowUserToAddRows = false;
            this.dgvShowLocalApplications.AllowUserToDeleteRows = false;
            this.dgvShowLocalApplications.AllowUserToOrderColumns = true;
            this.dgvShowLocalApplications.AllowUserToResizeColumns = false;
            this.dgvShowLocalApplications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvShowLocalApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowLocalApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowLocalApplications.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowLocalApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowLocalApplications.ColumnHeadersHeight = 32;
            this.dgvShowLocalApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcAppointmentID,
            this.dgvcAppoinmentDate,
            this.dgvcPaidFees,
            this.dgvcIsLocked});
            this.dgvShowLocalApplications.ContextMenuStrip = this.cmAppointment;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowLocalApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowLocalApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowLocalApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.dgvShowLocalApplications.Location = new System.Drawing.Point(0, 52);
            this.dgvShowLocalApplications.Name = "dgvShowLocalApplications";
            this.dgvShowLocalApplications.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowLocalApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowLocalApplications.RowHeadersVisible = false;
            this.dgvShowLocalApplications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvShowLocalApplications.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowLocalApplications.Size = new System.Drawing.Size(965, 233);
            this.dgvShowLocalApplications.TabIndex = 66;
            this.dgvShowLocalApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowLocalApplications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShowLocalApplications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShowLocalApplications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShowLocalApplications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShowLocalApplications.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvShowLocalApplications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.dgvShowLocalApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvShowLocalApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShowLocalApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowLocalApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowLocalApplications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowLocalApplications.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvShowLocalApplications.ThemeStyle.ReadOnly = true;
            this.dgvShowLocalApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowLocalApplications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShowLocalApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowLocalApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowLocalApplications.ThemeStyle.RowsStyle.Height = 22;
            this.dgvShowLocalApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowLocalApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowLocalApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowLocalApplications_CellContentClick);
            // 
            // dgvcAppointmentID
            // 
            this.dgvcAppointmentID.HeaderText = "Appointment ID";
            this.dgvcAppointmentID.Name = "dgvcAppointmentID";
            this.dgvcAppointmentID.ReadOnly = true;
            // 
            // dgvcAppoinmentDate
            // 
            this.dgvcAppoinmentDate.HeaderText = "Appointment Date";
            this.dgvcAppoinmentDate.Name = "dgvcAppoinmentDate";
            this.dgvcAppoinmentDate.ReadOnly = true;
            // 
            // dgvcPaidFees
            // 
            this.dgvcPaidFees.HeaderText = "Paid Fees";
            this.dgvcPaidFees.Name = "dgvcPaidFees";
            this.dgvcPaidFees.ReadOnly = true;
            // 
            // dgvcIsLocked
            // 
            this.dgvcIsLocked.HeaderText = "Is Locked";
            this.dgvcIsLocked.Name = "dgvcIsLocked";
            this.dgvcIsLocked.ReadOnly = true;
            // 
            // cmAppointment
            // 
            this.cmAppointment.AutoSize = false;
            this.cmAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmAppointment.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmAppointment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.toolStripMenuItem3,
            this.tsmTakeTest});
            this.cmAppointment.Name = "guna2ContextMenuStrip1";
            this.cmAppointment.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmAppointment.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmAppointment.RenderStyle.ColorTable = null;
            this.cmAppointment.RenderStyle.RoundedEdges = true;
            this.cmAppointment.RenderStyle.SelectionArrowColor = System.Drawing.SystemColors.GrayText;
            this.cmAppointment.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmAppointment.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmAppointment.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmAppointment.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmAppointment.Size = new System.Drawing.Size(175, 100);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEdit.Image = global::DVDL.Properties.Resources.Edit;
            this.tsmEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(196, 38);
            this.tsmEdit.Tag = "0";
            this.tsmEdit.Text = "       Edit";
            this.tsmEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 6);
            // 
            // tsmTakeTest
            // 
            this.tsmTakeTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmTakeTest.Image = global::DVDL.Properties.Resources.TakeTest;
            this.tsmTakeTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmTakeTest.Name = "tsmTakeTest";
            this.tsmTakeTest.Size = new System.Drawing.Size(196, 38);
            this.tsmTakeTest.Text = "       Take Test";
            this.tsmTakeTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmTakeTest.Click += new System.EventHandler(this.tsmTakeTest_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.BackgroundImage = global::DVDL.Properties.Resources.AddAppointment;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppointment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnAddAppointment.BorderRadius = 2;
            this.btnAddAppointment.BorderThickness = 2;
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAppointment.FillColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddAppointment.IndicateFocus = true;
            this.btnAddAppointment.Location = new System.Drawing.Point(910, 0);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.ShadowDecoration.Depth = 1;
            this.btnAddAppointment.ShadowDecoration.Enabled = true;
            this.btnAddAppointment.Size = new System.Drawing.Size(47, 52);
            this.btnAddAppointment.TabIndex = 65;
            this.btnAddAppointment.Tag = "DVDL.Properties.Resources.person";
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // ctrlAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvShowLocalApplications);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.lblRecords);
            this.Name = "ctrlAppointment";
            this.Size = new System.Drawing.Size(965, 316);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLocalApplications)).EndInit();
            this.cmAppointment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppointments;
        private Guna.UI2.WinForms.Guna2Button btnAddAppointment;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowLocalApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAppoinmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPaidFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIsLocked;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmAppointment;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmTakeTest;
    }
}
