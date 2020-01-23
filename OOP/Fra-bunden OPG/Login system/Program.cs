using System;
using System.Collections.Generic;
using System.Text;

namespace Login_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Students stu = new Students();
            Teacher tea = new Teacher();
            Personel per = new Personel();
            Console.WriteLine(stu.Studentss());
            Console.WriteLine();
            Console.WriteLine(tea.Teachers());
            Console.WriteLine();
            Console.WriteLine(per.PersonelIDNamePass());

            Console.ReadKey();
        }
    }
}
