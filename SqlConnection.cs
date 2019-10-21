using System;

namespace AdvanceCsharp
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Closed()
        {
            Console.WriteLine("Closed SqlConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Open SqlConnection.");
        }
    }
}