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
                var result = connection.Query<Attribute>("select * from t_attribute");
            }
        }
    }
}

public class Attribute
{
    public int ObjectId { get; set; }
    public string Name { get; set; }
    public string Scope { get; set; }
    public string Stereotype { get; set; }
    public string Containment { get; set; }
    public bool IsStatic { get; set; }
    public bool IsCollection { get; set; }
    public bool IsOrdered { get; set; }
    public bool AllowDuplicates { get; set; }
    public string LowerBound { get; set; }
    public string UpperBound { get; set; }
    public string Container { get; set; }
    public string Notes { get; set; }
    public string Derived { get; set; }
    public int ID { get; set; }
    public int Pos { get; set; }
    public string GenOption { get; set; }
    public int Length { get; set; }
    public int Precision { get; set; }
    public int Scale { get; set; }
    public int Const { get; set; }
    public string Style { get; set; }
    public string Classifier { get; set; }
    public string Default { get; set; }
    public string Type { get; set; }
    public string ea_guid { get; set; }
    public string StyleEx { get; set; }
}
