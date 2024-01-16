using Microsoft.Data.SqlClient;
using System.Data;

namespace DemoBasic.Controllers.Conexion
{
    public class Conexion
    {
        private string connectionString = "Data Source=PC_Scott;Initial Catalog=CarniceriaRiguero;Integrated Security=True;Encrypt=False";

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
