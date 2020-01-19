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
            void Stars(double antal)
            {
                for (int T = 0; T < antal; T++)
                    Console.Write("*");
                Console.WriteLine();
            }

            {
                bool LoginOK = false;
                int forsoeg = 0;
                string name;
                string adgangskode;
                String[] brugernavne = { "Andreas", "Jesper", "Viktor" };
                String[] adgangskoder = { "1234", "4321", "12345" };
                double firstNumber;
                double secondNumber;

                do
                {
                    Console.Clear();
                    forsoeg++;
                    Console.Write("What is your name? ");//Kommer med en besked der beder dig om at skrive dit navn
                    name = Console.ReadLine();//Laver en string som skal indeholde navnet og læse navnet som man har skrevet
                    Console.Write("What is your password? ");
                    adgangskode = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        if (name == brugernavne[i] && adgangskode == adgangskoder[i])
                            LoginOK = true;
                    }
                } while (forsoeg < 3 && !LoginOK);


                if (LoginOK == true)
                {
                    ConsoleKeyInfo mitvalg;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Hello there " + name + "");//Bruger 'name' stringen til at komme med en besked der siger hej
                        Console.WriteLine();
                        Console.WriteLine("1. Add two numbers together");
                        Console.WriteLine("2. Subtract two numbers");
                        Console.WriteLine("3. Multiply two numbers");
                        Console.WriteLine("4. Divide two numbers");
                        Console.WriteLine("5. Get the power of two numbers");
                        Console.WriteLine("6. Get a random number");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Please enter the number of the action you wish to perform\nor press Escape to exit the application");
                        //"mitvalg" makes sure that it reads a specific key that you press
                        mitvalg = Console.ReadKey(true);
                        //this if statement starts the plus'ing of two numbers
                        if (mitvalg.KeyChar == '1')
                        {
                            //Console.Clear(); clears the console so we have a fresh page to look at
                            Console.Clear();
                            Console.WriteLine("You have now chosen to add two digits together");
                            Console.WriteLine();
                            Console.WriteLine("Please enter your first digit");
                            //Here we pick the first number we choose to add together, we do so by reading the line of the input and define it as "firstNumber1"
                            string firstNumber1 = Console.ReadLine();
                            //Here we convert the string to a double
                            firstNumber = Convert.ToDouble(firstNumber1);
                            Console.WriteLine();
                            Console.WriteLine("Please enter your second digit");
                            string secondNumber2 = Console.ReadLine();
                            secondNumber = Convert.ToDouble(secondNumber2);
                            Console.WriteLine();
                            //Here we add the two doubles together to get a sum
                            double sum = firstNumber + secondNumber;
                            //Here we write out the result, by converting our double "sum" to a string
                            Console.WriteLine("The result is\n=======\n" + sum.ToString());
                            Stars(sum);
                            Console.WriteLine();
                            //Since we have a loop, the if statement will return back to the main menu
                            Console.WriteLine("Press any key to return to the main menu");
                            Console.ReadKey();
                        }
                        if (mitvalg.KeyChar == '2')
                        {
                            //Console.Clear(); clears the console so we have a fresh page to look at
                            Console.Clear();
                            Console.WriteLine("You have now chosen to subtract two digits from eachother");
                            Console.WriteLine();
                            Console.WriteLine("Please enter your first digit");
                            //Here we pick the first number we choose to subtract, we do so by reading the line of the input and define it as "firstNumber1"
                            string firstNumber1 = Console.ReadLine();
                            //Here we convert the string to a double
                            firstNumber = Convert.ToDouble(firstNumber1);
                            Console.WriteLine();
                            Console.WriteLine("Please enter your second digit");
                            string secondNumber2 = Console.ReadLine();
                            secondNumber = Convert.ToDouble(secondNumber2);
                            Console.WriteLine();
                            //Here we subract the two doubles to get a sum
                            double sum = firstNumber - secondNumber;
                            //Here we write out the result, by converting our double "sum" to a string
                            Console.WriteLine("The result is\n========\n" + sum.ToString());
                            Stars(sum);
                            Console.WriteLine();
                            //Since we don't have a loop, the if statement will just exit out of the application
                            Console.WriteLine("Press any key to return to the main menu");
                            Console.ReadKey();
                        }
                        if (mitvalg.KeyChar == '3')
                        {
                            //Console.Clear(); clears the console so we have a fresh page to look at
                            Console.Clear();
                            Console.WriteLine("You have now chosen to multiply two digits");
                            Console.WriteLine();
                            Console.WriteLine("Please enter your first digit");
                            //Here we pick the first number we choose to subtract, we do so by reading the line of the input and define it as "firstNumber1"
                            string firstNumber1 = Console.ReadLine();
                            firstNumber = Convert.ToDouble(firstNumber1);
                            Console.WriteLine();
                            Console.WriteLine("Please enter your second digit");
                            string secondNumber2 = Console.ReadLine();
                            secondNumber = Convert.ToDouble(secondNumber2);
                            Console.WriteLine();
                            //Here we multiply the two doubles to get a sum
                            double sum = firstNumber * secondNumber;
                            //Here we write out the result, by converting our double "sum" to a string
                            Console.WriteLine("The result is: \n===========\n" + sum.ToString());
                            Stars(sum);
                            Console.WriteLine();
                            //Since we don't have a loop, the if statement will just exit out of the application
                            Console.WriteLine("Press any key to return to the main menu");
                            Console.ReadKey();
                        }
                        if (mitvalg.KeyChar == '4')
                        {
                            //Console.Clear(); clears the console so we have a fresh page to look at
                            Console.Clear();
                            Console.WriteLine("You have now chosen to divide two digits");
                            Console.WriteLine();
                            Console.WriteLine("Please enter your first digit");
                            //Here we pick the first number we choose to subtract, we do so by reading the line of the input and define it as "firstNumber1"
                            string firstNumber1 = Console.ReadLine();
                            firstNumber = Convert.ToDouble(firstNumber1);
                            Console.WriteLine();
                            Console.WriteLine("Please enter your second digit");
                            string secondNumber2 = Console.ReadLine();
                            secondNumber = Convert.ToDouble(secondNumber2);
                            Console.WriteLine();
                            //Here we divide the two doubles to get a sum
                            double sum = firstNumber / secondNumber;
                            //Here we write out the result, by converting our double "sum" to a string
                            Console.WriteLine("The result is: \n===========\n" + sum.ToString());
                            Stars(sum);
                            Console.WriteLine();
                            //Since we don't have a loop, the if statement will just exit out of the application
                            Console.WriteLine("Press any key to return to the main menu");
                            Console.ReadKey();
                        }
                        if (mitvalg.KeyChar == '5')
                        {
                            //Console.Clear(); clears the console so we have a fresh page to look at
                            Console.Clear();
                            Console.WriteLine("You have now chosen to get the power of two numbers");
                            Console.WriteLine();
                            Console.WriteLine("Please enter the first digit");
                            //Here we pick the first number we choose to subtract, we do so by reading the line of the input and define it as "firstNumber1"
                            string firstNumber1 = Console.ReadLine();
                            firstNumber = Convert.ToInt32(firstNumber1);
                            Console.WriteLine();
                            Console.WriteLine("Please enter the second digit you want to add to the power of");
                            string secondNumber2 = Console.ReadLine();
                            secondNumber = Convert.ToDouble(secondNumber2);
                            Console.WriteLine();
                            //Here we get to the power of the two doubles to get a sum
                            double sum = Math.Pow(firstNumber, secondNumber);
                            //Here we write out the result, by converting our double "sum" to a string
                            Console.WriteLine("The result is: \n===========\n" + sum.ToString());
                            Stars(sum);
                            Console.WriteLine();
                            //Since we don't have a loop, the if statement will just exit out of the application
                            Console.WriteLine("Press any key to return to the main menu");
                            Console.ReadKey();
                        }
                        if (mitvalg.KeyChar == '6') //Når man vælger 6 i menuen giver koden nedenunder et tilfældigt nummer mellem 1 og 100.
                        {
                            Console.Clear();
                            for (int i = 0; i <= 10; i++)
                            {
                                Random rnd = new Random();
                                int number = rnd.Next(1, 100);
                                Console.WriteLine(number);
                            }
                            Console.WriteLine("There u go");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to return to the main menu");
                            Console.ReadKey();
                        }
                    } while (mitvalg.Key != ConsoleKey.Escape);
                }
            }
        }
    }
}
