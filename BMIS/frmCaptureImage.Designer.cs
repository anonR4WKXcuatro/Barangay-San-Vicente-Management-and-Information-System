
namespace BMIS
{
    partial class frmCaptureImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaptureImage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddNewResident = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCapture = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveImage = new Guna.UI2.WinForms.Guna2Button();
            this.cboCameraList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.lblAddNewResident.Location = new System.Drawing.Point(12, 17);
            this.lblAddNewResident.Name = "lblAddNewResident";
            this.lblAddNewResident.Size = new System.Drawing.Size(159, 20);
            this.lblAddNewResident.TabIndex = 12;
            this.lblAddNewResident.Text = "CAPTURE IMAGE";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 443);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(461, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(452, 437);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.AutoRoundedCorners = true;
            this.btnCapture.BorderRadius = 19;
            this.btnCapture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnCapture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCapture.Location = new System.Drawing.Point(313, 63);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(104, 41);
            this.btnCapture.TabIndex = 59;
            this.btnCapture.Text = "CAPTURE";
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.AutoRoundedCorners = true;
            this.btnSaveImage.BorderRadius = 19;
            this.btnSaveImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnSaveImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveImage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveImage.Location = new System.Drawing.Point(790, 63);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(142, 41);
            this.btnSaveImage.TabIndex = 60;
            this.btnSaveImage.Text = "SAVE IMAGE";
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // cboCameraList
            // 
            this.cboCameraList.BackColor = System.Drawing.Color.Transparent;
            this.cboCameraList.BorderRadius = 15;
            this.cboCameraList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCameraList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCameraList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCameraList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCameraList.ForeColor = System.Drawing.Color.Black;
            this.cboCameraList.ItemHeight = 30;
            this.cboCameraList.Location = new System.Drawing.Point(16, 63);
            this.cboCameraList.Name = "cboCameraList";
            this.cboCameraList.Size = new System.Drawing.Size(291, 36);
            this.cboCameraList.TabIndex = 61;
            // 
            // frmCaptureImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 570);
            this.Controls.Add(this.cboCameraList);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaptureImage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaptureImage";
            this.Load += new System.EventHandler(this.frmCaptureImage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddNewResident;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnCapture;
        private Guna.UI2.WinForms.Guna2Button btnSaveImage;
        private Guna.UI2.WinForms.Guna2ComboBox cboCameraList;
    }
}