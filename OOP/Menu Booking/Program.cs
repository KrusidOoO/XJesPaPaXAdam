using System;

namespace Menu_Booking
{
    class Program
    {
        static bool LoginOK()
        {
            Console.Write("Indtast brugernavn: ");
            String brugernavn = Console.ReadLine();
            Console.Write("Indtast adgangskode: ");
            String adgangskode = Console.ReadLine();
            if (brugernavn == "Admin" && adgangskode == "Nimda")
                return true;
            else
            {
                Console.WriteLine("Brugernavn og adgangskode er forkert. Tryk en vilkårlig tast for at afslutte.");
                Console.ReadKey();
                return false;
            }
        }
        static int Menu()
        {
            int ret;
            do
            {
                ret = 0;
                Console.WriteLine();
                Console.WriteLine("------ Booking Menu ------");
                Console.WriteLine("1. Vis liste af produkter");
                Console.WriteLine("2. Vis liste af kunder");
                Console.WriteLine("--------------------------");
                Console.WriteLine("x. Afslut program");
                String menuvalg = Console.ReadLine();
                if (menuvalg == "1")
                    ret = 1;
                if (menuvalg == "2")
                    ret = 2;
                if (menuvalg == "x")
                    ret = 10;
            } while (ret == 0);
            return ret;
        }
        static String[] produkter = { "Sofabord lille", "Spisebord 1,20m x 3,00m", "Sofa 3 pers.", "Sofa 2 pers.", "Sækkestol stor", "", "" };
        static String[] Kunder = { "Andreas", "Jesper", "Viktor", "Michael", "Emil"};
        static void ProduktListe()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(produkter[i]);
            }
        }
        static void KundeListe()
        {
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(Kunder[i]);
            }
        }
        static void Main(string[] args)
        {
            if (LoginOK()==true)
            {
                int valg;
                do
                {
                    valg = Menu();
                    if (valg == 1)
                        ProduktListe();
                    if (valg == 2)
                        KundeListe();
                } while (valg != 10);
            }
        }
    }
}