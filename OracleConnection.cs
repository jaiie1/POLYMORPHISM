using System;

namespace AdvanceCsharp
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            
        }
        public override void Closed()
        {
            Console.WriteLine("Closed OracelConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Open OracelConnetion");
        }
    }


}