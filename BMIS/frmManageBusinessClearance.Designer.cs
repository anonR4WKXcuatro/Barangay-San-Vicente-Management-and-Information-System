
namespace BMIS
{
    partial class frmManageBusinessClearance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageBusinessClearance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.ManageCertification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPurpose = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCertificateType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPermitNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusinessAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBusinessName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNatureBusiness = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOwnersAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResidentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOfficialReceiptNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.labels2 = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.ManageCertification);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 53);
            this.panel1.TabIndex = 3;
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
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManageCertification
            // 
            this.ManageCertification.AutoSize = true;
            this.ManageCertification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCertification.ForeColor = System.Drawing.Color.White;
            this.ManageCertification.Location = new System.Drawing.Point(8, 17);
            this.ManageCertification.Name = "ManageCertification";
            this.ManageCertification.Size = new System.Drawing.Size(302, 20);
            this.ManageCertification.TabIndex = 12;
            this.ManageCertification.Text = "MANAGE BUSINESS CLEARANCE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "MANAGE DETAILS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPurpose);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCertificateType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPermitNo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtBusinessAddress);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBusinessName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtNatureBusiness);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtOwnersAddress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtResidentID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtOfficialReceiptNo);
            this.panel2.Controls.Add(this.labels2);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 500);
            this.panel2.TabIndex = 47;
            // 
            // txtPurpose
            // 
            this.txtPurpose.BorderRadius = 15;
            this.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurpose.DefaultText = "";
            this.txtPurpose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPurpose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPurpose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurpose.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurpose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurpose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPurpose.ForeColor = System.Drawing.Color.Black;
            this.txtPurpose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurpose.Location = new System.Drawing.Point(15, 444);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.PasswordChar = '\0';
            this.txtPurpose.PlaceholderText = "";
            this.txtPurpose.SelectedText = "";
            this.txtPurpose.Size = new System.Drawing.Size(417, 43);
            this.txtPurpose.TabIndex = 69;
            this.txtPurpose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurpose_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(21, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "PURPOSE";
            // 
            // txtCertificateType
            // 
            this.txtCertificateType.BorderRadius = 15;
            this.txtCertificateType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCertificateType.DefaultText = "";
            this.txtCertificateType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCertificateType.DisabledState.FillColor = System.Drawing.Color.LightYellow;
            this.txtCertificateType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCertificateType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCertificateType.Enabled = false;
            this.txtCertificateType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCertificateType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCertificateType.ForeColor = System.Drawing.Color.Black;
            this.txtCertificateType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCertificateType.Location = new System.Drawing.Point(480, 367);
            this.txtCertificateType.Name = "txtCertificateType";
            this.txtCertificateType.PasswordChar = '\0';
            this.txtCertificateType.PlaceholderText = "";
            this.txtCertificateType.ReadOnly = true;
            this.txtCertificateType.SelectedText = "";
            this.txtCertificateType.Size = new System.Drawing.Size(417, 43);
            this.txtCertificateType.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(486, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "TYPE OF CERTIFICATION";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 15;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(480, 136);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(417, 43);
            this.txtAmount.TabIndex = 67;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(486, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "AMOUNT";
            // 
            // txtPermitNo
            // 
            this.txtPermitNo.BorderRadius = 15;
            this.txtPermitNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPermitNo.DefaultText = "";
            this.txtPermitNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPermitNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPermitNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPermitNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPermitNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPermitNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPermitNo.ForeColor = System.Drawing.Color.Black;
            this.txtPermitNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPermitNo.Location = new System.Drawing.Point(480, 58);
            this.txtPermitNo.MaxLength = 50;
            this.txtPermitNo.Name = "txtPermitNo";
            this.txtPermitNo.PasswordChar = '\0';
            this.txtPermitNo.PlaceholderText = "";
            this.txtPermitNo.SelectedText = "";
            this.txtPermitNo.Size = new System.Drawing.Size(417, 43);
            this.txtPermitNo.TabIndex = 65;
            this.txtPermitNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPermitNo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(486, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "PERMIT #";
            // 
            // txtBusinessAddress
            // 
            this.txtBusinessAddress.BorderRadius = 15;
            this.txtBusinessAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusinessAddress.DefaultText = "";
            this.txtBusinessAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusinessAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusinessAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusinessAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusinessAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusinessAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusinessAddress.ForeColor = System.Drawing.Color.Black;
            this.txtBusinessAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusinessAddress.Location = new System.Drawing.Point(480, 290);
            this.txtBusinessAddress.Name = "txtBusinessAddress";
            this.txtBusinessAddress.PasswordChar = '\0';
            this.txtBusinessAddress.PlaceholderText = "";
            this.txtBusinessAddress.SelectedText = "";
            this.txtBusinessAddress.Size = new System.Drawing.Size(417, 43);
            this.txtBusinessAddress.TabIndex = 63;
            this.txtBusinessAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusinessAddress_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(486, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "BUSINESS ADDRESS";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.BorderRadius = 15;
            this.txtBusinessName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusinessName.DefaultText = "";
            this.txtBusinessName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusinessName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusinessName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusinessName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusinessName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusinessName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusinessName.ForeColor = System.Drawing.Color.Black;
            this.txtBusinessName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusinessName.Location = new System.Drawing.Point(480, 213);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.PasswordChar = '\0';
            this.txtBusinessName.PlaceholderText = "";
            this.txtBusinessName.SelectedText = "";
            this.txtBusinessName.Size = new System.Drawing.Size(417, 43);
            this.txtBusinessName.TabIndex = 61;
            this.txtBusinessName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusinessName_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(486, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "BUSINESS NAME";
            // 
            // txtNatureBusiness
            // 
            this.txtNatureBusiness.BorderRadius = 15;
            this.txtNatureBusiness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNatureBusiness.DefaultText = "";
            this.txtNatureBusiness.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNatureBusiness.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNatureBusiness.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNatureBusiness.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNatureBusiness.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNatureBusiness.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNatureBusiness.ForeColor = System.Drawing.Color.Black;
            this.txtNatureBusiness.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNatureBusiness.Location = new System.Drawing.Point(15, 367);
            this.txtNatureBusiness.Name = "txtNatureBusiness";
            this.txtNatureBusiness.PasswordChar = '\0';
            this.txtNatureBusiness.PlaceholderText = "";
            this.txtNatureBusiness.SelectedText = "";
            this.txtNatureBusiness.Size = new System.Drawing.Size(417, 43);
            this.txtNatureBusiness.TabIndex = 59;
            this.txtNatureBusiness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNatureBusiness_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(21, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "NATURE OF BUSINESS";
            // 
            // txtOwnersAddress
            // 
            this.txtOwnersAddress.BorderRadius = 15;
            this.txtOwnersAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnersAddress.DefaultText = "";
            this.txtOwnersAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOwnersAddress.DisabledState.FillColor = System.Drawing.Color.LightYellow;
            this.txtOwnersAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOwnersAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnersAddress.Enabled = false;
            this.txtOwnersAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnersAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOwnersAddress.ForeColor = System.Drawing.Color.Black;
            this.txtOwnersAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnersAddress.Location = new System.Drawing.Point(15, 290);
            this.txtOwnersAddress.Name = "txtOwnersAddress";
            this.txtOwnersAddress.PasswordChar = '\0';
            this.txtOwnersAddress.PlaceholderText = "";
            this.txtOwnersAddress.ReadOnly = true;
            this.txtOwnersAddress.SelectedText = "";
            this.txtOwnersAddress.Size = new System.Drawing.Size(417, 43);
            this.txtOwnersAddress.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(21, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "OWNER\'S ADDRESS";
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
            this.txtResidentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResidentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResidentID.ForeColor = System.Drawing.Color.Black;
            this.txtResidentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResidentID.Location = new System.Drawing.Point(15, 136);
            this.txtResidentID.Name = "txtResidentID";
            this.txtResidentID.PasswordChar = '\0';
            this.txtResidentID.PlaceholderText = "";
            this.txtResidentID.ReadOnly = true;
            this.txtResidentID.SelectedText = "";
            this.txtResidentID.Size = new System.Drawing.Size(417, 43);
            this.txtResidentID.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "RESIDENT ID";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 15;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.LightYellow;
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.Enabled = false;
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(15, 213);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(417, 43);
            this.txtFullName.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(21, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "OWNER\'S NAME";
            // 
            // txtOfficialReceiptNo
            // 
            this.txtOfficialReceiptNo.BorderRadius = 15;
            this.txtOfficialReceiptNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOfficialReceiptNo.DefaultText = "";
            this.txtOfficialReceiptNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOfficialReceiptNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOfficialReceiptNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOfficialReceiptNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOfficialReceiptNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOfficialReceiptNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOfficialReceiptNo.ForeColor = System.Drawing.Color.Black;
            this.txtOfficialReceiptNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOfficialReceiptNo.Location = new System.Drawing.Point(19, 58);
            this.txtOfficialReceiptNo.MaxLength = 7;
            this.txtOfficialReceiptNo.Name = "txtOfficialReceiptNo";
            this.txtOfficialReceiptNo.PasswordChar = '\0';
            this.txtOfficialReceiptNo.PlaceholderText = "";
            this.txtOfficialReceiptNo.SelectedText = "";
            this.txtOfficialReceiptNo.Size = new System.Drawing.Size(413, 43);
            this.txtOfficialReceiptNo.TabIndex = 47;
            this.txtOfficialReceiptNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOfficialReceiptNo_KeyPress);
            // 
            // labels2
            // 
            this.labels2.AutoSize = true;
            this.labels2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labels2.Location = new System.Drawing.Point(21, 38);
            this.labels2.Name = "labels2";
            this.labels2.Size = new System.Drawing.Size(159, 17);
            this.labels2.TabIndex = 42;
            this.labels2.Text = "OFFICIAL RECEIPT #";
            // 
            // btnPrint
            // 
            this.btnPrint.AutoRoundedCorners = true;
            this.btnPrint.BorderRadius = 19;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::BMIS.Properties.Resources.icons8_print_30;
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrint.Location = new System.Drawing.Point(806, 592);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(126, 41);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.Text = " PRINT";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmManageBusinessClearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageBusinessClearance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageBusinessClearance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ManageCertification;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPermitNo;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtBusinessAddress;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtBusinessName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtNatureBusiness;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtOwnersAddress;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtResidentID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtOfficialReceiptNo;
        private System.Windows.Forms.Label labels2;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2TextBox txtCertificateType;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPurpose;
        private System.Windows.Forms.Label label11;
    }
}