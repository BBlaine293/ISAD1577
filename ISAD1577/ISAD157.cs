using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISAD1577
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string connectionString = "SERVER=" + DatabaseConnection.SERVER + ";" +
                   "DATABASE=" + DatabaseConnection.DATABASE_NAME + ";" + "UID=" +
                  DatabaseConnection.USER_NAME + ";" + "PASSWORD=" +
                  DatabaseConnection.PASSWORD + ";" + "SslMode=" +
                  DatabaseConnection.SslMode + ";";

                using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM soft562_bmbennetts.USER";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);

                    dataGridViewCustomer.DataSource = customerDataTable;

                }



            }
            else if (comboBox1.SelectedIndex == 1)
            {
                string connectionString = "SERVER=" + DatabaseConnection.SERVER + ";" +
                  "DATABASE=" + DatabaseConnection.DATABASE_NAME + ";" + "UID=" +
                 DatabaseConnection.USER_NAME + ";" + "PASSWORD=" +
                 DatabaseConnection.PASSWORD + ";" + "SslMode=" +
                 DatabaseConnection.SslMode + ";";

                using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM soft562_bmbennetts.Friendship";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable FriendshipDataTable = new DataTable();
                    sqlDA.Fill(FriendshipDataTable);

                    dataGridViewFriendship.DataSource = FriendshipDataTable;
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                string connectionString = "SERVER=" + DatabaseConnection.SERVER + ";" +
                 "DATABASE=" + DatabaseConnection.DATABASE_NAME + ";" + "UID=" +
                DatabaseConnection.USER_NAME + ";" + "PASSWORD=" +
                DatabaseConnection.PASSWORD + ";" + "SslMode=" +
                DatabaseConnection.SslMode + ";";

                using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM soft562_bmbennetts.Messages";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable MessagesDataTable = new DataTable();
                    sqlDA.Fill(MessagesDataTable);

                    dataGridViewMessages.DataSource = MessagesDataTable;
                }

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                string connectionString = "SERVER=" + DatabaseConnection.SERVER + ";" +
                 "DATABASE=" + DatabaseConnection.DATABASE_NAME + ";" + "UID=" +
                DatabaseConnection.USER_NAME + ";" + "PASSWORD=" +
                DatabaseConnection.PASSWORD + ";" + "SslMode=" +
                DatabaseConnection.SslMode + ";";

                using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM soft562_bmbennetts.Education";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable EducationDataTable = new DataTable();
                    sqlDA.Fill(EducationDataTable);

                    dataGridViewEducation.DataSource = EducationDataTable;
                }
            }
            else
            {
                string connectionString = "SERVER=" + DatabaseConnection.SERVER + ";" +
                 "DATABASE=" + DatabaseConnection.DATABASE_NAME + ";" + "UID=" +
                DatabaseConnection.USER_NAME + ";" + "PASSWORD=" +
                DatabaseConnection.PASSWORD + ";" + "SslMode=" +
                DatabaseConnection.SslMode + ";";

                using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM soft562_bmbennetts.WorkPlace";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable WorkplaceDataTable = new DataTable();
                    sqlDA.Fill(WorkplaceDataTable);

                    dataGridViewWorkplace.DataSource = WorkplaceDataTable;
                }
            }
        }
    }
}
