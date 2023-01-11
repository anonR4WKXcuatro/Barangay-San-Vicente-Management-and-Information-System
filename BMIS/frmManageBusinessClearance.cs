using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmManageBusinessClearance : Form
    {

        private string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        PrintPreviewForm frm1 = new PrintPreviewForm();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public frmManageBusinessClearance()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public string ResidentID
        {
            get
            {
                return this.txtResidentID.Text;
            }
            set
            {
                this.txtResidentID.Text = value;
            }
        }
        public string FullName
        {
            get
            {
                return this.txtFullName.Text;
            }
            set
            {
                this.txtFullName.Text = value;
            }

        }
        public string CertificationType
        {
            get
            {
                return this.txtCertificateType.Text;
            }
            set
            {
                this.txtCertificateType.Text = value;
            }
        }
        public string OwnersAddress
        {
            get
            {
                return this.txtOwnersAddress.Text;
            }
            set
            {
                this.txtOwnersAddress.Text = value;
            }
        }
        public string CaptainName
        {
            get
            {
                return this.txtBrgyCaptain.Text;
            }
            set
            {
                this.txtBrgyCaptain.Text = value;
            }
        }
        private void BusinessClearanceRPT()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                BusinessClearance businessClearanceRPT = new BusinessClearance();
                TextObject officialReceiptNo, permitNo, residentID, ownersName, ownerShipName, ownersAddress, businessName, businessAddress, businessNature, amount, captainName;

                officialReceiptNo = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section2"].ReportObjects["officialReceiptNo"];
                permitNo = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["permitNo"];
                residentID = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section2"].ReportObjects["resIDNo"];
                ownersName = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentName"];
                ownerShipName = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["ownershipName"];
                ownersAddress = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["ownerAddress"];
                businessName = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["businessName"];
                businessAddress = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["businessAddress"];
                businessNature = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["businessNature"];
                amount = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["amount"];
                captainName = (TextObject)businessClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["captainName"];

                officialReceiptNo.Text = txtOfficialReceiptNo.Text;
                permitNo.Text = txtPermitNo.Text;
                residentID.Text = txtResidentID.Text;
                ownersName.Text = txtFullName.Text;
                ownerShipName.Text = txtFullName.Text;
                ownersAddress.Text = txtOwnersAddress.Text;
                businessName.Text = txtBusinessName.Text;
                businessAddress.Text = txtBusinessAddress.Text;
                businessNature.Text = txtNatureBusiness.Text;
                amount.Text = txtAmount.Text;
                captainName.Text = txtBrgyCaptain.Text;

                frm1.crystalReportViewer1.ReportSource = businessClearanceRPT;
                frm1.ShowDialog();
                Hide();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var insertQuery = new MySqlCommand("INSERT INTO tbl_businessclearance(orNumber,permitNumber,residentID,ownersName,ownersAddress,businessName,businessAddress,businessNature,clearance_type,clearance_purpose)VALUES(@orNumber,@permitNumber,@residentID,@ownersName,@ownersAddress,@businessName,@businessAddress,@businessNature,@clearanceType,@clearancePurpose)", connection))
                {
                    try
                    {
                        insertQuery.Parameters.AddWithValue("@orNumber", txtOfficialReceiptNo.Text);
                        insertQuery.Parameters.AddWithValue("@permitNumber", txtPermitNo.Text);
                        insertQuery.Parameters.AddWithValue("@residentID", txtResidentID.Text);
                        insertQuery.Parameters.AddWithValue("@ownersName", txtFullName.Text);
                        insertQuery.Parameters.AddWithValue("@ownersAddress", txtOwnersAddress.Text);
                        insertQuery.Parameters.AddWithValue("@businessName", txtBusinessName.Text);
                        insertQuery.Parameters.AddWithValue("@businessAddress", txtBusinessAddress.Text);
                        insertQuery.Parameters.AddWithValue("@businessNature", txtNatureBusiness.Text);
                        insertQuery.Parameters.AddWithValue("@clearanceType", txtCertificateType.Text);
                        insertQuery.Parameters.AddWithValue("@clearancePurpose", txtPurpose.Text);

                        connection.Open();
                        if (string.IsNullOrEmpty(txtOfficialReceiptNo.Text) || string.IsNullOrEmpty(txtPermitNo.Text)
                        || string.IsNullOrEmpty(txtOwnersAddress.Text) || string.IsNullOrEmpty(txtBusinessName.Text)
                        || string.IsNullOrEmpty(txtBusinessAddress.Text) || string.IsNullOrEmpty(txtNatureBusiness.Text)
                        || string.IsNullOrEmpty(txtCertificateType.Text) || string.IsNullOrEmpty(txtPurpose.Text))
                        {
                            MessageBox.Show("Please fill up the remaining fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (txtCertificateType.Text == "BARANGAY BUSINESS CLEARANCE")
                        {
                            insertQuery.ExecuteNonQuery();
                            BusinessClearanceRPT();
                        }
                        else
                        {
                            Console.WriteLine("Do nothing");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //MessageBox.Show("Please load another certificate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    connection.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                Console.Write("Do Nothing");
            }
        }

        private void txtOfficialReceiptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtPermitNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtAmount.Text + ch, out x))
            {
                e.Handled = true;
            }
        }
        private void txtNatureBusiness_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtPurpose_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtBusinessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtBusinessAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}

