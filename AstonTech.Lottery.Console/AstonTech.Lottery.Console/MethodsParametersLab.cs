using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTech.Lottery.Console
{
    public class MethodsParametersLab
    {
        public void processUserContinue(ref bool userStillContinue, out int returnedNumberOfTickets)
        {


            System.Console.Write("How many lotto tickets? ");
	        string userInput = System.Console.ReadLine();
            int numberOfTickets;
	        while (!int.TryParse(userInput, out numberOfTickets))
	        {
                System.Console.WriteLine();
		        System.Console.WriteLine("Invalid entry");
                System.Console.Write("How many lotto tickets? ");
		        userInput = System.Console.ReadLine();
	        }
            returnedNumberOfTickets = numberOfTickets;


            System.Console.WriteLine();
            System.Console.WriteLine("A ticket costs $100");
            System.Console.WriteLine("Continue with purchase?");
            System.Console.Write("Y/N? ");
            string evaluateSecond = System.Console.ReadLine();
            System.Console.WriteLine();

            if (evaluateSecond.ToLower() == "y")
            {
                userStillContinue = true;
            }
            else
                userStillContinue = false;
        }
    }
}
