using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace AutoService.DataBase
{
    public static class DBConnectionHelper
    {
        public static SqlConnection InitializeDBConnection()
        {
            string DBPath = Properties.Settings.Default.connection_String;

            SqlConnection DBconnection = new SqlConnection(DBPath);

            try
            {
                DBconnection.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "DB connection error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return DBconnection;
        }
    }
}
