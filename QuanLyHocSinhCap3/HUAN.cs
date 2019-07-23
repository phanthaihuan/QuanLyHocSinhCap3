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

namespace ns_Huan
{
    public static class HUAN
    {
        public static string connectionString = "Data Source=113.161.72.212,1434;Initial Catalog=h;User ID=h;Password=h;";

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

        // Test DB Connection
        public static void TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection to database is done!");
                }
            }
            catch (SqlException ex)
            {
                ShowSqlException(ex);
            }
            finally
            {

            }
        }


        // SqlConnection
        // try using catch;;


        // This function displays Sql Error Message: 23/07/2019
        // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlexception?redirectedfrom=MSDN&view=netframework-4.8
        public static void ShowSqlException(SqlException ex)
        {
            StringBuilder errorMessages = new StringBuilder();
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
