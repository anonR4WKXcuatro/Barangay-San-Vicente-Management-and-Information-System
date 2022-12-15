
namespace BMIS
{
    partial class frmCertifications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboClearanceType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvClearanceLogs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.orNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clr_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearance_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearance_purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckRecord = new Guna.UI2.WinForms.Guna2Button();
            this.txtResidentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRecordStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClearanceLogs)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboClearanceType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 79);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::BMIS.Properties.Resources.icons8_sync_30;
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefresh.Location = new System.Drawing.Point(440, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 79);
            this.btnRefresh.TabIndex = 53;
            this.btnRefresh.Text = "   REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 30, 5, 22);
            this.label5.Size = new System.Drawing.Size(431, 79);
            this.label5.TabIndex = 10;
            this.label5.Text = "CLEARANCE AND CERTIFICATIONS";
            // 
            // cboClearanceType
            // 
            this.cboClearanceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboClearanceType.BackColor = System.Drawing.Color.Transparent;
            this.cboClearanceType.BorderRadius = 15;
            this.cboClearanceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboClearanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClearanceType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboClearanceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboClearanceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboClearanceType.ForeColor = System.Drawing.Color.Black;
            this.cboClearanceType.ItemHeight = 25;
            this.cboClearanceType.Items.AddRange(new object[] {
            "- SELECT CLEARANCE -",
            "BARANGAY CLEARANCE",
            "CERTIFICATE OF RESIDENCY",
            "INDIGENCY",
            "BARANGAY BUSINESS CLEARANCE"});
            this.cboClearanceType.Location = new System.Drawing.Point(597, 21);
            this.cboClearanceType.Name = "cboClearanceType";
            this.cboClearanceType.Size = new System.Drawing.Size(356, 31);
            this.cboClearanceType.StartIndex = 0;
            this.cboClearanceType.TabIndex = 52;
            this.cboClearanceType.SelectedIndexChanged += new System.EventHandler(this.cboClearanceType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CHECK RESIDENT RECORD";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(410, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 17);
            this.label18.TabIndex = 46;
            this.label18.Text = "(Search by ID)";
            // 
            // dgvClearanceLogs
            // 
            this.dgvClearanceLogs.AllowUserToAddRows = false;
            this.dgvClearanceLogs.AllowUserToDeleteRows = false;
            this.dgvClearanceLogs.AllowUserToResizeColumns = false;
            this.dgvClearanceLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            this.dgvClearanceLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvClearanceLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClearanceLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClearanceLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClearanceLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvClearanceLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClearanceLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClearanceLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClearanceLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvClearanceLogs.ColumnHeadersHeight = 29;
            this.dgvClearanceLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClearanceLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orNumber,
            this.clr_fname,
            this.clearance_type,
            this.clearance_purpose,
            this.clr_date});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClearanceLogs.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvClearanceLogs.EnableHeadersVisualStyles = false;
            this.dgvClearanceLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClearanceLogs.Location = new System.Drawing.Point(0, 248);
            this.dgvClearanceLogs.MultiSelect = false;
            this.dgvClearanceLogs.Name = "dgvClearanceLogs";
            this.dgvClearanceLogs.ReadOnly = true;
            this.dgvClearanceLogs.RowHeadersVisible = false;
            this.dgvClearanceLogs.RowHeadersWidth = 51;
            this.dgvClearanceLogs.RowTemplate.Height = 24;
            this.dgvClearanceLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClearanceLogs.Size = new System.Drawing.Size(1174, 505);
            this.dgvClearanceLogs.TabIndex = 51;
            this.dgvClearanceLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClearanceLogs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClearanceLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClearanceLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClearanceLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClearanceLogs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClearanceLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClearanceLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.dgvClearanceLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClearanceLogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClearanceLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClearanceLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClearanceLogs.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvClearanceLogs.ThemeStyle.ReadOnly = true;
            this.dgvClearanceLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClearanceLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClearanceLogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClearanceLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClearanceLogs.ThemeStyle.RowsStyle.Height = 24;
            this.dgvClearanceLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClearanceLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // orNumber
            // 
            this.orNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orNumber.DefaultCellStyle = dataGridViewCellStyle31;
            this.orNumber.HeaderText = "OR NO";
            this.orNumber.MinimumWidth = 6;
            this.orNumber.Name = "orNumber";
            this.orNumber.ReadOnly = true;
            // 
            // clr_fname
            // 
            this.clr_fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_fname.DefaultCellStyle = dataGridViewCellStyle32;
            this.clr_fname.HeaderText = "NAME OF RESIDENT";
            this.clr_fname.MinimumWidth = 6;
            this.clr_fname.Name = "clr_fname";
            this.clr_fname.ReadOnly = true;
            this.clr_fname.Width = 201;
            // 
            // clearance_type
            // 
            this.clearance_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearance_type.DefaultCellStyle = dataGridViewCellStyle33;
            this.clearance_type.HeaderText = "TYPE";
            this.clearance_type.MinimumWidth = 6;
            this.clearance_type.Name = "clearance_type";
            this.clearance_type.ReadOnly = true;
            this.clearance_type.Width = 77;
            // 
            // clearance_purpose
            // 
            this.clearance_purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearance_purpose.DefaultCellStyle = dataGridViewCellStyle34;
            this.clearance_purpose.HeaderText = "PURPOSE";
            this.clearance_purpose.MinimumWidth = 6;
            this.clearance_purpose.Name = "clearance_purpose";
            this.clearance_purpose.ReadOnly = true;
            this.clearance_purpose.Width = 115;
            // 
            // clr_date
            // 
            this.clr_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clr_date.HeaderText = "DATE";
            this.clr_date.MinimumWidth = 6;
            this.clr_date.Name = "clr_date";
            this.clr_date.ReadOnly = true;
            this.clr_date.Width = 81;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "LIST OF ISSUED CLEARANCE AND CERTIFICATIONS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 32);
            this.panel2.TabIndex = 54;
            // 
            // btnIssue
            // 
            this.btnIssue.AutoRoundedCorners = true;
            this.btnIssue.BorderRadius = 20;
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Image = global::BMIS.Properties.Resources.icons8_edit_file_30;
            this.btnIssue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIssue.Location = new System.Drawing.Point(673, 140);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(126, 43);
            this.btnIssue.TabIndex = 49;
            this.btnIssue.Text = " ISSUE";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnCheckRecord
            // 
            this.btnCheckRecord.AutoRoundedCorners = true;
            this.btnCheckRecord.BorderRadius = 20;
            this.btnCheckRecord.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnCheckRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckRecord.ForeColor = System.Drawing.Color.White;
            this.btnCheckRecord.Image = global::BMIS.Properties.Resources.icons8_radar_30;
            this.btnCheckRecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckRecord.Location = new System.Drawing.Point(541, 140);
            this.btnCheckRecord.Name = "btnCheckRecord";
            this.btnCheckRecord.Size = new System.Drawing.Size(126, 43);
            this.btnCheckRecord.TabIndex = 48;
            this.btnCheckRecord.Text = " SCAN";
            this.btnCheckRecord.Click += new System.EventHandler(this.btnCheckRecord_Click);
            // 
            // txtResidentID
            // 
            this.txtResidentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtResidentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtResidentID.BorderRadius = 15;
            this.txtResidentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResidentID.DefaultText = "";
            this.txtResidentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResidentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtResidentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResidentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResidentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResidentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResidentID.ForeColor = System.Drawing.Color.Black;
            this.txtResidentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResidentID.IconRight = global::BMIS.Properties.Resources.icons8_search_15;
            this.txtResidentID.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtResidentID.Location = new System.Drawing.Point(12, 140);
            this.txtResidentID.Name = "txtResidentID";
            this.txtResidentID.PasswordChar = '\0';
            this.txtResidentID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtResidentID.PlaceholderText = "";
            this.txtResidentID.SelectedText = "";
            this.txtResidentID.Size = new System.Drawing.Size(508, 43);
            this.txtResidentID.TabIndex = 9;
            this.txtResidentID.TextChanged += new System.EventHandler(this.txtResidentName_TextChanged);
            // 
            // lblRecordStatus
            // 
            this.lblRecordStatus.AutoSize = true;
            this.lblRecordStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordStatus.ForeColor = System.Drawing.Color.Black;
            this.lblRecordStatus.Location = new System.Drawing.Point(12, 186);
            this.lblRecordStatus.Name = "lblRecordStatus";
            this.lblRecordStatus.Size = new System.Drawing.Size(79, 17);
            this.lblRecordStatus.TabIndex = 55;
            this.lblRecordStatus.Text = "[STATUS]";
            this.lblRecordStatus.Visible = false;
            // 
            // frmCertifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 753);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecordStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvClearanceLogs);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnCheckRecord);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtResidentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCertifications";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCertifications_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClearanceLogs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtResidentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2Button btnCheckRecord;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
        private Guna.UI2.WinForms.Guna2ComboBox cboClearanceType;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClearanceLogs;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clr_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clearance_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clearance_purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clr_date;
        private System.Windows.Forms.Label lblRecordStatus;
    }
}