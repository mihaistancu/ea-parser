using Dapper;
using System.Data.SqlClient;

namespace ea_parser
{
    class Program
    {
        private const string ConnectionString = "server=.;database=EESSI-Data-Model-v4.2.0;trusted_connection=true";
        private static SqlConnection connection = new SqlConnection(ConnectionString);

        static void Main(string[] args)
        {   
            connection.Open();
            var objects = Get("t_object");
            var objectProperties = Get("t_objectproperties");
            var attributes = Get("t_attribute");
            var attributeTags = Get("t_attributetag");
            var connectors = Get("t_connector");
            var connectorTags = Get("t_connectortag");
            var elementProperties = Get("elementproperties");
        }

        private static dynamic Get(string tableName)
        {
            return connection.Query<dynamic>("select * from " + tableName);
        }
    }


}
