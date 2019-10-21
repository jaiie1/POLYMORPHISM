using System;

namespace AdvanceCsharp
{
    public class DbCommand
    {
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null && instruction == null)
                throw new InvalidOperationException("Null connection can not provided.");
        }

        public void Execute(DbConnection dbConnection, string instruction)
        {
            dbConnection.Open();
            Console.WriteLine(instruction);
            dbConnection.Closed();
        }
    }
}