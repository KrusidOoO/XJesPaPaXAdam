using System;
using System.Collections.Generic;
using System.Text;

namespace Login_system
{
    class Teacher
    {
        public string Teachers()
        {
            var TeacherName = new List<string>();
            var TeacherID = new List<int>();
            var TeacherPassword = new List<int>();
            TeacherName.Add("Frank");
            TeacherID.Add(1433);
            TeacherPassword.Add(12345);

            return "#" + TeacherID[0].ToString() + " : " + TeacherName[0].ToString() + " : " + TeacherPassword[0].ToString();
        }
    }
}
