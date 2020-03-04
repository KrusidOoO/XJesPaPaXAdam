using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace SQL_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
           using (SqlConnection connection = new SqlConnection("Server=.;Database=gotta learn sql and it has to be fast"))
            {
                connection.Open();
                Console.WriteLine("Connection established.");

            }
        }

        static void MainMenu(SqlConnection connection)
        {
            while(true)
            {
                Console.Clear();

                Console.WriteLine("Make A New List");
                Console.WriteLine("Create A New Item");
                Console.WriteLine("Change Item Values");
                Console.WriteLine("Delete Items:");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
