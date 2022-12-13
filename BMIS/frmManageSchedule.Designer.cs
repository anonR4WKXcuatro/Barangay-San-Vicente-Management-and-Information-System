
namespace BMIS
{
    partial class frmManageSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddNewResident = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpSettlementTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtComplainantName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSettlementID = new System.Windows.Forms.TextBox();
            this.dtpSettlementDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labels2 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBlotterNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSched = new Guna.UI2.WinForms.Guna2DataGridView();
            this.settlementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blotterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainant_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlement_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlement_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUMMON = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSched)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblAddNewResident);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 53);
            this.panel1.TabIndex = 1;
            // 
            // lblAddNewResident
            // 
            this.lblAddNewResident.AutoSize = true;
            this.lblAddNewResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewResident.ForeColor = System.Drawing.Color.White;
            this.lblAddNewResident.Location = new System.Drawing.Point(8, 17);
            this.lblAddNewResident.Name = "lblAddNewResident";
            this.lblAddNewResident.Size = new System.Drawing.Size(236, 20);
            this.lblAddNewResident.TabIndex = 12;
            this.lblAddNewResident.Text = "SETTLEMENT SCHEDULE";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(892, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SETTLEMENT DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpSettlementTime);
            this.panel2.Controls.Add(this.txtComplainantName);
            this.panel2.Controls.Add(this.txtSettlementID);
            this.panel2.Controls.Add(this.dtpSettlementDate);
            this.panel2.Controls.Add(this.labels2);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBlotterNo);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 185);
            this.panel2.TabIndex = 2;
            // 
            // dtpSettlementTime
            // 
            this.dtpSettlementTime.BackColor = System.Drawing.SystemColors.Control;
            this.dtpSettlementTime.BorderRadius = 15;
            this.dtpSettlementTime.Checked = true;
            this.dtpSettlementTime.CustomFormat = "hh:mm tt";
            this.dtpSettlementTime.FillColor = System.Drawing.Color.White;
            this.dtpSettlementTime.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpSettlementTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSettlementTime.Location = new System.Drawing.Point(705, 44);
            this.dtpSettlementTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSettlementTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSettlementTime.Name = "dtpSettlementTime";
            this.dtpSettlementTime.ShowUpDown = true;
            this.dtpSettlementTime.Size = new System.Drawing.Size(185, 43);
            this.dtpSettlementTime.TabIndex = 46;
            this.dtpSettlementTime.Value = new System.DateTime(2022, 1, 5, 14, 58, 7, 810);
            // 
            // txtComplainantName
            // 
            this.txtComplainantName.BorderRadius = 15;
            this.txtComplainantName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplainantName.DefaultText = "";
            this.txtComplainantName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComplainantName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComplainantName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComplainantName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComplainantName.FillColor = System.Drawing.Color.LightYellow;
            this.txtComplainantName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplainantName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComplainantName.ForeColor = System.Drawing.Color.Black;
            this.txtComplainantName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplainantName.Location = new System.Drawing.Point(341, 125);
            this.txtComplainantName.MaxLength = 17;
            this.txtComplainantName.Name = "txtComplainantName";
            this.txtComplainantName.PasswordChar = '\0';
            this.txtComplainantName.PlaceholderText = "";
            this.txtComplainantName.ReadOnly = true;
            this.txtComplainantName.SelectedText = "";
            this.txtComplainantName.Size = new System.Drawing.Size(310, 43);
            this.txtComplainantName.TabIndex = 45;
            // 
            // txtSettlementID
            // 
            this.txtSettlementID.Location = new System.Drawing.Point(892, 3);
            this.txtSettlementID.Name = "txtSettlementID";
            this.txtSettlementID.ReadOnly = true;
            this.txtSettlementID.Size = new System.Drawing.Size(23, 22);
            this.txtSettlementID.TabIndex = 44;
            this.txtSettlementID.Visible = false;
            // 
            // dtpSettlementDate
            // 
            this.dtpSettlementDate.BackColor = System.Drawing.SystemColors.Control;
            this.dtpSettlementDate.BorderRadius = 15;
            this.dtpSettlementDate.Checked = true;
            this.dtpSettlementDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpSettlementDate.FillColor = System.Drawing.Color.White;
            this.dtpSettlementDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpSettlementDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSettlementDate.Location = new System.Drawing.Point(399, 44);
            this.dtpSettlementDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSettlementDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSettlementDate.Name = "dtpSettlementDate";
            this.dtpSettlementDate.ShowUpDown = true;
            this.dtpSettlementDate.Size = new System.Drawing.Size(282, 43);
            this.dtpSettlementDate.TabIndex = 43;
            this.dtpSettlementDate.Value = new System.DateTime(2022, 1, 5, 14, 58, 7, 810);
            // 
            // labels2
            // 
            this.labels2.AutoSize = true;
            this.labels2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labels2.Location = new System.Drawing.Point(26, 24);
            this.labels2.Name = "labels2";
            this.labels2.Size = new System.Drawing.Size(94, 17);
            this.labels2.TabIndex = 42;
            this.labels2.Text = "FULL NAME";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderRadius = 19;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FillColor = System.Drawing.Color.LightGray;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::BMIS.Properties.Resources.icons8_edit_30;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.Location = new System.Drawing.Point(789, 127);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 41);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "    UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 19;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::BMIS.Properties.Resources.icons8_plus___30;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(657, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 41);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 15;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FillColor = System.Drawing.Color.LightYellow;
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(15, 44);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(369, 43);
            this.txtFullName.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(702, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "TIME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(405, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(358, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "COMPLAINANT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(26, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "BLOTTER ENTRY NO";
            // 
            // txtBlotterNo
            // 
            this.txtBlotterNo.BorderRadius = 15;
            this.txtBlotterNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBlotterNo.DefaultText = "";
            this.txtBlotterNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBlotterNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBlotterNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBlotterNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBlotterNo.FillColor = System.Drawing.Color.LightYellow;
            this.txtBlotterNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBlotterNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBlotterNo.ForeColor = System.Drawing.Color.Black;
            this.txtBlotterNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBlotterNo.Location = new System.Drawing.Point(15, 125);
            this.txtBlotterNo.MaxLength = 17;
            this.txtBlotterNo.Name = "txtBlotterNo";
            this.txtBlotterNo.PasswordChar = '\0';
            this.txtBlotterNo.PlaceholderText = "";
            this.txtBlotterNo.ReadOnly = true;
            this.txtBlotterNo.SelectedText = "";
            this.txtBlotterNo.Size = new System.Drawing.Size(320, 43);
            this.txtBlotterNo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "SETTLEMENT SCHEDULES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSched
            // 
            this.dgvSched.AllowUserToAddRows = false;
            this.dgvSched.AllowUserToDeleteRows = false;
            this.dgvSched.AllowUserToResizeColumns = false;
            this.dgvSched.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSched.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSched.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSched.BackgroundColor = System.Drawing.Color.White;
            this.dgvSched.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSched.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSched.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSched.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSched.ColumnHeadersHeight = 29;
            this.dgvSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSched.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.settlementID,
            this.blotterNo,
            this.fullname,
            this.complainant_name,
            this.settlement_date,
            this.settlement_time,
            this.SUMMON});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSched.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSched.EnableHeadersVisualStyles = false;
            this.dgvSched.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSched.Location = new System.Drawing.Point(12, 306);
            this.dgvSched.Name = "dgvSched";
            this.dgvSched.ReadOnly = true;
            this.dgvSched.RowHeadersVisible = false;
            this.dgvSched.RowHeadersWidth = 51;
            this.dgvSched.RowTemplate.Height = 24;
            this.dgvSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSched.Size = new System.Drawing.Size(920, 220);
            this.dgvSched.TabIndex = 43;
            this.dgvSched.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSched.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSched.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSched.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSched.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSched.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSched.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSched.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.dgvSched.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSched.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSched.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSched.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSched.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvSched.ThemeStyle.ReadOnly = true;
            this.dgvSched.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSched.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSched.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSched.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSched.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSched.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSched.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSched.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSched_CellContentClick);
            // 
            // settlementID
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementID.DefaultCellStyle = dataGridViewCellStyle3;
            this.settlementID.HeaderText = "ID";
            this.settlementID.MinimumWidth = 6;
            this.settlementID.Name = "settlementID";
            this.settlementID.ReadOnly = true;
            this.settlementID.Visible = false;
            // 
            // blotterNo
            // 
            this.blotterNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blotterNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.blotterNo.HeaderText = "BLOTTER NO";
            this.blotterNo.MinimumWidth = 6;
            this.blotterNo.Name = "blotterNo";
            this.blotterNo.ReadOnly = true;
            this.blotterNo.Width = 139;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.DefaultCellStyle = dataGridViewCellStyle5;
            this.fullname.HeaderText = "FULL NAME";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 131;
            // 
            // complainant_name
            // 
            this.complainant_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainant_name.DefaultCellStyle = dataGridViewCellStyle6;
            this.complainant_name.HeaderText = "COMPLAINANT";
            this.complainant_name.MinimumWidth = 6;
            this.complainant_name.Name = "complainant_name";
            this.complainant_name.ReadOnly = true;
            this.complainant_name.Width = 163;
            // 
            // settlement_date
            // 
            this.settlement_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlement_date.DefaultCellStyle = dataGridViewCellStyle7;
            this.settlement_date.HeaderText = "DATE";
            this.settlement_date.MinimumWidth = 6;
            this.settlement_date.Name = "settlement_date";
            this.settlement_date.ReadOnly = true;
            this.settlement_date.Width = 81;
            // 
            // settlement_time
            // 
            this.settlement_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlement_time.DefaultCellStyle = dataGridViewCellStyle8;
            this.settlement_time.HeaderText = "TIME";
            this.settlement_time.MinimumWidth = 6;
            this.settlement_time.Name = "settlement_time";
            this.settlement_time.ReadOnly = true;
            this.settlement_time.Width = 78;
            // 
            // SUMMON
            // 
            this.SUMMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUMMON.DefaultCellStyle = dataGridViewCellStyle9;
            this.SUMMON.HeaderText = "";
            this.SUMMON.MinimumWidth = 6;
            this.SUMMON.Name = "SUMMON";
            this.SUMMON.ReadOnly = true;
            this.SUMMON.Text = "SUMMON";
            this.SUMMON.UseColumnTextForButtonValue = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(672, 286);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(260, 17);
            this.label18.TabIndex = 46;
            this.label18.Text = "(Select a row below to update schedule)";
            // 
            // frmManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(944, 529);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dgvSched);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageSchedule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddNewResident;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtBlotterNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labels2;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSettlementDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSched;
        private System.Windows.Forms.TextBox txtSettlementID;
        private Guna.UI2.WinForms.Guna2TextBox txtComplainantName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn blotterNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainant_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlement_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlement_time;
        private System.Windows.Forms.DataGridViewButtonColumn SUMMON;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSettlementTime;
    }
}