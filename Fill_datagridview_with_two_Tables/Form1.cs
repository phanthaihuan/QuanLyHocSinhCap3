using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Huan
{
    public partial class Form1 : Form
    {
        //String strConnectionString = String.Format(@"Data Source=113.161.72.212,1434;Initial Catalog=h;User ID=h;Password=h;");
        public static string strConnectionString = @"Data Source = 113.161.72.212,1434; Initial Catalog = h; User ID = h; Password=h;";

        SqlConnection connection = new SqlConnection("Data Source=113.161.72.212,1434;Initial Catalog=h;User ID=h;Password=h;");

        public static void ShowSqlException(string connectionString)
        {
            string queryString = "EXECUTE NonExistantStoredProcedure";
            StringBuilder errorMessages = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString());
                    
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            String query = "select AdminLogin.ID, AdminLogin.AdminName, ProductDB.ProductName from AdminLogin left join ProductDB on AdminLogin.ID = ProductDB.ID";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            HUAN.ShowSqlException(strConnectionString);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HUAN.TestConnection();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
