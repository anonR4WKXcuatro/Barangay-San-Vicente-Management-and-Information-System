
namespace BMIS
{
    partial class frmAddResident
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddResident));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddNewResident = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMotherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFatherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSuffix = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCamera = new System.Windows.Forms.Button();
            this.cboPurok = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboVoterStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboCivilStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContactNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOccupation = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMiddleInitial = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtReligion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtResidentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserImagePath = new System.Windows.Forms.TextBox();
            this.btnClearPic = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnBrowsePic = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picUserImage = new System.Windows.Forms.PictureBox();
            this.btnSaveInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(961, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblAddNewResident
            // 
            this.lblAddNewResident.AutoSize = true;
            this.lblAddNewResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewResident.ForeColor = System.Drawing.Color.White;
            this.lblAddNewResident.Location = new System.Drawing.Point(12, 17);
            this.lblAddNewResident.Name = "lblAddNewResident";
            this.lblAddNewResident.Size = new System.Drawing.Size(147, 20);
            this.lblAddNewResident.TabIndex = 22;
            this.lblAddNewResident.Text = "ADD RESIDENT";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(911, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 53);
            this.btnClose.TabIndex = 23;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txtMotherName);
            this.panel2.Controls.Add(this.txtFatherName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboSuffix);
            this.panel2.Controls.Add(this.btnCamera);
            this.panel2.Controls.Add(this.cboPurok);
            this.panel2.Controls.Add(this.cboVoterStatus);
            this.panel2.Controls.Add(this.cboCivilStatus);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.cboCategory);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtContactNo);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtNationality);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtOccupation);
            this.panel2.Controls.Add(this.dtpBirthDate);
            this.panel2.Controls.Add(this.txtMiddleInitial);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.cboSex);
            this.panel2.Controls.Add(this.txtReligion);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtResidentID);
            this.panel2.Controls.Add(this.txtUserImagePath);
            this.panel2.Controls.Add(this.btnClearPic);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.btnBrowsePic);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picUserImage);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 448);
            this.panel2.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(482, 203);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(136, 17);
            this.label23.TabIndex = 69;
            this.label23.Text = "MOTHER\'S NAME";
            // 
            // txtMotherName
            // 
            this.txtMotherName.BorderRadius = 15;
            this.txtMotherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotherName.DefaultText = "";
            this.txtMotherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotherName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotherName.ForeColor = System.Drawing.Color.Black;
            this.txtMotherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotherName.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtMotherName.Location = new System.Drawing.Point(485, 223);
            this.txtMotherName.MaxLength = 100;
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.PasswordChar = '\0';
            this.txtMotherName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMotherName.PlaceholderText = "";
            this.txtMotherName.SelectedText = "";
            this.txtMotherName.Size = new System.Drawing.Size(208, 45);
            this.txtMotherName.TabIndex = 10;
            this.txtMotherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotherName_KeyPress);
            // 
            // txtFatherName
            // 
            this.txtFatherName.BorderRadius = 15;
            this.txtFatherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFatherName.DefaultText = "";
            this.txtFatherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFatherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFatherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFatherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFatherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFatherName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFatherName.ForeColor = System.Drawing.Color.Black;
            this.txtFatherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFatherName.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtFatherName.Location = new System.Drawing.Point(259, 223);
            this.txtFatherName.MaxLength = 100;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.PasswordChar = '\0';
            this.txtFatherName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFatherName.PlaceholderText = "";
            this.txtFatherName.SelectedText = "";
            this.txtFatherName.Size = new System.Drawing.Size(210, 45);
            this.txtFatherName.TabIndex = 9;
            this.txtFatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFatherName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(259, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "FATHER\'S NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(601, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "(Optional)";
            // 
            // cboSuffix
            // 
            this.cboSuffix.BackColor = System.Drawing.Color.Transparent;
            this.cboSuffix.BorderRadius = 15;
            this.cboSuffix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuffix.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSuffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSuffix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSuffix.ForeColor = System.Drawing.Color.Black;
            this.cboSuffix.ItemHeight = 30;
            this.cboSuffix.Items.AddRange(new object[] {
            "",
            "JR",
            "SR",
            "II",
            "III",
            "IV",
            "V"});
            this.cboSuffix.Location = new System.Drawing.Point(809, 64);
            this.cboSuffix.Name = "cboSuffix";
            this.cboSuffix.Size = new System.Drawing.Size(110, 36);
            this.cboSuffix.TabIndex = 4;
            // 
            // btnCamera
            // 
            this.btnCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamera.FlatAppearance.BorderSize = 0;
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCamera.Image = global::BMIS.Properties.Resources.icons8_compact_camera_25;
            this.btnCamera.Location = new System.Drawing.Point(218, 14);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(35, 38);
            this.btnCamera.TabIndex = 63;
            this.btnCamera.TabStop = false;
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // cboPurok
            // 
            this.cboPurok.BackColor = System.Drawing.Color.Transparent;
            this.cboPurok.BorderRadius = 15;
            this.cboPurok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPurok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPurok.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPurok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPurok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPurok.ForeColor = System.Drawing.Color.Black;
            this.cboPurok.ItemHeight = 30;
            this.cboPurok.Items.AddRange(new object[] {
            "",
            "PUROK I - A",
            "PUROK I - B",
            "PUROK I - C",
            "PUROK II",
            "PUROK III",
            "PUROK IV - A",
            "PUROK IV -B",
            "IMPERIAL",
            "LUMINA I",
            "LUMINA II",
            "LUMINA III",
            "LUMINA IV"});
            this.cboPurok.Location = new System.Drawing.Point(15, 379);
            this.cboPurok.Name = "cboPurok";
            this.cboPurok.Size = new System.Drawing.Size(197, 36);
            this.cboPurok.TabIndex = 16;
            // 
            // cboVoterStatus
            // 
            this.cboVoterStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboVoterStatus.BorderRadius = 15;
            this.cboVoterStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboVoterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoterStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboVoterStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboVoterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVoterStatus.ForeColor = System.Drawing.Color.Black;
            this.cboVoterStatus.ItemHeight = 30;
            this.cboVoterStatus.Items.AddRange(new object[] {
            "",
            "REGISTERED",
            "NOT REGISTERED"});
            this.cboVoterStatus.Location = new System.Drawing.Point(703, 379);
            this.cboVoterStatus.Name = "cboVoterStatus";
            this.cboVoterStatus.Size = new System.Drawing.Size(213, 36);
            this.cboVoterStatus.TabIndex = 19;
            // 
            // cboCivilStatus
            // 
            this.cboCivilStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboCivilStatus.BorderRadius = 15;
            this.cboCivilStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCivilStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCivilStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCivilStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCivilStatus.ForeColor = System.Drawing.Color.Black;
            this.cboCivilStatus.ItemHeight = 30;
            this.cboCivilStatus.Items.AddRange(new object[] {
            "",
            "SINGLE",
            "MARRIED",
            "DIVORCE",
            "WIDOWED"});
            this.cboCivilStatus.Location = new System.Drawing.Point(485, 64);
            this.cboCivilStatus.Name = "cboCivilStatus";
            this.cboCivilStatus.Size = new System.Drawing.Size(155, 36);
            this.cboCivilStatus.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(13, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "CONTACT NO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(708, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "VOTER?";
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboCategory.BorderRadius = 15;
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.ForeColor = System.Drawing.Color.Black;
            this.cboCategory.ItemHeight = 30;
            this.cboCategory.Items.AddRange(new object[] {
            "",
            "SENIOR",
            "PWD",
            "SOLO PARENT",
            "LGBT"});
            this.cboCategory.Location = new System.Drawing.Point(503, 379);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(184, 36);
            this.cboCategory.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(13, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "ZONE";
            // 
            // txtContactNo
            // 
            this.txtContactNo.BorderRadius = 15;
            this.txtContactNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNo.DefaultText = "";
            this.txtContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContactNo.ForeColor = System.Drawing.Color.Black;
            this.txtContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNo.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtContactNo.Location = new System.Drawing.Point(15, 223);
            this.txtContactNo.MaxLength = 11;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PasswordChar = '\0';
            this.txtContactNo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtContactNo.PlaceholderText = "(09XXXXXXXXX)";
            this.txtContactNo.SelectedText = "";
            this.txtContactNo.Size = new System.Drawing.Size(228, 45);
            this.txtContactNo.TabIndex = 8;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(806, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "SUFFIX";
            // 
            // txtNationality
            // 
            this.txtNationality.BorderRadius = 15;
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationality.ForeColor = System.Drawing.Color.Black;
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtNationality.Location = new System.Drawing.Point(259, 301);
            this.txtNationality.MaxLength = 100;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNationality.PlaceholderText = "";
            this.txtNationality.SelectedText = "";
            this.txtNationality.Size = new System.Drawing.Size(210, 45);
            this.txtNationality.TabIndex = 13;
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationality_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(500, 359);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "CATEGORY";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 15;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtAddress.Location = new System.Drawing.Point(228, 379);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(259, 45);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(708, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "RELIGION";
            // 
            // txtOccupation
            // 
            this.txtOccupation.BorderRadius = 15;
            this.txtOccupation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOccupation.DefaultText = "";
            this.txtOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOccupation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOccupation.ForeColor = System.Drawing.Color.Black;
            this.txtOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOccupation.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtOccupation.Location = new System.Drawing.Point(15, 303);
            this.txtOccupation.MaxLength = 100;
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.PasswordChar = '\0';
            this.txtOccupation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOccupation.PlaceholderText = "";
            this.txtOccupation.SelectedText = "";
            this.txtOccupation.Size = new System.Drawing.Size(228, 45);
            this.txtOccupation.TabIndex = 12;
            this.txtOccupation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOccupation_KeyPress);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.BorderRadius = 15;
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthDate.FillColor = System.Drawing.Color.White;
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpBirthDate.ForeColor = System.Drawing.Color.Black;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(485, 303);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.ShowUpDown = true;
            this.dtpBirthDate.Size = new System.Drawing.Size(278, 43);
            this.dtpBirthDate.TabIndex = 14;
            this.dtpBirthDate.TabStop = false;
            this.dtpBirthDate.Value = new System.DateTime(2022, 1, 5, 0, 0, 0, 0);
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.BorderRadius = 15;
            this.txtMiddleInitial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiddleInitial.DefaultText = "";
            this.txtMiddleInitial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiddleInitial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiddleInitial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleInitial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleInitial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleInitial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMiddleInitial.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleInitial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleInitial.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtMiddleInitial.Location = new System.Drawing.Point(485, 147);
            this.txtMiddleInitial.MaxLength = 100;
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.PasswordChar = '\0';
            this.txtMiddleInitial.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMiddleInitial.PlaceholderText = "";
            this.txtMiddleInitial.SelectedText = "";
            this.txtMiddleInitial.Size = new System.Drawing.Size(208, 45);
            this.txtMiddleInitial.TabIndex = 6;
            this.txtMiddleInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiddleInitial_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderRadius = 15;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtFirstName.Location = new System.Drawing.Point(259, 145);
            this.txtFirstName.MaxLength = 100;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(208, 45);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderRadius = 15;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtLastName.Location = new System.Drawing.Point(711, 147);
            this.txtLastName.MaxLength = 100;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(208, 45);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // cboSex
            // 
            this.cboSex.BackColor = System.Drawing.Color.Transparent;
            this.cboSex.BorderRadius = 15;
            this.cboSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSex.ForeColor = System.Drawing.Color.Black;
            this.cboSex.ItemHeight = 30;
            this.cboSex.Items.AddRange(new object[] {
            "",
            "MALE",
            "FEMALE"});
            this.cboSex.Location = new System.Drawing.Point(656, 64);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(137, 36);
            this.cboSex.TabIndex = 3;
            // 
            // txtReligion
            // 
            this.txtReligion.BorderRadius = 15;
            this.txtReligion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReligion.DefaultText = "";
            this.txtReligion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReligion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReligion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReligion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReligion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReligion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReligion.ForeColor = System.Drawing.Color.Black;
            this.txtReligion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReligion.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtReligion.Location = new System.Drawing.Point(711, 223);
            this.txtReligion.MaxLength = 100;
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.PasswordChar = '\0';
            this.txtReligion.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtReligion.PlaceholderText = "";
            this.txtReligion.SelectedText = "";
            this.txtReligion.Size = new System.Drawing.Size(205, 45);
            this.txtReligion.TabIndex = 11;
            this.txtReligion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // txtAge
            // 
            this.txtAge.BorderRadius = 15;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DefaultText = "";
            this.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAge.DisabledState.FillColor = System.Drawing.Color.LightYellow;
            this.txtAge.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.Enabled = false;
            this.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtAge.Location = new System.Drawing.Point(779, 301);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAge.PlaceholderText = "";
            this.txtAge.ReadOnly = true;
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(137, 45);
            this.txtAge.TabIndex = 15;
            this.txtAge.TabStop = false;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtResidentID
            // 
            this.txtResidentID.BorderRadius = 15;
            this.txtResidentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResidentID.DefaultText = "";
            this.txtResidentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResidentID.DisabledState.FillColor = System.Drawing.Color.LightYellow;
            this.txtResidentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResidentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResidentID.Enabled = false;
            this.txtResidentID.FillColor = System.Drawing.Color.LightYellow;
            this.txtResidentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResidentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResidentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResidentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResidentID.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtResidentID.Location = new System.Drawing.Point(259, 64);
            this.txtResidentID.MaxLength = 15;
            this.txtResidentID.Name = "txtResidentID";
            this.txtResidentID.PasswordChar = '\0';
            this.txtResidentID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtResidentID.PlaceholderText = "";
            this.txtResidentID.ReadOnly = true;
            this.txtResidentID.SelectedText = "";
            this.txtResidentID.Size = new System.Drawing.Size(208, 45);
            this.txtResidentID.TabIndex = 1;
            this.txtResidentID.TabStop = false;
            this.txtResidentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResidentID_KeyPress);
            // 
            // txtUserImagePath
            // 
            this.txtUserImagePath.Location = new System.Drawing.Point(81, 0);
            this.txtUserImagePath.Name = "txtUserImagePath";
            this.txtUserImagePath.Size = new System.Drawing.Size(24, 22);
            this.txtUserImagePath.TabIndex = 21;
            this.txtUserImagePath.TabStop = false;
            this.txtUserImagePath.Visible = false;
            // 
            // btnClearPic
            // 
            this.btnClearPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPic.FlatAppearance.BorderSize = 0;
            this.btnClearPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearPic.Image = global::BMIS.Properties.Resources.icons8_remove_image_25;
            this.btnClearPic.Location = new System.Drawing.Point(218, 165);
            this.btnClearPic.Name = "btnClearPic";
            this.btnClearPic.Size = new System.Drawing.Size(35, 38);
            this.btnClearPic.TabIndex = 44;
            this.btnClearPic.TabStop = false;
            this.btnClearPic.UseVisualStyleBackColor = true;
            this.btnClearPic.Click += new System.EventHandler(this.btnClearPic_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(482, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 17);
            this.label22.TabIndex = 42;
            this.label22.Text = "MIDDLE NAME";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(778, 283);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 17);
            this.label20.TabIndex = 40;
            this.label20.Text = "AGE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(259, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 17);
            this.label21.TabIndex = 41;
            this.label21.Text = "FIRST NAME";
            // 
            // btnBrowsePic
            // 
            this.btnBrowsePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowsePic.FlatAppearance.BorderSize = 0;
            this.btnBrowsePic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowsePic.Image = global::BMIS.Properties.Resources.icons8_add_image_25;
            this.btnBrowsePic.Location = new System.Drawing.Point(177, 165);
            this.btnBrowsePic.Name = "btnBrowsePic";
            this.btnBrowsePic.Size = new System.Drawing.Size(35, 38);
            this.btnBrowsePic.TabIndex = 35;
            this.btnBrowsePic.TabStop = false;
            this.btnBrowsePic.UseVisualStyleBackColor = true;
            this.btnBrowsePic.Click += new System.EventHandler(this.btnBrowsePic_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(12, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 34;
            this.label18.Text = "PHOTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(482, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "CIVIL STATUS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(234, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "ADDRESS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(259, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "NATIONALITY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(13, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "OCCUPATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(482, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "BIRTHDATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(643, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "GENDER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(840, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(710, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "LAST NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(259, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESIDENT ID";
            // 
            // picUserImage
            // 
            this.picUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUserImage.ErrorImage = null;
            this.picUserImage.Image = ((System.Drawing.Image)(resources.GetObject("picUserImage.Image")));
            this.picUserImage.InitialImage = null;
            this.picUserImage.Location = new System.Drawing.Point(15, 25);
            this.picUserImage.Name = "picUserImage";
            this.picUserImage.Size = new System.Drawing.Size(228, 165);
            this.picUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserImage.TabIndex = 1;
            this.picUserImage.TabStop = false;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.AutoRoundedCorners = true;
            this.btnSaveInfo.BorderRadius = 19;
            this.btnSaveInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnSaveInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Image = global::BMIS.Properties.Resources.icons8_plus___30;
            this.btnSaveInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveInfo.Location = new System.Drawing.Point(823, 532);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(126, 41);
            this.btnSaveInfo.TabIndex = 20;
            this.btnSaveInfo.TabStop = false;
            this.btnSaveInfo.Text = "SAVE";
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1263, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // frmAddResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(961, 592);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddResident";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddResident_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picUserImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddNewResident;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button btnBrowsePic;
        private Guna.UI2.WinForms.Guna2Button btnSaveInfo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtUserImagePath;
        private System.Windows.Forms.Button btnClearPic;
        private Guna.UI2.WinForms.Guna2TextBox txtResidentID;
        private Guna.UI2.WinForms.Guna2TextBox txtAge;
        private Guna.UI2.WinForms.Guna2ComboBox cboSex;
        private Guna.UI2.WinForms.Guna2TextBox txtMiddleInitial;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtOccupation;
        private Guna.UI2.WinForms.Guna2TextBox txtReligion;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNo;
        private Guna.UI2.WinForms.Guna2ComboBox cboPurok;
        private Guna.UI2.WinForms.Guna2ComboBox cboVoterStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboCivilStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboCategory;
        private System.Windows.Forms.Button btnCamera;
        private Guna.UI2.WinForms.Guna2ComboBox cboSuffix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private Guna.UI2.WinForms.Guna2TextBox txtMotherName;
        private Guna.UI2.WinForms.Guna2TextBox txtFatherName;
        private System.Windows.Forms.Label label6;
    }
}