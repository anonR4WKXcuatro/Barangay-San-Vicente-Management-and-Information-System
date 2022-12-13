using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmResidentLists : Form
    {
        string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        frmAddResident frm1 = new frmAddResident();
        public frmResidentLists()
        {
            InitializeComponent();
        }

        private void refreshTable()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_resident", connection))
                {
                    using (var sqlDA = new MySqlDataAdapter(selectQuery))
                    {
                        DataTable table = new DataTable();
                        sqlDA.Fill(table);
                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = table;
                        dgvResidentTable.DataSource = bSource;
                    }
                }
                connection.Close();

            }
        }
        private void searchData(string valueToSearch)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var searchQuery = new MySqlCommand("SELECT * FROM tbl_resident WHERE CONCAT(residentID,fullname,address,purok)like'%" + valueToSearch + "%'", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(searchQuery))
                {
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    dgvResidentTable.DataSource = table;
                }
                connection.Close();
            }
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            frm1.resetFields();
            frm1.ShowDialog();
        }
        private void frmResidentLists_Load(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_resident", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                {
                    DataSet dSet = new DataSet();
                    sqlDA.Fill(dSet);
                    dgvResidentTable.AutoGenerateColumns = false;
                    dgvResidentTable.ColumnCount = 20;
                    dgvResidentTable.Columns[0].DataPropertyName = "residentID";
                    dgvResidentTable.Columns[1].DataPropertyName = "fullname";
                    dgvResidentTable.Columns[2].DataPropertyName = "fathername";
                    dgvResidentTable.Columns[3].DataPropertyName = "mothername";
                    dgvResidentTable.Columns[4].DataPropertyName = "sex";
                    dgvResidentTable.Columns[5].DataPropertyName = "age";
                    dgvResidentTable.Columns[6].DataPropertyName = "civil_status";
                    dgvResidentTable.Columns[7].DataPropertyName = "occupation";
                    dgvResidentTable.Columns[8].DataPropertyName = "address";
                    dgvResidentTable.Columns[9].DataPropertyName = "image";
                    dgvResidentTable.Columns[10].DataPropertyName = "nationality";
                    dgvResidentTable.Columns[11].DataPropertyName = "religion";
                    //dgvResidentTable.Columns[10].DataPropertyName = "suffix";
                    dgvResidentTable.Columns[12].DataPropertyName = "birthdate";
                    dgvResidentTable.Columns[13].DataPropertyName = "contact_no";
                    dgvResidentTable.Columns[14].DataPropertyName = "category";
                    dgvResidentTable.Columns[15].DataPropertyName = "purok";
                    dgvResidentTable.Columns[16].DataPropertyName = "voter_status";
                    dgvResidentTable.Columns[17].DataPropertyName = "isDead";
                    dgvResidentTable.DataSource = dSet.Tables[0];
                }
                searchData("");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }
        private void txtSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valueToSearch = txtSearchBar.Text.ToString();
            searchData(valueToSearch);
        }






        private void dgvResidentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmResidentProfile frm2 = new frmResidentProfile();
            DataGridViewRow row = dgvResidentTable.Rows[e.RowIndex];
            if (dgvResidentTable.Columns[e.ColumnIndex].Name == "PROFILE")
            {
                if (e.RowIndex >= 0)
                {
                    frm2.ResidentID = row.Cells[0].Value.ToString();
                    frm2.FullName = row.Cells[1].Value.ToString();
                    frm2.FatherName = row.Cells[2].Value.ToString();
                    frm2.MotherName = row.Cells[3].Value.ToString();
                    frm2.Sex = row.Cells[4].Value.ToString();
                    frm2.Age = row.Cells[5].Value.ToString();
                    frm2.CivilStatus = row.Cells[6].Value.ToString();
                    frm2.Occupation = row.Cells[7].Value.ToString();
                    frm2.Address = row.Cells[8].Value.ToString();
                    frm2.txtUserImagePath.Text = dgvResidentTable.CurrentRow.Cells[9].Value.ToString();
                    byte[] imgData = (byte[])dgvResidentTable.CurrentRow.Cells[9].Value;
                    MemoryStream ms = new MemoryStream(imgData);
                    frm2.userPicture.Image = Image.FromStream(ms);
                    frm2.Nationality = row.Cells[10].Value.ToString();
                    frm2.Religion = row.Cells[11].Value.ToString();
                    frm2.Birthdate = row.Cells[12].Value.ToString();
                    frm2.ContactNo = row.Cells[13].Value.ToString();
                    frm2.Category = row.Cells[14].Value.ToString();
                    frm2.Purok = row.Cells[15].Value.ToString();
                    frm2.VoterStatus = row.Cells[16].Value.ToString();
                    string isAlive = row.Cells[17].Value.ToString();
                    frm2.Status = isAlive;
                    if (isAlive.Equals(0))
                    {
                        frm2.lblDead.Visible = true;
                    }
                    else
                    {
                        frm2.lblDead.Visible = false;
                    }

                }

                frm2.ShowDialog();
            }
            else if (dgvResidentTable.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DialogResult dr = MessageBox.Show("Do you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
                try
                {
                    if (dr == DialogResult.Yes)
                    {
                        using (var connection = new MySqlConnection(connectionString))
                        using (var deleteQuery = new MySqlCommand("DELETE FROM tbl_resident WHERE residentID = @residentID", connection))
                        {
                            connection.Open();
                            DataGridViewRow residentID = dgvResidentTable.Rows[e.RowIndex];
                            deleteQuery.Parameters.AddWithValue("@residentID", residentID.Cells[0].Value);
                            deleteQuery.ExecuteNonQuery();
                            using (var connection2 = new MySqlConnection(connectionString))
                            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_resident", connection2))
                            {
                                connection2.Open();
                                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                                {
                                    DataSet ds = new DataSet();
                                    sqlDA.Fill(ds, "tbl_resident");
                                    dgvResidentTable.DataSource = ds.Tables[0];
                                    MessageBox.Show("Data Successfully Deleted!", "Notice", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                }
                                connection2.Close();
                            }
                            connection.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Do Nothing");
                    }
                }
                catch (MySqlException)
                {
                    Console.WriteLine(" ----- You must delete the parent row first -----");
                }
            }
        }
    }
}


