using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmRecords : Form
    {
        private string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        private string date = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
        public frmRecords()
        {
            InitializeComponent();
        }
        private void ReleaseObject(object obj) //Release the excel objects
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.Message, "Error");
            }
            finally
            {
                GC.Collect();
            }
        }

        private void ResidentTable()
        {
            byte alive = 1;
            using (var connection = new MySqlConnection(connectionString))
            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_resident WHERE isDead = @isAlive", connection))
            {
                connection.Open();
                selectQuery.Parameters.AddWithValue("@isAlive", alive);
                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                {
                    DataSet dSet = new DataSet();
                    sqlDA.Fill(dSet);
                    dgvResidentTable.AutoGenerateColumns = false;
                    dgvResidentTable.ColumnCount = 15;
                    dgvResidentTable.Columns[0].DataPropertyName = "residentID";
                    dgvResidentTable.Columns[1].DataPropertyName = "fullname";
                    dgvResidentTable.Columns[2].DataPropertyName = "sex";
                    dgvResidentTable.Columns[3].DataPropertyName = "age";
                    dgvResidentTable.Columns[4].DataPropertyName = "civil_status";
                    dgvResidentTable.Columns[5].DataPropertyName = "occupation";
                    dgvResidentTable.Columns[6].DataPropertyName = "address";
                    dgvResidentTable.Columns[7].DataPropertyName = "nationality";
                    dgvResidentTable.Columns[8].DataPropertyName = "religion";
                    dgvResidentTable.Columns[9].DataPropertyName = "birthdate";
                    dgvResidentTable.Columns[10].DataPropertyName = "contact_no";
                    dgvResidentTable.Columns[11].DataPropertyName = "category";
                    dgvResidentTable.Columns[12].DataPropertyName = "purok";
                    dgvResidentTable.Columns[13].DataPropertyName = "voter_status";
                    dgvResidentTable.Columns[14].DataPropertyName = "vaccination_status";
                    dgvResidentTable.DataSource = dSet.Tables[0];
                }
                connection.Close();
            }
        }
        private void BlotterTable()
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_blotter", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                {
                    DataSet dSet = new DataSet();
                    sqlDA.Fill(dSet);
                    dgvBlotter.AutoGenerateColumns = false;
                    dgvBlotter.ColumnCount = 17;
                    dgvBlotter.Columns[0].DataPropertyName = "blotterID";
                    dgvBlotter.Columns[1].DataPropertyName = "fullname";
                    dgvBlotter.Columns[2].DataPropertyName = "purok";
                    dgvBlotter.Columns[3].DataPropertyName = "age";
                    dgvBlotter.Columns[4].DataPropertyName = "sex";
                    dgvBlotter.Columns[5].DataPropertyName = "civil_status";
                    dgvBlotter.Columns[6].DataPropertyName = "contact_no";
                    dgvBlotter.Columns[7].DataPropertyName = "incident_type";
                    dgvBlotter.Columns[8].DataPropertyName = "incident_date";
                    dgvBlotter.Columns[9].DataPropertyName = "incident_time";
                    dgvBlotter.Columns[10].DataPropertyName = "date_filed";
                    dgvBlotter.Columns[11].DataPropertyName = "incident_place";
                    dgvBlotter.Columns[12].DataPropertyName = "complainant_name";
                    dgvBlotter.Columns[13].DataPropertyName = "suspect_identity";
                    dgvBlotter.Columns[14].DataPropertyName = "incident_narrative";
                    dgvBlotter.DataSource = dSet.Tables[0];
                    dgvBlotter.Refresh();
                }
                connection.Close();
            }
        }
        private void ClearanceTable()
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_clearance", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                {

                    DataTable dSet = new DataTable();
                    sqlDA.Fill(dSet);
                    dgvClearanceLogs.DataSource = null;
                    dgvClearanceLogs.AutoGenerateColumns = false;
                    dgvClearanceLogs.ColumnCount = 8;
                    dgvClearanceLogs.Columns[0].DataPropertyName = "";
                    dgvClearanceLogs.Columns[1].DataPropertyName = "orNumber";
                    dgvClearanceLogs.Columns[2].DataPropertyName = "fullname";
                    dgvClearanceLogs.Columns[3].DataPropertyName = "clearance_type";
                    dgvClearanceLogs.Columns[4].DataPropertyName = "clearance_purpose";
                    dgvClearanceLogs.Columns[5].DataPropertyName = "date";
                    dgvClearanceLogs.DataSource = dSet;
                    dgvClearanceLogs.Refresh();
                }
                connection.Close();
            }
        }
        private void SettlementTable()
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_settlement", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                {
                    dgvSettlement.DataSource = null;
                    dgvSettlement.AutoGenerateColumns = false;
                    dgvSettlement.ColumnCount = 5;
                    DataTable dSet = new DataTable();
                    sqlDA.Fill(dSet);
                    dgvSettlement.Columns[0].DataPropertyName = "settleID";
                    dgvSettlement.Columns[1].DataPropertyName = "blotterNo";
                    dgvSettlement.Columns[2].DataPropertyName = "fullname";
                    dgvSettlement.Columns[3].DataPropertyName = "complainant_name";
                    dgvSettlement.Columns[4].DataPropertyName = "status";
                    dgvSettlement.DataSource = dSet;
                    dgvSettlement.Refresh();
                }
                connection.Close();
            }
        }
        private void BusinessClearanceTable()
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_businessclearance", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                {
                    dgvBusinessClearance.DataSource = null;
                    dgvBusinessClearance.AutoGenerateColumns = false;
                    dgvBusinessClearance.ColumnCount = 8;
                    DataTable dSet = new DataTable();
                    sqlDA.Fill(dSet);
                    dgvBusinessClearance.Columns[0].DataPropertyName = "orNumber";
                    dgvBusinessClearance.Columns[1].DataPropertyName = "permitNumber";
                    dgvBusinessClearance.Columns[2].DataPropertyName = "residentID";
                    dgvBusinessClearance.Columns[3].DataPropertyName = "ownersName";
                    dgvBusinessClearance.Columns[4].DataPropertyName = "ownersAddress";
                    dgvBusinessClearance.Columns[5].DataPropertyName = "businessName";
                    dgvBusinessClearance.Columns[6].DataPropertyName = "businessAddress";
                    dgvBusinessClearance.Columns[7].DataPropertyName = "businessNature";
                    dgvBusinessClearance.DataSource = dSet;
                    dgvBusinessClearance.Refresh();
                }
                connection.Close();
            }
        }
        private void DeceasedResidentTable()
        {
            byte dead = 0;
            using (var connection = new MySqlConnection(connectionString))
            using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_resident WHERE isDead = @isDead", connection))
            {
                selectQuery.Parameters.AddWithValue("@isDead", dead);
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(selectQuery))
                {
                    DataSet dSet = new DataSet();
                    sqlDA.Fill(dSet);
                    dgvDeceasedResidentTable.AutoGenerateColumns = false;
                    dgvDeceasedResidentTable.ColumnCount = 15;
                    dgvDeceasedResidentTable.Columns[0].DataPropertyName = "residentID";
                    dgvDeceasedResidentTable.Columns[1].DataPropertyName = "fullname";
                    dgvDeceasedResidentTable.Columns[2].DataPropertyName = "sex";
                    dgvDeceasedResidentTable.Columns[3].DataPropertyName = "age";
                    dgvDeceasedResidentTable.Columns[4].DataPropertyName = "civil_status";
                    dgvDeceasedResidentTable.Columns[5].DataPropertyName = "occupation";
                    dgvDeceasedResidentTable.Columns[6].DataPropertyName = "address";
                    dgvDeceasedResidentTable.Columns[7].DataPropertyName = "nationality";
                    dgvDeceasedResidentTable.Columns[8].DataPropertyName = "religion";
                    dgvDeceasedResidentTable.Columns[9].DataPropertyName = "birthdate";
                    dgvDeceasedResidentTable.Columns[10].DataPropertyName = "contact_no";
                    dgvDeceasedResidentTable.Columns[11].DataPropertyName = "category";
                    dgvDeceasedResidentTable.Columns[12].DataPropertyName = "purok";
                    dgvDeceasedResidentTable.Columns[13].DataPropertyName = "voter_status";
                    dgvDeceasedResidentTable.Columns[14].DataPropertyName = "vaccination_status";
                    dgvDeceasedResidentTable.DataSource = dSet.Tables[0];
                }
                connection.Close();
            }
        }

        private void searchResident(string valueToSearch1)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var searchQuery = new MySqlCommand("SELECT * FROM tbl_resident WHERE CONCAT(residentID,fullname,address,purok)like'%" + valueToSearch1 + "%'", connection))
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
        private void searchBlotters(string valueToSearch2)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var searchQuery = new MySqlCommand("SELECT * FROM tbl_blotter WHERE CONCAT(blotterID,fullname,complainant_name)like'%" + valueToSearch2 + "%'", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(searchQuery))
                {
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    dgvBlotter.DataSource = table;
                }
                connection.Close();
            }
        }
        private void searchIssuedCertificates(string valueToSearch3)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var searchQuery = new MySqlCommand("SELECT * FROM tbl_clearance WHERE CONCAT(orNumber,fullname)like'%" + valueToSearch3 + "%'", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(searchQuery))
                {
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    dgvClearanceLogs.DataSource = table;
                }
                connection.Close();
            }
        }
        private void searchSettlement(string valueToSearch4)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var searchQuery = new MySqlCommand("SELECT * FROM tbl_settlement WHERE CONCAT(settleID,blotterNo,fullname,complainant_name,status)like'%" + valueToSearch4 + "%'", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(searchQuery))
                {
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    dgvSettlement.DataSource = table;
                }
                connection.Close();
            }
        }
        private void searchBusinessClearance(string valueToSearch5)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var searchQuery = new MySqlCommand("SELECT * FROM tbl_businessclearance WHERE CONCAT(orNumber,permitNumber,residentID,ownersName)like'%" + valueToSearch5 + "%'", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(searchQuery))
                {
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    dgvBusinessClearance.DataSource = table;
                }
                connection.Close();
            }
        }

        private void frmRecords_Load(object sender, EventArgs e)
        {
            ResidentTable();
            BlotterTable();
            ClearanceTable();
            SettlementTable();
            BusinessClearanceTable();
            DeceasedResidentTable();
        }



        private void dgvClearanceLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvClearanceLogs.Rows[e.RowIndex].Cells["rn3"].Value = (e.RowIndex + 1).ToString();
        }

        private void toolStripBackup_Click(object sender, EventArgs e)
        {
            sfDialog.Filter = "SQL Text File(.sql)|*.sql";
            sfDialog.FileName = "My Text File";
            sfDialog.Title = "";
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        using (MySqlBackup backup = new MySqlBackup(command))
                        {
                            string path = sfDialog.FileName;
                            BinaryWriter writer = new BinaryWriter(File.Create(path));
                            writer.Write("Example Text File");
                            writer.Dispose();
                            command.Connection = connection;
                            backup.ExportToFile(path);
                        }
                    }
                    connection.Close();
                    MessageBox.Show("Database backed up successfully!", "Notice", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }
        private void toolStripRestore_Click(object sender, EventArgs e)
        {
            ofDialog.FileName = "";
            ofDialog.Filter = "SQL Text File(.sql)|*.sql";
            try
            {
                if (ofDialog.ShowDialog() == DialogResult.OK)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand())
                        {
                            using (MySqlBackup import = new MySqlBackup(command))
                            {
                                string path = ofDialog.FileName;
                                command.Connection = connection;
                                import.ImportFromFile(path);
                            }
                        }
                        connection.Close();
                        MessageBox.Show("Database restored successfully!", "Notice", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid file format!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void TSMIResidentsTable_Click(object sender, EventArgs e)
        {
            if (dgvResidentTable.Rows.Count < 1)
            {
                MessageBox.Show("No records to export!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (dgvResidentTable.Rows.Count > 0)
            {
                sfDialog.FileName = "";
                sfDialog.Filter = "Excel (.xlsx)|  *.xlsx";
                bool fileError = false;
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfDialog.FileName))
                    {
                        try
                        {
                            File.Delete(sfDialog.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk. " + ex.Message, "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                    }
                }
                if (!fileError) // if file name has not existed, this block will run.
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Application.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel.Worksheet workSheet = null;
                        workSheet = workBook.Sheets["Sheet1"];
                        workSheet = workBook.ActiveSheet;
                        workSheet.Name = "RESIDENTS RECORDS";
                        workSheet.Application.ActiveWindow.SplitRow = 1;
                        workSheet.Application.ActiveWindow.FreezePanes = true;

                        for (int i = 1; i < dgvResidentTable.Columns.Count + 1; i++)
                        {
                            workSheet.Cells[1, i] = dgvResidentTable.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgvResidentTable.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvResidentTable.Columns.Count; j++)
                            {
                                workSheet.Cells[i + 2, j + 1] = dgvResidentTable.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                        workSheet.Columns.AutoFit();
                        workSheet.PageSetup.RightFooter = "GENERATED AT " + date;
                        workBook.SaveAs(sfDialog.FileName);
                        excelApp.Quit();
                        ReleaseObject(workSheet);
                        ReleaseObject(workBook);
                        ReleaseObject(excelApp);

                        MessageBox.Show("Records exported successfully!", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
        private void TSMIBlottersTable_Click(object sender, EventArgs e)
        {
            if (dgvBlotter.Rows.Count < 1)
            {
                MessageBox.Show("No records to export!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (dgvBlotter.Rows.Count > 0)
            {
                sfDialog.FileName = "";
                sfDialog.Filter = "Excel (.xlsx)| *.xlsx";
                bool fileError = false;
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfDialog.FileName))
                    {
                        try
                        {
                            File.Delete(sfDialog.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk. " + ex.Message, "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                    }
                }
                if (!fileError) // if file name has not existed, this block will run.
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Application.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel.Worksheet workSheet = null;

                        workSheet = workBook.Sheets["Sheet1"];
                        workSheet = workBook.ActiveSheet;
                        workSheet.Name = "BLOTTER RECORDS";
                        workSheet.Application.ActiveWindow.SplitRow = 1;
                        workSheet.Application.ActiveWindow.FreezePanes = true;

                        for (int i = 1; i < dgvBlotter.Columns.Count + 1; i++)
                        {
                            workSheet.Cells[1, i] = dgvBlotter.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgvBlotter.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvBlotter.Columns.Count; j++)
                            {
                                workSheet.Cells[i + 2, j + 1] = dgvBlotter.Rows[i].Cells[j].Value?.ToString();
                            }

                        }
                        workSheet.Columns.AutoFit();
                        workSheet.PageSetup.RightFooter = "GENERATED AT " + date;
                        workBook.SaveAs(sfDialog.FileName);
                        excelApp.Quit();

                        ReleaseObject(workSheet);
                        ReleaseObject(workBook);
                        ReleaseObject(excelApp);
                        MessageBox.Show("Records exported successfully!", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
        private void TSMISettlementsTable_Click(object sender, EventArgs e)
        {
            if (dgvSettlement.Rows.Count < 1)
            {
                MessageBox.Show("No records to export!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (dgvSettlement.Rows.Count > 0)
            {
                sfDialog.FileName = "";
                sfDialog.Filter = "Excel (.xlsx)| *.xlsx";
                bool fileError = false;
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfDialog.FileName))
                    {
                        try
                        {
                            File.Delete(sfDialog.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk. " + ex.Message, "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                    }
                }
                if (!fileError) // if file name has not existed, this block will run.
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Application.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel.Worksheet workSheet = null;

                        workSheet = workBook.Sheets["Sheet1"];
                        workSheet = workBook.ActiveSheet;
                        workSheet.Name = "SETTLEMENTS RECORDS";
                        workSheet.Application.ActiveWindow.SplitRow = 1;
                        workSheet.Application.ActiveWindow.FreezePanes = true;

                        for (int i = 1; i < dgvSettlement.Columns.Count + 1; i++)
                        {
                            workSheet.Cells[1, i] = dgvSettlement.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgvSettlement.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvSettlement.Columns.Count; j++)
                            {
                                workSheet.Cells[i + 2, j + 1] = dgvSettlement.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                        workSheet.Columns.AutoFit();
                        workSheet.PageSetup.RightFooter = "GENERATED AT " + date;
                        workBook.SaveAs(sfDialog.FileName);
                        excelApp.Quit();
                        ReleaseObject(workSheet);
                        ReleaseObject(workBook);
                        ReleaseObject(excelApp);
                        MessageBox.Show("Records exported successfully!", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "RESIDENTS")
            {
                txtSearchBar.Visible = true;
                txtSearchBarBlotters.Visible = false;
                txtSearchBarSettlement.Visible = false;
                txtSearchBarCertificate.Visible = false;
                txtSearchBarBusinessClearance.Visible = false;
            }
            else if (tabControl1.SelectedTab.Text == "BLOTTERS")
            {
                txtSearchBar.Visible = false;
                txtSearchBarBlotters.Visible = true;
                txtSearchBarSettlement.Visible = false;
                txtSearchBarCertificate.Visible = false;
                txtSearchBarBusinessClearance.Visible = false;

            }
            else if (tabControl1.SelectedTab.Text == "SETTLEMENT RECORDS")
            {
                txtSearchBar.Visible = false;
                txtSearchBarBlotters.Visible = false;
                txtSearchBarSettlement.Visible = true;
                txtSearchBarCertificate.Visible = false;
                txtSearchBarBusinessClearance.Visible = false;

            }
            else if (tabControl1.SelectedTab.Text == "ISSUED CERTIFICATES")
            {
                txtSearchBar.Visible = false;
                txtSearchBarBlotters.Visible = false;
                txtSearchBarSettlement.Visible = false;
                txtSearchBarCertificate.Visible = true;
                txtSearchBarBusinessClearance.Visible = false;
            }
            else if (tabControl1.SelectedTab.Text == "ISSUED BUSINESS CERTIFICATE")
            {
                txtSearchBar.Visible = false;
                txtSearchBarBlotters.Visible = false;
                txtSearchBarSettlement.Visible = false;
                txtSearchBarCertificate.Visible = false;
                txtSearchBarBusinessClearance.Visible = true;
            }
            else if (tabControl1.SelectedTab.Text == "DECEASED RESIDENTS")
            {
                txtSearchBar.Visible = false;
                txtSearchBarBlotters.Visible = false;
                txtSearchBarSettlement.Visible = false;
                txtSearchBarCertificate.Visible = false;
                txtSearchBarBusinessClearance.Visible = false;
                // INSERT CODE HERE
            }
        }
        private void txtSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valueToSearch = txtSearchBar.Text.ToString();
            if (tabControl1.SelectedTab.Text == "RESIDENTS")
            {
                searchResident(valueToSearch);
            }
            else
            {
                Console.WriteLine("Do Nothing");
            }
        }
        private void txtSearchBarBlotters_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valueToSearch = txtSearchBarBlotters.Text.ToString();
            if (tabControl1.SelectedTab.Text == "BLOTTERS")
            {
                searchBlotters(valueToSearch);
            }
            else
            {
                Console.WriteLine("Do Nothing");
            }
        }
        private void txtSearchBarSettlement_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valueToSearch = txtSearchBarSettlement.Text.ToString();
            if (tabControl1.SelectedTab.Text == "SETTLEMENT RECORDS")
            {
                searchSettlement(valueToSearch);
            }
            else
            {
                Console.WriteLine("Do Nothing");
            }
        }
        private void txtSearchBarCertificate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valueToSearch = txtSearchBarCertificate.Text.ToString();
            if (tabControl1.SelectedTab.Text == "ISSUED CERTIFICATES")
            {
                searchIssuedCertificates(valueToSearch);
            }
            else
            {
                Console.WriteLine("Do Nothing");
            }
        }
        private void txtSearchBarBusinessClearance_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valueToSearch = txtSearchBarBusinessClearance.Text.ToString();
            if (tabControl1.SelectedTab.Text == "ISSUED BUSINESS CERTIFICATE")
            {
                searchBusinessClearance(valueToSearch);
            }
            else
            {
                Console.WriteLine("Do Nothing");
            }
        }


    }
}



