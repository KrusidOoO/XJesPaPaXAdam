using System;

namespace Logiske_Operatorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; string password;
            Console.WriteLine("Input your username here");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Input your password here");
            password = Console.ReadLine();
            Console.WriteLine();
            // evaluating both expresson and returns true if all are true.
            if (name == "Steven" && password == "Steven123")
            {
                Console.Clear();
                Console.WriteLine("======================");
                Console.WriteLine("===================");
                Console.WriteLine("================");
                Console.WriteLine("Login Successful");
                Console.WriteLine("================");
                Console.WriteLine("===================");
                Console.WriteLine("======================");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("======================");
                Console.WriteLine("================");
                Console.WriteLine("Unauthorised access");
                Console.WriteLine("================");
                Console.WriteLine("======================");

            }
            Console.ReadKey();
        }
    }
}
