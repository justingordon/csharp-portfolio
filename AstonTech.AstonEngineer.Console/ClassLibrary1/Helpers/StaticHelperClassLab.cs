using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Common
{
    public static class StaticHelperClassLab
    {
        public static Dictionary<string, string> LastName
        {
            get
            {
                Dictionary<string, string> lastName = new Dictionary<string, string>();

                lastName.Add("Amo", "Amos, Ryan");
                lastName.Add("Bau", "Baugus, Brian");
                lastName.Add("Bry", "Bryce, Troy");
                lastName.Add("Cau", "Cauwels, Jeff");
                lastName.Add("Deg", "DeGruchy, Josh");
                lastName.Add("Dun", "Duncan, Leroy");
                lastName.Add("Ewe", "Ewers, Daniel");
                lastName.Add("Gor", "Gordon, Justin");
                lastName.Add("Har", "Harstad, Kevin");
                lastName.Add("Pet", "Peterson, Jesse");
                lastName.Add("Sim", "Simmer, Dan");
                lastName.Add("Wil", "Williams, Brian");

                return lastName;
            }
        }



        public static string GetLastName(string lastNameAbbreviation)
        {
            if (LastName.ContainsKey(lastNameAbbreviation))
                return LastName[lastNameAbbreviation];
            else
                return "NA";
        }
    }
}