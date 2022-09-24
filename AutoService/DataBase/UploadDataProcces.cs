using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace AutoService.DataBase
{
    public static class UploadDataProcces
    {
        public static void uploadeAllPeopleFromDB(SqlConnection connection, DataGrid dataField)
        {
            string queryFindAll = "SELECT * FROM Person";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryFindAll, connection))
            {
                DataTable table = new DataTable();

                dataAdapter.Fill(table);

                dataField.ItemsSource = table.DefaultView;

                connection.Close();
            }
        }
    }
}
