using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BMIS
{
    class DataClass
    {
        public MySqlConnection connection;
        public DataClass()
        {
            string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
            connection = new MySqlConnection(connectionString);
        }
    }
    class User : DataClass
    {
        /* Getters & Setters (For Login) */
        public string Username { get; set; }
        public string Password { get; set; }
        public Int32 Role { get; set; }

        /* METHODS STARTS HERE */
        public bool Login_Verification()
        {
            bool check = true;
            using (var command = new MySqlCommand("SELECT * FROM credentials WHERE BINARY username=@username AND BINARY password=@password", connection))
            {
                connection.Open();
                Console.WriteLine("Connection Pool Open!");
                MySqlDataReader Reader;
                try
                {
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@password", Password);
                    Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {
                        //Get the role number and pass the data to  "public Int32 Role { get; set; }"
                        Role = Reader.GetInt32("role");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                {
                }
                connection.Close();
                Console.WriteLine("Connection Pool Closed!");
            }
            return check;
        }
    }
}
