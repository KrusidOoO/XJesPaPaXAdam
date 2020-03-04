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
            using (SqlConnection conn = new SqlConnection("Server=.;Database=gotta learn sql and it has to be fast; Trusted_Connection=true;"))
            {
                conn.Open();
                Console.WriteLine("Connection established.");
                Menu(conn);
            }
        }

        static void Menu(SqlConnection conn)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Show List");
                Console.WriteLine("2. Create Item");
                Console.WriteLine("3. Create Article");
                Console.WriteLine("4. Create Location");
                Console.WriteLine("5. Update Item");
                Console.WriteLine("6. Update Location");
                Console.WriteLine("7. Update Article");
                Console.WriteLine("8. Delete Items");
                Console.WriteLine("9. Delete Article");
                Console.WriteLine("0. Delete Locatoin");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.Clear();

                if (choice.KeyChar == '1')
                {
                    ShowList(conn);
                }

                else if (choice.KeyChar == '2')
                {
                    CreateItem(conn);
                }

                else if(choice.KeyChar == '3')
                {
                    CreateArticle(conn);
                }

                else if (choice.KeyChar == '4')
                {
                    CreateLocation(conn);
                }
                
                else if (choice.KeyChar == '5')
                {
                    UpdateLocation(conn);
                }

                else if (choice.KeyChar == '6')
                {
                    UpdateArticle(conn);
                }

                else if (choice.KeyChar == '7')
                {
                    UpdateValues(conn);
                }
              
                else if (choice.KeyChar == '8')
                {
                    DeleteItem(conn);
                }

                else if (choice.KeyChar == '9')
                {
                    DeleteArticle(conn);
                }
                
                
                else if (choice.KeyChar == '0')
                {
                    DeleteLocation(conn);
                }


            }
        }
        static void ShowList(SqlConnection conn)
        {
            Console.Clear();
            string sql = "SELECT StockItem.Id, Article.Name, Amount, Location FROM StockItem Join Article on aid = Article.Id join Location on lid = Location.Id;";
            Console.WriteLine("Reading data from table, press any key to continue...");

            Console.WriteLine("Items in system");
            Console.WriteLine("".PadLeft(120, '-'));
            Console.Write("ID");
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("Name");
            Console.SetCursorPosition(32, Console.CursorTop);
            Console.Write("Amount");
            Console.SetCursorPosition(40, Console.CursorTop);
            Console.WriteLine("Location");
            Console.WriteLine("".PadLeft(120, '-'));

            using (SqlCommand command = new SqlCommand(sql, conn))
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.Write(reader.GetInt32(0));
                        Console.SetCursorPosition(5, Console.CursorTop);
                        Console.Write(reader.GetString(1));
                        Console.SetCursorPosition(32, Console.CursorTop);
                        Console.Write(reader.GetInt32(2));
                        Console.SetCursorPosition(40, Console.CursorTop);
                        Console.WriteLine(reader.GetString(3));
                    }
                    Console.ReadKey(true);

                }

            }
        }

        static void ShowArticle(SqlConnection conn)
        {
            string sql = "SELECT * FROM Article Order By id;";
            Console.WriteLine("Article in system");
            Console.WriteLine("".PadLeft(120, '-'));
            Console.Write("ID");
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.WriteLine("Article");
            Console.WriteLine("".PadLeft(120, '-'));

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.Write(reader.GetInt32(0));
                        Console.SetCursorPosition(5, Console.CursorTop);
                        Console.WriteLine(reader.GetString(1));
                    }
                }
            }
        }

        static void ShowLocation(SqlConnection conn)
        {
            string sql = "SELECT * FROM Location Order By id;";
            Console.WriteLine("Location in system");
            Console.WriteLine("".PadLeft(120, '-'));
            Console.Write("ID");
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.WriteLine("Location");
            Console.WriteLine("".PadLeft(120, '-'));

            using (SqlCommand command = new SqlCommand(sql, conn))
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.Write(reader.GetInt32(0));
                        Console.SetCursorPosition(5, Console.CursorTop);
                        Console.WriteLine(reader.GetString(1));
                    }
                }
            }
        }

        static void CreateItem(SqlConnection conn)
        {
            string sql;
            ShowList(conn);
           

            ShowArticle(conn);
            string article;
            do
                article = Console.ReadLine();
            while (!int.TryParse(article, out _));


            Console.Clear();
            Console.WriteLine("Amount");
            string amount = Console.ReadLine();


            Console.Clear();
            ShowLocation(conn);
            string location;
            do
                location = Console.ReadLine();
            while (!int.TryParse(location, out _));

            sql = "Insert Into StockItem Values( '" + article + "', '" + location + "', '" + amount + "');";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        static void UpdateValues(SqlConnection conn)
        {
            ShowList(conn);

            Console.WriteLine("ID of item you would like to change");
            string ID;
            do
                ID = Console.ReadLine();
            while (!int.TryParse(ID, out _));

            string column;
            Console.WriteLine("column you would like to change");
            do
                column = Console.ReadLine();
            while (column.ToLower() != "id" || column.ToLower() != "name" || column.ToLower() != "location" || column.ToLower() != "id" || column.ToLower() != "article");

            Console.WriteLine("Values you would like to change it to");
            string values = Console.ReadLine();

            try
            {
                string sql = "update StockItem set " + column + " = '" + values + "' where id = " + ID;

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                string sql = "update StockItem set " + column + " = " + values + " where id = " + ID;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        static void DeleteItem(SqlConnection conn)
        {
            ShowList(conn);

            Console.WriteLine("ID of item you would like to Delete");
            string ID;
            do
                ID = Console.ReadLine();
            while (!int.TryParse(ID, out _));

            string sql = "Delete from stockitem where id =" + ID;

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

        }

        static void CreateArticle(SqlConnection conn)
        {
            ShowArticle(conn);

            Console.WriteLine("Name of new Article");
            string sql = $"Insert Into article values('{Console.ReadLine()}')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        static void UpdateArticle(SqlConnection conn)
        {
            ShowArticle(conn);

            Console.WriteLine("ID of Article you would like to update");
            string id = Console.ReadLine();
            Console.WriteLine("New value");
            string value = Console.ReadLine();
            string sql = $"update article set name={value} where {id}=article.id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        static void DeleteArticle(SqlConnection conn)
        {
            ShowArticle(conn);

            Console.WriteLine("ID of item you would like to Delete");
            string ID;
            do
                ID = Console.ReadLine();
            while (!int.TryParse(ID, out _));

            string sql = "Delete from Article where id =" + ID;

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

        }

        static void CreateLocation(SqlConnection conn)
        {
            ShowLocation(conn);

            Console.WriteLine("Name of new Location");
            string sql = $"Insert Into location values('{Console.ReadLine()}')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        static void UpdateLocation(SqlConnection conn)
        {
            ShowLocation(conn);

            Console.WriteLine("ID of Location you would like to update");
            string id = Console.ReadLine();
            Console.WriteLine("New value");
            string value = Console.ReadLine();
            string sql = $"update location set name={value} where {id}=location.id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        static void DeleteLocation(SqlConnection conn)
        {
            ShowLocation(conn);

            Console.WriteLine("ID of item you would like to Delete");
            string ID;
            do
                ID = Console.ReadLine();
            while (!int.TryParse(ID, out _));

            string sql = "Delete from location where id =" + ID;

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

        }
    }

}
