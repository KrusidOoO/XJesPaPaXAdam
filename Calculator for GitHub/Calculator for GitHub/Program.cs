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
            Console.WriteLine();
            Console.WriteLine("1. Add two numbers together");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Multiply two numbers");
            Console.WriteLine("4. Divide two numbers");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Please enter the number of the action you wish to perform");
            mitvalg = Console.ReadKey(true);
            if (mitvalg.KeyChar == '1')
            {
                Console.Clear();
                Console.WriteLine("You have now chosen to add two digits together");
                Console.WriteLine();
                Console.WriteLine("Please enter your first digit");
                string firstNumber1 = Console.ReadLine();
                firstNumber = Convert.ToInt32(firstNumber1);
                Console.WriteLine();
                Console.WriteLine("Please enter your second digit");
                string secondNumber2 = Console.ReadLine();
                secondNumber = Convert.ToInt32(secondNumber2);
                Console.WriteLine();
                int sum = firstNumber + secondNumber;
                Console.WriteLine("The result is " + sum.ToString());
                Console.ReadKey();
            }
            if(mitvalg.KeyChar=='2')
            {
                Console.Clear();
            }
        }
    }
}
