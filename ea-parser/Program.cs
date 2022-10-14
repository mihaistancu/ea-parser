using Dapper;
using System.Data.SqlClient;

namespace ea_parser
{
    class Program
    {
        private const string ConnectionString = "server=.;database=EESSI-Data-Model-v4.2.0;trusted_connection=true";
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<string>("select * from t_attribute");
            }
        }
    }
}
