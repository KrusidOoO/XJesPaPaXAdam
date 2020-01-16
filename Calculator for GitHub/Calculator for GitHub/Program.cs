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
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            double firstNumber = 0;
            double secondNumber = 0;
            ConsoleKeyInfo mitvalg;

            Console.WriteLine("Hello there " + name + "");
            Console.WriteLine();
            Console.WriteLine("1. Add two numbers together");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Multiply two numbers");
            Console.WriteLine("4. Divide two numbers");
            Console.WriteLine("5. Get the power of two numbers");
            Console.WriteLine("6. Get a random number");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Please enter the number of the action you wish to perform");

            mitvalg = Console.ReadKey(true);
            if (mitvalg.KeyChar == '1')
            {
                Console.WriteLine("You have now chosen to add two digits together");
                Console.WriteLine();
                Console.WriteLine("Please enter your first digit");
                string firstNumber1 = Console.ReadLine();
                firstNumber = Convert.ToDouble(firstNumber1);
                Console.WriteLine();
                Console.WriteLine("Please enter your second digit");
                string secondNumber2 = Console.ReadLine();
                secondNumber = Convert.ToDouble(secondNumber2);
                Console.WriteLine();
                double sum = firstNumber + secondNumber;
                Console.WriteLine("The result is\n=======\n " + sum.ToString());
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the application");
                Console.ReadKey();
            }
            if (mitvalg.KeyChar == '2')
            {
                Console.Clear();
                Console.WriteLine("You have now chosen to subtract two digits from eachother");
                Console.WriteLine();
                Console.WriteLine("Please enter your first digit");
                string firstNumber1 = Console.ReadLine();
                firstNumber = Convert.ToDouble(firstNumber1);
                Console.WriteLine();
                Console.WriteLine("Please enter your second digit");
                string secondNumber2 = Console.ReadLine();
                secondNumber = Convert.ToDouble(secondNumber2);
                Console.WriteLine();
                double sum = firstNumber - secondNumber;
                Console.WriteLine("The result is\n========\n " + sum.ToString());
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the application");
                Console.ReadKey();
            }
            if (mitvalg.KeyChar == '3')
            {
                Console.Clear();
                Console.WriteLine("You have now chosen to multiply two digits");
                Console.WriteLine();
                Console.WriteLine("Please enter your first digit");
                string firstNumber1 = Console.ReadLine();
                firstNumber = Convert.ToDouble(firstNumber1);
                Console.WriteLine();
                Console.WriteLine("Please enter your second digit");
                string secondNumber2 = Console.ReadLine();
                secondNumber = Convert.ToDouble(secondNumber2);
                Console.WriteLine();
                double sum = firstNumber * secondNumber;
                Console.WriteLine("The result is: \n===========\n" + sum.ToString());
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the application");
                Console.ReadKey();
            }
            if(mitvalg.KeyChar=='4')
            {
                Console.Clear();
                Console.WriteLine("You have now chosen to divide two digits");
                Console.WriteLine();
                Console.WriteLine("Please enter your first digit");
                string firstNumber1 = Console.ReadLine();
                firstNumber = Convert.ToDouble(firstNumber1);
                Console.WriteLine();
                Console.WriteLine("Please enter your second digit");
                string secondNumber2 = Console.ReadLine();
                secondNumber = Convert.ToDouble(secondNumber2);
                Console.WriteLine();
                double sum = firstNumber / secondNumber;
                Console.WriteLine("The result is: \n===========\n" + sum.ToString());
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the application");
                Console.ReadKey();
            }
            if(mitvalg.KeyChar=='5')
            {
                Console.Clear();
                Console.WriteLine("You have now chosen to get the power of two numbers");
                Console.WriteLine();
                Console.WriteLine("Please enter the first digit");
                string firstNumber1 = Console.ReadLine();
                firstNumber = Convert.ToInt32(firstNumber1);
                Console.WriteLine();
                Console.WriteLine("Please enter the second digit you want to add to the power of");
                string secondNumber2 = Console.ReadLine();
                secondNumber = Convert.ToDouble(secondNumber2);
                Console.WriteLine();
                double sum = Math.Pow(firstNumber,secondNumber);
                Console.WriteLine("The result is: \n===========\n" + sum.ToString());
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the application");
                Console.ReadKey();
            }
            if(mitvalg.KeyChar=='6') //Når man vælger 6 i menuen giver koden nedenunder et tilfældigt nummer mellem 1 og 100.
            {
                Console.Clear();
                for (int i = 0; i<= 10; i++ ) 
                {
                    Random rnd = new Random();
                    int number = rnd.Next(1, 100);
                    Console.WriteLine(number);
                }
                Console.WriteLine("There u go");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit the application");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
