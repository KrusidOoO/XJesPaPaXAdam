using System;

namespace Foreach_sange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Sange = { "Old time road", "Paris", "SOS", "So Am I" };



            Console.WriteLine("Her er mine ynglingssange");



            foreach (string i in Sange)

            {

                Console.WriteLine(i);

            }

            Console.ReadKey();
        }
    }
}
