using System.IO;
using System.Threading;

namespace AdvanceCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionstring = "ConnectionString";
            var intruction = "Select from DbConnection";

            var SqlConnection = new SqlConnection(connectionstring);
            SqlConnection.Open();
            SqlConnection.Closed();

            var oracelSql = new OracleConnection(connectionstring);
            oracelSql.Open();
            oracelSql.Closed();
            var DbConn = new DbCommand(SqlConnection, intruction);
            DbConn.Execute(oracelSql, intruction);


        }


        public static void AbsctratClass()
        {
            var circel = new Circle();
            circel.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
