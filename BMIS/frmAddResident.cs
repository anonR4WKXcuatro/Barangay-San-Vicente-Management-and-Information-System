using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmAddResident : Form
    {
        public frmAddResident()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            dtpBirthDate.Value = DateTime.Now;
        }
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

        private bool fieldValidation()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtResidentID.Text) || string.IsNullOrWhiteSpace(txtAge.Text)
            || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text)
            || string.IsNullOrWhiteSpace(txtOccupation.Text) || string.IsNullOrWhiteSpace(txtReligion.Text)
            || string.IsNullOrWhiteSpace(txtNationality.Text) || string.IsNullOrWhiteSpace(txtAddress.Text)
            || string.IsNullOrWhiteSpace(cboCivilStatus.Text) || string.IsNullOrWhiteSpace(cboVoterStatus.Text)
            || string.IsNullOrWhiteSpace(cboPurok.Text) || string.IsNullOrWhiteSpace(cboSex.Text)
                || string.IsNullOrWhiteSpace(txtMotherName.Text) || string.IsNullOrWhiteSpace(txtFatherName.Text))
            {
                isValid = false;
            }
            return isValid;
        }
        public void resetFields() // method to reset all controls exists in form
        {
            picUserImage.Image = Properties.Resources.emptyprofile;
            dtpBirthDate.Value = DateTime.Now;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                //reset textbox
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
                //reset combobox
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
            };
            func(Controls);
        }

        public string NewId_FromGuidShorted() => Guid.NewGuid().ToString("N").Substring(0, 15); //GENERATE SHORT GUID (MAX 15 CHARS)
        private void frmAddResident_Load(object sender, EventArgs e)
        {
            txtResidentID.Text = NewId_FromGuidShorted();
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picUserImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arrImage = ms.GetBuffer();
            var i = new Person //Initialize all objects
            {
                ResidentID = txtResidentID.Text,
                FullName = txtFirstName.Text + " " + txtMiddleInitial.Text + " " + txtLastName.Text + " " + cboSuffix.Text,
                FatherName = txtFatherName.Text,
                MotherName = txtMotherName.Text,
                Sex = cboSex.Text,
                Age = txtAge.Text,
                BirthDate = dtpBirthDate.Text,
                CivilStatus = cboCivilStatus.Text,
                Nationality = txtNationality.Text,
                ContactNo = txtContactNo.Text,
                Religion = txtReligion.Text,
                Occupation = txtOccupation.Text,
                Category = cboCategory.Text,
                Voterstatus = cboVoterStatus.Text,
                Purok = cboPurok.Text,
                Address = txtAddress.Text,
                Image = arrImage,
                IsDead = 1 // TRUE OR ALIVE

            };
            using (var connection = new MySqlConnection("server=localhost; port=3306; user=root; password=admin123; database=bmis_db"))
            {
                connection.Open();
                Console.WriteLine("Connection Pool Open!");
                using (var insertQuery = new MySqlCommand("INSERT INTO tbl_resident(residentID,fullname,fathername,mothername,sex,age,birthdate,civil_status,nationality,contact_no,religion,occupation,category,voter_status,purok,address,image,isDead)" +
                                     "VALUES(@residentID,@FullName,@FatherName,@MotherName,@sex,@age,@birthdate,@civilStatus,@nationality,@contactNo,@religion,@occupation,@category,@voterStatus,@purok,@address,@image,@isDead)", connection))
                {
                    //INSERT INFORMATIONS TO DB
                    insertQuery.Parameters.AddWithValue("@residentID", i.ResidentID);
                    insertQuery.Parameters.AddWithValue("@FullName", i.FullName);
                    insertQuery.Parameters.AddWithValue("@FatherName", i.FatherName);
                    insertQuery.Parameters.AddWithValue("@MotherName", i.MotherName);
                    insertQuery.Parameters.AddWithValue("@sex", i.Sex);
                    insertQuery.Parameters.AddWithValue("@age", i.Age);
                    insertQuery.Parameters.AddWithValue("@birthdate", i.BirthDate);
                    insertQuery.Parameters.AddWithValue("@civilStatus", i.CivilStatus);
                    insertQuery.Parameters.AddWithValue("@nationality", i.Nationality);
                    insertQuery.Parameters.AddWithValue("@contactNo", i.ContactNo);
                    insertQuery.Parameters.AddWithValue("@religion", i.Religion);
                    insertQuery.Parameters.AddWithValue("@occupation", i.Occupation);
                    insertQuery.Parameters.AddWithValue("@category", i.Category);
                    insertQuery.Parameters.AddWithValue("@voterStatus", i.Voterstatus);
                    insertQuery.Parameters.AddWithValue("@purok", i.Purok);
                    insertQuery.Parameters.AddWithValue("@address", i.Address);
                    insertQuery.Parameters.AddWithValue("@image", i.Image);
                    insertQuery.Parameters.AddWithValue("@isDead", i.IsDead);
                    try
                    {
                        if (fieldValidation() == false)
                        {
                            MessageBox.Show("Please fill up important fields!", "Notice", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else if (insertQuery.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Resident successfully registered!", "Notice", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            this.Hide();
                        }
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("This Resident ID Already Exist! Please Try Again", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }
                Console.WriteLine("Connection Pool Closed!");
                connection.Close();
            }
        }
        private void btnCamera_Click(object sender, EventArgs e)
        {
            frmCaptureImage frmCapture = new frmCaptureImage();
            frmCapture.ShowDialog();
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
                maxImageSize = 50000; // 50 KB || 50000 Bytes       1MB = 1000000 Bytes

                if (maxImageSize >= length) // EXECUTE WHEN IMAGE EXCEEDS MORE THAN 50 KB || 50000 Byte
                {
                    picUserImage.Image = new Bitmap(opf.FileName);
                    picUserImage.ImageLocation = opf.FileName;
                }
                else
                {
                    MessageBox.Show("Image size must not exceed 50 KiloByte(KB)", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }
        private void btnClearPic_Click(object sender, EventArgs e)
        {
            picUserImage.Image = Properties.Resources.emptyprofile;
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Subtract(dtpBirthDate.Value).TotalDays;
            var years = (age / 365);
            txtAge.Text = Math.Round(years).ToString();
            cboCategory.SelectedItem = years >= 60 ? cboCategory.Items[1] : cboCategory.Items[0]; // IF AGE 60 AND UP THEN IT WILL SET TO SENIOR
        }
        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtResidentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtMiddleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
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
        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtMotherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            resetFields();
            Close();
        }




    }
}

