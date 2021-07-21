using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client1 = DatabaseClient.GetInstance;
            var client2 = DatabaseClient.GetInstance;

            client1.WriteRecord();
            client2.ReadRecord();

            Console.WriteLine(client2==client1);
            Console.Read();
        }
    }

    public class DatabaseClient
    {
        private DatabaseClient()
        {
            Console.WriteLine("Connection Established with the db.");
        }

        public static DatabaseClient _instance = new DatabaseClient();
        public static DatabaseClient GetInstance => _instance;

        public void WriteRecord()
        {
            Console.WriteLine("Wrote record to the db.");
        }

        public void ReadRecord()
        {
            Console.WriteLine("Read record from the db.");
        }
    }
}
