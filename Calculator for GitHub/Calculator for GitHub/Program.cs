using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_for_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            ConsoleKeyInfo mitvalg;
            Console.WriteLine("Hello there");
            Console.WriteLine("1. Læg 2 tal sammen");
            Console.WriteLine("2. Træk 2 tal fra hinanden");
            Console.WriteLine("3. Gang 2 tal med hianden");
            Console.WriteLine("4. Divider 2 tal med hinanden");
            mitvalg = Console.ReadKey(true);
            if (mitvalg.KeyChar == '1')
            {
                Console.WriteLine("You have now chosen to add two digits together");
                Console.WriteLine();
                Console.WriteLine("Please enter your first digit");
                string firstNumber1 = Console.ReadLine();
                firstNumber = Convert.ToInt32(firstNumber1);
                Console.WriteLine(firstNumber);
                Console.WriteLine("Please enter your second digit");
                string secondNumber2 = Console.ReadLine();
                secondNumber = Convert.ToInt32(secondNumber2);
                Console.WriteLine(secondNumber);
            }
            Console.ReadKey();
        }
    }
}
