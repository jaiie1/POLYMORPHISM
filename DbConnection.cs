using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace AdvanceCsharp
{
    public abstract class DbConnection
    {
        public string ConnectionsString { get; set; }
        public TimeSpan TimeOut { get; set; }
      

        public DbConnection(string connectionString)
        {
            
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                ConnectionsString = connectionString;
            }
            else {
                Console.WriteLine("Connection can not be Null or empty string");
            }

            if (TimeOut.Seconds == 200)
            {
                Console.WriteLine("SQL connection is timeout");
            }
            
        }

        public abstract void Open();




        public abstract void Closed();







    }

    
}