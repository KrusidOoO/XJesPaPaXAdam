using System;
using System.Collections.Generic;
using System.Text;

namespace Login_system
{
    class Students
    {
        public string Studentss()
        {
            var StudentID = new List<int>();
            var StudentName = new List<string>();
            var StudentPass = new List<int>();

            StudentID.Add(1435);
            StudentName.Add("Andreas");
            StudentPass.Add(12345);



            return "#" + StudentID[0].ToString() + " : " + StudentName[0].ToString() + " : " + StudentPass[0].ToString();
        }
    }
}
