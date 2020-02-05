using System;

namespace SimpleProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            if(name=="Alice"||name=="Bob")
            {
                Console.Write("Hello " + name);
            }
            Console.WriteLine();
            int n = 0;

            Console.WriteLine("Please enter the number you want to use");
            n =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for(int i=0;i<=n;i++)
            {
                if(IsOdd(i))
                {
                    Console.Write(i + " ");
                }

                //Console.Write(i + " ");
            }

            Console.WriteLine();
            static bool IsOdd(int value)
            {

                return value % 5==0||value%3==0;
            }
            int m = 0;
            Console.WriteLine("Enter your multiplaction table option thing");
            m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is your multiplication table");

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(m.ToString()+"*"+i.ToString()+"="+m * i);
            }

            Console.WriteLine();

            Console.WriteLine("Now it is time for a guessing game, guess a number between 0 and 50");
            int k = 1;
            Random rnd = new Random();
            int o=Convert.ToInt32(rnd.Next(0,50));
            while(k<=5)
            {
                Console.WriteLine("Make your guess as to which number has been generated");
                int l=Convert.ToInt32(Console.ReadLine());
                if(l>o)
                {
                    Console.WriteLine("Your guess is higher than the generated number, try again");
                    k++;
                }
                else if(l<o)
                {
                    Console.WriteLine("Your guess is lower than the generated number, try again");
                    k++;
                }
                //else if(l==l)
                //{
                //    Console.WriteLine("This guess is the same as your previous guess, pick a different number");
                //}
                else if (l ==o)
                {
                    Console.WriteLine("You are correct!!");
                    k = 5;
                    Console.WriteLine("Press any key to exit this fun little program");
                    Console.ReadKey();
                }
                
            }
            if (k > 5)
                Console.WriteLine("You ran out of tries, better luck next time!");
            else if (k < 5)
                Console.WriteLine("");





            Console.ReadKey();
        }
    }
}
