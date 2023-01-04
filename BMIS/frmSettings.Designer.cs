
namespace BMIS
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResidentProfile = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaptainName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSecretaryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaptainPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSecretaryPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowHidePassword1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnShowHidePassword2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblResidentProfile);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 53);
            this.panel1.TabIndex = 1;
            // 
            // lblResidentProfile
            // 
            this.lblResidentProfile.AutoSize = true;
            this.lblResidentProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentProfile.ForeColor = System.Drawing.Color.White;
            this.lblResidentProfile.Location = new System.Drawing.Point(12, 17);
            this.lblResidentProfile.Name = "lblResidentProfile";
            this.lblResidentProfile.Size = new System.Drawing.Size(99, 20);
            this.lblResidentProfile.TabIndex = 12;
            this.lblResidentProfile.Text = "SETTINGS";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(391, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 53);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "UPDATE SECRETARY NAME";
            // 
            // txtCaptainName
            // 
            this.txtCaptainName.BorderRadius = 15;
            this.txtCaptainName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaptainName.DefaultText = "";
            this.txtCaptainName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCaptainName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCaptainName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaptainName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaptainName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaptainName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCaptainName.ForeColor = System.Drawing.Color.Black;
            this.txtCaptainName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaptainName.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtCaptainName.Location = new System.Drawing.Point(15, 47);
            this.txtCaptainName.MaxLength = 100;
            this.txtCaptainName.Name = "txtCaptainName";
            this.txtCaptainName.PasswordChar = '\0';
            this.txtCaptainName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCaptainName.PlaceholderText = "";
            this.txtCaptainName.SelectedText = "";
            this.txtCaptainName.Size = new System.Drawing.Size(374, 45);
            this.txtCaptainName.TabIndex = 6;
            // 
            // txtSecretaryName
            // 
            this.txtSecretaryName.BorderRadius = 15;
            this.txtSecretaryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecretaryName.DefaultText = "";
            this.txtSecretaryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecretaryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecretaryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecretaryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecretaryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecretaryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSecretaryName.ForeColor = System.Drawing.Color.Black;
            this.txtSecretaryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecretaryName.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtSecretaryName.Location = new System.Drawing.Point(15, 135);
            this.txtSecretaryName.MaxLength = 100;
            this.txtSecretaryName.Name = "txtSecretaryName";
            this.txtSecretaryName.PasswordChar = '\0';
            this.txtSecretaryName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSecretaryName.PlaceholderText = "";
            this.txtSecretaryName.SelectedText = "";
            this.txtSecretaryName.Size = new System.Drawing.Size(374, 45);
            this.txtSecretaryName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "UPDATE CAPTAIN NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "UPDATE CAPTAIN PASSWORD";
            // 
            // txtCaptainPassword
            // 
            this.txtCaptainPassword.BorderRadius = 15;
            this.txtCaptainPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaptainPassword.DefaultText = "";
            this.txtCaptainPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCaptainPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCaptainPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaptainPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCaptainPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaptainPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCaptainPassword.ForeColor = System.Drawing.Color.Black;
            this.txtCaptainPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCaptainPassword.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtCaptainPassword.Location = new System.Drawing.Point(15, 223);
            this.txtCaptainPassword.MaxLength = 100;
            this.txtCaptainPassword.Name = "txtCaptainPassword";
            this.txtCaptainPassword.PasswordChar = '\0';
            this.txtCaptainPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCaptainPassword.PlaceholderText = "";
            this.txtCaptainPassword.SelectedText = "";
            this.txtCaptainPassword.Size = new System.Drawing.Size(374, 45);
            this.txtCaptainPassword.TabIndex = 23;
            this.txtCaptainPassword.TextChanged += new System.EventHandler(this.txtCaptainPassword_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnShowHidePassword2);
            this.panel3.Controls.Add(this.btnShowHidePassword1);
            this.panel3.Controls.Add(this.txtSecretaryPassword);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.guna2TextBox2);
            this.panel3.Controls.Add(this.txtCaptainName);
            this.panel3.Controls.Add(this.txtSecretaryName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCaptainPassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(16, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 378);
            this.panel3.TabIndex = 29;
            // 
            // txtSecretaryPassword
            // 
            this.txtSecretaryPassword.BorderRadius = 15;
            this.txtSecretaryPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecretaryPassword.DefaultText = "";
            this.txtSecretaryPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecretaryPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecretaryPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecretaryPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecretaryPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecretaryPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSecretaryPassword.ForeColor = System.Drawing.Color.Black;
            this.txtSecretaryPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecretaryPassword.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtSecretaryPassword.Location = new System.Drawing.Point(15, 311);
            this.txtSecretaryPassword.MaxLength = 100;
            this.txtSecretaryPassword.Name = "txtSecretaryPassword";
            this.txtSecretaryPassword.PasswordChar = '\0';
            this.txtSecretaryPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSecretaryPassword.PlaceholderText = "";
            this.txtSecretaryPassword.SelectedText = "";
            this.txtSecretaryPassword.Size = new System.Drawing.Size(374, 45);
            this.txtSecretaryPassword.TabIndex = 27;
            this.txtSecretaryPassword.TextChanged += new System.EventHandler(this.txtSecretaryPassword_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "UPDATE SECRETARY PASSWORD";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 15;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.IconRightOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBox2.Location = new System.Drawing.Point(15, 47);
            this.guna2TextBox2.MaxLength = 100;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(0, 0);
            this.guna2TextBox2.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(29, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "UPDATE CREDENTIALS";
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
            this.btnSaveInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveInfo.Image")));
            this.btnSaveInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveInfo.Location = new System.Drawing.Point(223, 486);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(202, 41);
            this.btnSaveInfo.TabIndex = 21;
            this.btnSaveInfo.TabStop = false;
            this.btnSaveInfo.Text = "SAVE  CHANGES";
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // btnShowHidePassword1
            // 
            this.btnShowHidePassword1.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword1.CheckedState.Image = global::BMIS.Properties.Resources.icons8_eye_24_checked;
            this.btnShowHidePassword1.Image = global::BMIS.Properties.Resources.icons8_eye_24;
            this.btnShowHidePassword1.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowHidePassword1.ImageRotate = 0F;
            this.btnShowHidePassword1.IndicateFocus = true;
            this.btnShowHidePassword1.Location = new System.Drawing.Point(356, 234);
            this.btnShowHidePassword1.Name = "btnShowHidePassword1";
            this.btnShowHidePassword1.Size = new System.Drawing.Size(24, 24);
            this.btnShowHidePassword1.TabIndex = 59;
            this.btnShowHidePassword1.UseTransparentBackground = true;
            this.btnShowHidePassword1.Visible = false;
            this.btnShowHidePassword1.CheckedChanged += new System.EventHandler(this.btnShowHidePassword1_CheckedChanged);
            // 
            // btnShowHidePassword2
            // 
            this.btnShowHidePassword2.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword2.CheckedState.Image = global::BMIS.Properties.Resources.icons8_eye_24_checked;
            this.btnShowHidePassword2.Image = global::BMIS.Properties.Resources.icons8_eye_24;
            this.btnShowHidePassword2.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowHidePassword2.ImageRotate = 0F;
            this.btnShowHidePassword2.IndicateFocus = true;
            this.btnShowHidePassword2.Location = new System.Drawing.Point(356, 322);
            this.btnShowHidePassword2.Name = "btnShowHidePassword2";
            this.btnShowHidePassword2.Size = new System.Drawing.Size(24, 24);
            this.btnShowHidePassword2.TabIndex = 60;
            this.btnShowHidePassword2.UseTransparentBackground = true;
            this.btnShowHidePassword2.Visible = false;
            this.btnShowHidePassword2.CheckedChanged += new System.EventHandler(this.btnShowHidePassword2_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 549);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResidentProfile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCaptainName;
        private Guna.UI2.WinForms.Guna2TextBox txtSecretaryName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSaveInfo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCaptainPassword;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtSecretaryPassword;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ImageCheckBox btnShowHidePassword2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox btnShowHidePassword1;
    }
}