using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Common
{
    public static class StateHelper
    {
        public static Dictionary <string, string> States
        {
            get
            {
                Dictionary<string, string> states = new Dictionary<string, string>();

                states.Add("AL", "Alabama");
                states.Add("AK", "Alaska");
                states.Add("AZ", "Arizona");
                states.Add("AR", "Arkansas");
                states.Add("CA", "California");
                states.Add("CO", "Colorado");
                states.Add("CT", "Connecticut");
                states.Add("DE", "Delaware");
                states.Add("DC", "District of Columbia");
                states.Add("FL", "Flordia");
                states.Add("GA", "Georgia");
                states.Add("HI", "Hawaii");
                states.Add("ID", "Idaho");
                states.Add("IL", "Illinois");
                states.Add("IN", "Indiana");
                states.Add("IA", "Iowa");
                states.Add("KS", "Kansas");
                states.Add("KY", "Kentucky");
                states.Add("LA", "Louisana");
                states.Add("ME", "Maine");
                states.Add("MD", "Marlyand");
                states.Add("MA", "Massachusetts");
                states.Add("MI", "Michigan");
                states.Add("MN", "Minnesota");
                states.Add("MS", "Mississippi");
                states.Add("MO", "Missouri");
                states.Add("MT", "Montana");
                states.Add("NE", "Nebraska");
                states.Add("NV", "Nevada");
                states.Add("NH", "New Hampshire");
                states.Add("NJ", "New Jersey");
                states.Add("NM", "New Mexico");
                states.Add("NY", "New York");
                states.Add("NC", "North Carolina");
                states.Add("ND", "North Dakota");
                states.Add("OH", "Ohio");
                states.Add("OK", "Oklahoma");
                states.Add("OR", "Oregon");
                states.Add("PA", "Pennsylvania");
                states.Add("RI", "Rhode Island");
                states.Add("SC", "South Carolina");
                states.Add("SD", "South Dakota");
                states.Add("TN", "Tennessee");
                states.Add("TX", "Texas");
                states.Add("UT", "Utah");
                states.Add("VT", "Vermont");
                states.Add("VA", "Virginia");
                states.Add("WV", "West Virginia");
                states.Add("WI", "Wisconsin");
                states.Add("WY", "Wyoming");

                return states;
            }
        }

        public static string GetStateName(string stateAbbreviation)
        {
            if (States.ContainsKey(stateAbbreviation))
                return States[stateAbbreviation];
            else
                return "NA";
        }
    }
}
