using System;

namespace Distance_calculator
{

    class Program
    {

        static void Main(string[] args)
        {
            DistanceCal DC = new DistanceCal();
            Console.WriteLine("Keep in mind your traveling distance will be calculated in 2x4 Lego bricks");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Input your starting position");
            int StartP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your end position");
            int EndP = Convert.ToInt32(Console.ReadLine());
            int LegoPrMeter = 125;
            Console.Clear();
            Console.WriteLine("Your travelled distance is: " + DC.DistanceInLegos(StartP,EndP,LegoPrMeter)+ " 2x4 Lego Bricks");
            Console.WriteLine("Or if you want it in meters, then it is " + DC.distance(StartP, EndP)+ " Meters");
            Console.ReadKey();
        }
    }
    class DistanceCal
    {
        public int distance(int StartD, int StopD)
        {
            return StopD - StartD;
        }
        public int DistanceInLegos(int startD,int stopD,int InLegos)
        {
            return (stopD - startD) * InLegos;
        }
    }
}
