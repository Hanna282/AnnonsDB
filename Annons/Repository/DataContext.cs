using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Annons.Repository
{
    public class DataContext
    {
        private readonly string _connString;

        public DataContext()
        {
            _connString = ConfigurationManager.ConnectionStrings["FynditDBConn"].ConnectionString;
        }

        public DataTable ExecuteSPReturnTable(string procName, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new(_connString))
            {
                conn.Open();

                SqlCommand cmd = new(procName, conn); 
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                DataTable result = new();

                SqlDataAdapter adapter = new(cmd);
                adapter.Fill(result);

                return result;
            }
        }

        public void ExecuteSPNonQuery(string procName, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new(_connString))
            {
                conn.Open();

                SqlCommand cmd = new(procName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                cmd.ExecuteNonQuery(); 
            }
        }
    }
}
