
namespace BMIS
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBrgySecretary = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnCertifications = new System.Windows.Forms.Button();
            this.btnCases = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnResidents = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panel3.Location = new System.Drawing.Point(329, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1205, 778);
            this.panel3.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(0, 201);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(329, 44);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "[position]";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(329, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 85);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barangay San Vicente, Sto Tomas, Batangas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Digital-7", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(1050, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "BARANGAY MANAGEMENT AND INFORMATION SYSTEM";
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = global::BMIS.Properties.Resources.San_Vicente_Logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 85);
            this.panel4.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblBrgySecretary);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.btnRecords);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.btnCertifications);
            this.panel1.Controls.Add(this.btnCases);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnResidents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 862);
            this.panel1.TabIndex = 4;
            // 
            // lblBrgySecretary
            // 
            this.lblBrgySecretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrgySecretary.ForeColor = System.Drawing.Color.White;
            this.lblBrgySecretary.Location = new System.Drawing.Point(0, 172);
            this.lblBrgySecretary.Name = "lblBrgySecretary";
            this.lblBrgySecretary.Size = new System.Drawing.Size(329, 29);
            this.lblBrgySecretary.TabIndex = 12;
            this.lblBrgySecretary.Text = "[secretary_name]";
            this.lblBrgySecretary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::BMIS.Properties.Resources.icons8_logout_rounded_left_24;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-3, 734);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(329, 75);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "    EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 653);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(329, 75);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "    SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::BMIS.Properties.Resources.icons8_male_user_100;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 24);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(329, 130);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // btnRecords
            // 
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.White;
            this.btnRecords.Image = global::BMIS.Properties.Resources.icons8_database_24;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(0, 572);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRecords.Size = new System.Drawing.Size(329, 75);
            this.btnRecords.TabIndex = 4;
            this.btnRecords.TabStop = false;
            this.btnRecords.Text = "    RECORDS";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnCertifications
            // 
            this.btnCertifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCertifications.FlatAppearance.BorderSize = 0;
            this.btnCertifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertifications.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertifications.ForeColor = System.Drawing.Color.White;
            this.btnCertifications.Image = global::BMIS.Properties.Resources.icons8_certificate_24__1_;
            this.btnCertifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCertifications.Location = new System.Drawing.Point(0, 491);
            this.btnCertifications.Name = "btnCertifications";
            this.btnCertifications.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCertifications.Size = new System.Drawing.Size(329, 75);
            this.btnCertifications.TabIndex = 2;
            this.btnCertifications.TabStop = false;
            this.btnCertifications.Text = "    CERTIFICATIONS";
            this.btnCertifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCertifications.UseVisualStyleBackColor = true;
            this.btnCertifications.Click += new System.EventHandler(this.btnCertifications_Click);
            // 
            // btnCases
            // 
            this.btnCases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCases.FlatAppearance.BorderSize = 0;
            this.btnCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCases.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCases.ForeColor = System.Drawing.Color.White;
            this.btnCases.Image = global::BMIS.Properties.Resources.icons8_privacy_policy_24__1_;
            this.btnCases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCases.Location = new System.Drawing.Point(0, 410);
            this.btnCases.Name = "btnCases";
            this.btnCases.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCases.Size = new System.Drawing.Size(329, 75);
            this.btnCases.TabIndex = 1;
            this.btnCases.TabStop = false;
            this.btnCases.Text = "    BLOTTER AND SUMMON";
            this.btnCases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCases.UseVisualStyleBackColor = true;
            this.btnCases.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::BMIS.Properties.Resources.icons8_squared_menu_24;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 248);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(329, 75);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "    DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnResidents
            // 
            this.btnResidents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResidents.FlatAppearance.BorderSize = 0;
            this.btnResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResidents.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidents.ForeColor = System.Drawing.Color.White;
            this.btnResidents.Image = global::BMIS.Properties.Resources.icons8_user_groups_24;
            this.btnResidents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResidents.Location = new System.Drawing.Point(0, 329);
            this.btnResidents.Name = "btnResidents";
            this.btnResidents.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnResidents.Size = new System.Drawing.Size(329, 75);
            this.btnResidents.TabIndex = 1;
            this.btnResidents.TabStop = false;
            this.btnResidents.Text = "    RESIDENTS";
            this.btnResidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResidents.UseVisualStyleBackColor = true;
            this.btnResidents.Click += new System.EventHandler(this.btnResidents_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1535, 862);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRecords;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Button btnCertifications;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCases;
        private System.Windows.Forms.Button btnResidents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblBrgySecretary;
    }
}