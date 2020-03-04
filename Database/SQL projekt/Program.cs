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
           using (SqlConnection connection = new SqlConnection("Server=.;Database=gotta learn sql and it has to be fast; Trusted_Connection=true;"))
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

                Console.WriteLine("1. Show List");
                Console.WriteLine("2. Create A New Item");
                Console.WriteLine("3. Change Item Values");
                Console.WriteLine("4. Delete Items");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.Clear();

                if (choice.KeyChar == '1')
                {
                    ShowList(conn);
                }
                if (choice.KeyChar == '2')
                {
                    CreateItem(conn);
                }
                if (choice.KeyChar == '3')
                {
                    ChangeValues(conn);
                }
                if (choice.KeyChar == '4')
                {
                    DeleteItem(conn);
                }

            }
        }
        static void ShowList(SqlConnection conn)
        {
            Console.Clear();
            string sql = "SELECT StockItem.Id, StockItem.Name, Amount, Article.Name as 'Article', Location.Name as 'Location' FROM StockItem Join Article on StockItem.article = Article.Id join Location on StockItem.location = Location.Id;";
            Console.WriteLine("Reading data from table, press any key to continue...");

            Console.WriteLine("Items in system");
            Console.WriteLine("".PadLeft(120, '-'));
            Console.Write("ID");
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("Name");
            Console.SetCursorPosition(32, Console.CursorTop);
            Console.Write("Amount");
            Console.SetCursorPosition(40, Console.CursorTop);
            Console.WriteLine("Article");
            Console.WriteLine("".PadLeft(120, '-'));





        }
    }
}
