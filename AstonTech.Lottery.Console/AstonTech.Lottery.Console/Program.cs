using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstonTech.Lottery;

namespace AstonTech.Lottery.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //notes:    call method for labs
            labMethodsParameters();

        }
        private static void labMethodsParameters()
        {
            MethodsParametersLab myObject = new MethodsParametersLab();
            int outParameter;

            System.Console.WriteLine("Would you like to buy a lottery ticket?");
            System.Console.Write("Y/N? ");
            string evaluateFirst = System.Console.ReadLine();

            /* Determine if the user should continue */
            if (evaluateFirst.ToLower() != "y")
                System.Console.WriteLine("No tickets purchased");
            else
            {
                bool userContinue = true;
                myObject.processUserContinue(ref userContinue, out outParameter);
                if (userContinue == true)
                    System.Console.WriteLine(outParameter + " tickets purchased");
                else
                    System.Console.WriteLine("No tickets purchased");
            }
        }
        private static void labExceptions()
        {
            string userContinue = "y";
            try
            {
                while (userContinue == "y") // Puts the user in a loop so they can continue from the top again
                {
                    /* Lottery Menu */
                    System.Console.WriteLine("Please select from the following options to view lottery game info:");
                    System.Console.WriteLine("------------------------------------------------------------");
                    System.Console.WriteLine("1 : Powerball");
                    System.Console.WriteLine("2 : Mega Millions");
                    System.Console.WriteLine("3 : Hot Lotto");
                    System.Console.WriteLine("4 : Gopher 5");
                    System.Console.WriteLine("------------------------------------------------------------");
                    System.Console.Write("Enter choice: ");

                    /* User Input */
                    string userInput = System.Console.ReadLine();
                    System.Console.WriteLine("");
                    int selectedOption;
                    if (int.TryParse(userInput, out selectedOption))
                    {
                        /* Lottery data based on user input */
                        switch (selectedOption)
                        {
                            case 1:
                                System.Console.WriteLine("You chose Powerball");
                                System.Console.WriteLine("Winning numbers: ");
                                System.Console.WriteLine("Estimated jackpot: $60,000,000");
                                System.Console.WriteLine("Estimated cash option: $30,300,000");
                                System.Console.WriteLine("Next estimated draw date: 12/21/13");
                                break;
                            case 2:
                                System.Console.WriteLine("You chose Mega Millions");
                                System.Console.WriteLine("Winning numbers: ");
                                System.Console.WriteLine("Estimated jackpot: $15,000,000");
                                System.Console.WriteLine("Estimated cash option: $8,000,000");
                                System.Console.WriteLine("Next estimated draw date: 12/20/13");
                                break;
                            case 3:
                                System.Console.WriteLine("You chose Hot Lotto");
                                System.Console.WriteLine("Winning numbers: ");
                                System.Console.WriteLine("Estimated jackpot: $1,950,000");
                                System.Console.WriteLine("Next estimated draw date: 12/21/13");
                                break;
                            case 4:
                                System.Console.WriteLine("You chose Gopher 5");
                                System.Console.WriteLine("Winning numbers: ");
                                System.Console.WriteLine("Estimated jackpot: $130,000");
                                System.Console.WriteLine("Next estimated draw date: 12/20/13");
                                break;
                            default:
                                System.Console.WriteLine("Invalid Choice");
                                break;
                        }

                    }
                    else
                        System.Console.WriteLine("Invalid Choice"); //Error if the user didn't choose a proper seclection from the lottery menu
                    System.Console.Write("Try again? Y/N :");
                    userContinue = System.Console.ReadLine().ToLower(); //Updates variable for while loop to continue from the top
                    System.Console.WriteLine("");
                } //end of while loop
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Exception: " + ex.Message);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: " + ex.Message);
            }
            finally //Continues running the code for the program if the try block was successful
            {
                System.Console.WriteLine("Program has completed regardless of exceptions.");
            }
        }
        private static void labFlowControl()
        {

            string userContinue = "y";
            while (userContinue == "y") // Puts the user in a loop so they can continue from the top again
            {
                /* Lottery Menu */
                System.Console.WriteLine("Please select from the following options to view lottery game info:");
                System.Console.WriteLine("------------------------------------------------------------");
                System.Console.WriteLine("1 : Powerball");
                System.Console.WriteLine("2 : Mega Millions");
                System.Console.WriteLine("3 : Hot Lotto");
                System.Console.WriteLine("4 : Gopher 5");
                System.Console.WriteLine("------------------------------------------------------------");
                System.Console.Write("Enter choice: ");

                /* User Input */
                string userInput = System.Console.ReadLine();
                System.Console.WriteLine("");
                int selectedOption;
                if (int.TryParse(userInput, out selectedOption))
                {
                    /* Lottery data based on user input */
                    switch (selectedOption)
                    {
                        case 1:
                            System.Console.WriteLine("You chose Powerball");
                            System.Console.WriteLine("Winning numbers: ");
                            System.Console.WriteLine("Estimated jackpot: $60,000,000");
                            System.Console.WriteLine("Estimated cash option: $30,300,000");
                            System.Console.WriteLine("Next estimated draw date: 12/21/13");
                            break;
                        case 2:
                            System.Console.WriteLine("You chose Mega Millions");
                            System.Console.WriteLine("Winning numbers: ");
                            System.Console.WriteLine("Estimated jackpot: $15,000,000");
                            System.Console.WriteLine("Estimated cash option: $8,000,000");
                            System.Console.WriteLine("Next estimated draw date: 12/20/13");
                            break;
                        case 3:
                            System.Console.WriteLine("You chose Hot Lotto");
                            System.Console.WriteLine("Winning numbers: ");
                            System.Console.WriteLine("Estimated jackpot: $1,950,000");
                            System.Console.WriteLine("Next estimated draw date: 12/21/13");
                            break;
                        case 4:
                            System.Console.WriteLine("You chose Gopher 5");
                            System.Console.WriteLine("Winning numbers: ");
                            System.Console.WriteLine("Estimated jackpot: $130,000");
                            System.Console.WriteLine("Next estimated draw date: 12/20/13");
                            break;
                        default:
                            System.Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
                else
                    System.Console.WriteLine("Invalid Choice"); //Error if the user didn't choose a proper seclection from the lottery menu
            System.Console.Write("Try again? Y/N :");
            userContinue = System.Console.ReadLine().ToLower(); //Updates variable for while loop to continue from the top
            System.Console.WriteLine("");
            }
            }
        private static void labArrays()
        {

            //Store and lottery game names
            List<string> lotteryName = new List<string>();
            lotteryName.Add("Powerball");
            lotteryName.Add("Mega Millions");
            lotteryName.Add("Hot Lotto");
            lotteryName.Add("Gopher 5");

            /*
            //Store winning numbers - Powerball
            int[] winningNumbers1 = new int[6];
            winningNumbers1[0] = 7;
            winningNumbers1[1] = 24;
            winningNumbers1[2] = 37;
            winningNumbers1[3] = 39;
            winningNumbers1[4] = 40;
            winningNumbers1[5] = 1;


            //Store winning numbers - Mega Millions
            int[] winningNumbers2 = new int[6];
            winningNumbers2[0] = 8;
            winningNumbers2[1] = 14;
            winningNumbers2[2] = 17;
            winningNumbers2[3] = 20;
            winningNumbers2[4] = 39;
            winningNumbers2[5] = 7;

            //Store winning numbers - Hot Lotto
            int[] winningNumbers3 = new int[6];
            winningNumbers3[0] = 8;
            winningNumbers3[1] = 27;
            winningNumbers3[2] = 32;
            winningNumbers3[3] = 40;
            winningNumbers3[4] = 46;
            winningNumbers3[5] = 4;


            //Store winning numbers - Gopher 5
            int[] winningNumbers4 = new int[5];
            winningNumbers4[0] = 2;
            winningNumbers4[1] = 9;
            winningNumbers4[2] = 12;
            winningNumbers4[3] = 36;
            winningNumbers4[4] = 39;
            */

           
            //Store winning numbers by game using arrays for each game
            int[][] winningNumbers = new int[4][];
            winningNumbers[0] = new int [] { 7, 24, 37, 39, 40, 1 };
            winningNumbers[1] = new int [] { 8, 14, 17, 20, 39, 7 };
            winningNumbers[2] = new int [] { 8, 27, 32, 40, 46, 4 };
            winningNumbers[3] = new int [] { 2, 9, 12, 36, 39 };


            //Store estimated jackpot values
            string[] jackpotValues = new string[4];
            jackpotValues[0] = "$60,000,000";
            jackpotValues[1] = "$15,000,000";
            jackpotValues[2] = "1,950,000";
            jackpotValues[3] = "$130,000";


            int x = 0; //initialize x

            foreach (var lotteryNameValue in lotteryName) //Iterate lottery name
            {
                System.Console.WriteLine(lotteryNameValue); //Output lottery name for each game
                foreach(int singleNumber in winningNumbers[x]) //Iterate winning numbers for each game
                {
                        System.Console.Write(singleNumber + ", "); //Output lottery numbers for each game
                        
                }
                System.Console.WriteLine();
                foreach(var jackpot in jackpotValues[x]) //Iterate jackpot values
                {
                    System.Console.Write(jackpot); //Output jackpot value for each game
                }
                System.Console.WriteLine();
                x++;
            }
        }
        private static void labStrings()
        {
            //lottery1
            string lotteryName1 = "PowerBall";
            long winningNumbers1 = 7243739401;
            string estimatedJackpot1 = "$60,000,000";
            string estimatedCashOption1 = "$30,300,000";
            DateTime nextEstimatedDrawDate1 = new DateTime(2013, 12, 21);

            System.Console.WriteLine(lotteryName1);
            System.Console.WriteLine(winningNumbers1);
            System.Console.WriteLine(estimatedJackpot1);
            System.Console.WriteLine(estimatedCashOption1);
            System.Console.WriteLine(nextEstimatedDrawDate1);



            //lottery2
            string lotteryName2 = "Mega Millions";
            long winningNumbers2 = 8141720397;
            string estimatedJackpot2 = "$15,000,000";
            string estimatedCashOption2 = "$8,000,000";
            DateTime nextEstimatedDrawDate2 = new DateTime(2013, 12, 20);

            System.Console.WriteLine(lotteryName2);
            System.Console.WriteLine(winningNumbers2);
            System.Console.WriteLine(estimatedJackpot2);
            System.Console.WriteLine(estimatedCashOption2);
            System.Console.WriteLine(nextEstimatedDrawDate2);



            //lottery3
            string lotteryName3 = "Hot Lotto";
            long winningNumbers3 = 8273240464;
            string estimatedJackpot3 = "$1,950,000";
            string estimatedCashOption3 = null;
            DateTime nextEstimatedDrawDate3 = new DateTime(2013, 12, 21);

            System.Console.WriteLine(lotteryName3);
            System.Console.WriteLine(winningNumbers3);
            System.Console.WriteLine(estimatedJackpot3);
            System.Console.WriteLine(estimatedCashOption3);
            System.Console.WriteLine(nextEstimatedDrawDate3);



            //lottery4
            string lotteryName4 = "Gopher 5";
            long winningNumbers4 = 29123639;
            string estimatedJackpot4 = "$130,000";
            string estimatedCashOption4 = null;
            DateTime nextEstimatedDrawDate4 = new DateTime(2013, 12, 20);

            System.Console.WriteLine(lotteryName4);
            System.Console.WriteLine(winningNumbers4);
            System.Console.WriteLine(estimatedJackpot4);
            System.Console.WriteLine(estimatedCashOption4);
            System.Console.WriteLine(nextEstimatedDrawDate4);
        }

    }
}
