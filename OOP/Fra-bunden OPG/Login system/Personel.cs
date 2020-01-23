using System;
using System.Collections.Generic;
using System.Text;

namespace Login_system
{
    class Personel
    {
        public string PersonelIDNamePass()
        {
            var PersonelID = new List<int>();
            var PersonelName = new List<string>();
            var PersonelPassword = new List<int>();
            PersonelID.Add(1555);
            PersonelName.Add("Allan");
            PersonelPassword.Add(123456);

            return "#" + PersonelID[0].ToString() + " : " + PersonelName[0].ToString() + " : " + PersonelPassword[0].ToString();
        }
    }
}
