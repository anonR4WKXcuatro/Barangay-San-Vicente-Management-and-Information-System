using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmResidentProfile : Form
    {
        private string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //To round border.
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public frmResidentProfile()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        public PictureBox userPicture
        {
            get
            {
                return picUserImage;
            }
        }
        public string ResidentID
        {
            get
            {
                return txtResidentID.Text;
            }
            set
            {
                txtResidentID.Text = value;
            }

        }
        public string FullName
        {
            get
            {
                return txtFullName.Text;
            }
            set
            {
                txtFullName.Text = value;
            }

        }
        public string FatherName
        {
            get
            {
                return txtFatherName.Text;
            }
            set
            {
                txtFatherName.Text = value;
            }

        }
        public string MotherName
        {
            get
            {
                return txtMotherName.Text;
            }
            set
            {
                txtMotherName.Text = value;
            }

        }
        public string Sex
        {
            get
            {
                return cboSex.Text;
            }
            set
            {
                cboSex.Text = value;
            }

        }
        public string Age
        {
            get
            {
                return txtAge.Text;
            }
            set
            {
                txtAge.Text = value;
            }
        }
        public string Birthdate
        {
            get
            {
                return dtpBirthDate.Text;
            }
            set
            {
                dtpBirthDate.Text = value;
            }
        }
        public string CivilStatus
        {
            get
            {
                return cboCivilStatus.Text;
            }
            set
            {
                cboCivilStatus.Text = value;
            }
        }
        public string Nationality
        {
            get
            {
                return txtNationality.Text;
            }
            set
            {
                txtNationality.Text = value;
            }
        }
        public string ContactNo
        {
            get
            {
                return txtContactNo.Text;
            }
            set
            {
                txtContactNo.Text = value;
            }
        }
        public string Religion
        {
            get
            {
                return txtReligion.Text;
            }
            set
            {
                txtReligion.Text = value;
            }
        }
        public string Occupation
        {
            get
            {
                return txtOccupation.Text;
            }
            set
            {
                txtOccupation.Text = value;
            }
        }
        public string Category
        {
            get
            {
                return cboCategory.Text;
            }
            set
            {
                cboCategory.Text = value;
            }
        }
        public string VoterStatus
        {
            get
            {
                return cboVoterStatus.Text;
            }
            set
            {
                cboVoterStatus.Text = value;
            }
        }
        public string Purok
        {
            get
            {
                return cboPurok.Text;
            }
            set
            {
                cboPurok.Text = value;
            }
        }
        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                txtAddress.Text = value;
            }
        }
        public string Status
        {
            get
            {
                return txtStatus.Text;
            }
            set
            {
                txtStatus.Text = value;
            }
        }

        private void MarkAsDead()
        {


            byte isDead = 0; // 0 MEANS FALSE = DEAD

            using (var connection = new MySqlConnection(connectionString))
            {
                Console.WriteLine("Connection Pool Open!");
                connection.Open();
                using (var command = new MySqlCommand("UPDATE tbl_resident SET isDead = @isDead WHERE residentID = @residentID", connection))
                {
                    command.Parameters.AddWithValue("@residentID", txtResidentID.Text);
                    command.Parameters.AddWithValue("@isDead", isDead);
                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {

                        }
                        else
                        {

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    { }
                    connection.Close();
                    Console.WriteLine("Connection Pool Closed!");
                }
            }
        }

        private void frmResidentProfile_Load(object sender, EventArgs e)
        {

            if (txtStatus.Text.Equals("0"))
            {
                lblDead.Visible = true;
                btnMarkDead.Visible = false;
            }
            else
            {
                lblDead.Visible = false;
                btnMarkDead.Visible = true;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmResidentLists frm1 = new frmResidentLists();
            //update function here
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();

            MemoryStream ms = new MemoryStream();
            picUserImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arrImage = ms.GetBuffer();
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@residentID", txtResidentID.Text);
                command.Parameters.AddWithValue("@FullName", txtFullName.Text);
                command.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                command.Parameters.AddWithValue("@MotherName", txtMotherName.Text);
                command.Parameters.AddWithValue("@sex", cboSex.Text);
                command.Parameters.AddWithValue("@age", txtAge.Text);
                command.Parameters.AddWithValue("@birthdate", dtpBirthDate.Text);
                command.Parameters.AddWithValue("@civilStatus", cboCivilStatus.Text);
                command.Parameters.AddWithValue("@nationality", txtNationality.Text);
                command.Parameters.AddWithValue("@contactNo", txtContactNo.Text);
                command.Parameters.AddWithValue("@religion", txtReligion.Text);
                command.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                command.Parameters.AddWithValue("@category", cboCategory.Text);
                command.Parameters.AddWithValue("@voterStatus", cboVoterStatus.Text);
                command.Parameters.AddWithValue("@purok", cboPurok.Text);
                command.Parameters.AddWithValue("@address", txtAddress.Text);
                command.Parameters.AddWithValue("@image", arrImage);
                command.CommandText = "UPDATE tbl_resident SET fullname = @FullName, fathername = @FatherName, mothername = @Mothername, sex = @sex, age = @age, birthdate = @birthdate, civil_status = @civilStatus, nationality = @nationality, contact_no = @contactNo, religion = @religion, occupation = @occupation, category = @category, voter_status = @voterStatus, purok = @purok, address = @address, image = @image WHERE residentID = @residentID";
                //Controls validation
                if (string.IsNullOrEmpty(txtResidentID.Text) || string.IsNullOrEmpty(txtFullName.Text)
                || string.IsNullOrEmpty(cboSex.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(dtpBirthDate.Text) || string.IsNullOrEmpty(cboCivilStatus.Text)
                || string.IsNullOrEmpty(txtNationality.Text) || string.IsNullOrEmpty(txtContactNo.Text) || string.IsNullOrEmpty(txtReligion.Text) || string.IsNullOrEmpty(cboVoterStatus.Text)
                || string.IsNullOrEmpty(cboPurok.Text) || string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please fill up the remaining fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (command.ExecuteNonQuery() > 0) // INSERT DATA WHEN ALL FIELDS IS NOT NULL
                {
                    MessageBox.Show("Information Updated Succesfully !", "Notice", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Close();
                }
                connection.Close();
            }
            catch (Exception ex) //????????????????????????
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            long maxImageSize, length;
            opf.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtUserImagePath.Text = opf.FileName;
                length = new FileInfo(opf.FileName).Length;
                maxImageSize = 1000000; // 1 Megabyte(MB) || 1,000,000 Byte

                if (maxImageSize >= length) // EXECUTE WHEN IMAGE EXCEEDS MORE THAN 1 Megabyte(MB) || 1,000,000 Byte
                {
                    picUserImage.Image = new Bitmap(opf.FileName);
                    picUserImage.ImageLocation = opf.FileName;
                }
                else
                {
                    MessageBox.Show("Image size must not exceed 1 Megabyte(MB)", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResidentID.Text);
        }
        private void btnClearPic_Click(object sender, EventArgs e)
        {
            picUserImage.Image = Properties.Resources.emptyprofile;
        }
        private void btnCamera_Click(object sender, EventArgs e)
        {
            frmCaptureImage frmCapture = new frmCaptureImage();
            frmCapture.ShowDialog();
        }
        private void btnMarkDead_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Mark resident as dead?", "Confirmation", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    MarkAsDead();
                    MessageBox.Show("Success!", "Notice", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Dispose();
                    break;
                default:
                    Console.WriteLine("Do nothing");
                    break;
            }
        }

       

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Subtract(dtpBirthDate.Value).TotalDays;
            var years = (age / 365);
            txtAge.Text = Math.Round(years).ToString();
            cboCategory.SelectedItem = years >= 60 ? cboCategory.Items[1] : cboCategory.Items[0]; // IF AGE 60 AND UP THEN IT WILL SET TO SENIOR

        }
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtReligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtOccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

