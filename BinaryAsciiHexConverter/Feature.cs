using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAsciiHexConverter
{
    internal class Feature
    {
        /* different conversion types + exit program
         * 
         * ASCII to Binary
         * ASCII to Hex
         * Binary to ASCII
         * Binary to Hex
         * Hex to ASCII
         * Hex to Binary
         * Exit
         */
        public Feature()
        {
            
        }
        public void FilterTask(int menuChoice)
        {
            if (menuChoice < 1 || menuChoice > 7)
            {
                Console.Write("\nNot a valid option.");
                Thread.Sleep(2500);
            }
            else
            {
                ExecuteTask(menuChoice);
            }
        }
        private void ExecuteTask(int menuChoice)
        {
            switch (menuChoice)
            {
                case 1:
                    TestValidChoiceReached(menuChoice);
                    break;
                case 2:
                    TestValidChoiceReached(menuChoice);
                    break;
                case 3:
                    TestValidChoiceReached(menuChoice);
                    break;
                case 4:
                    TestValidChoiceReached(menuChoice);
                    break;
                case 5:
                    TestValidChoiceReached(menuChoice);
                    break;
                case 6:
                    TestValidChoiceReached(menuChoice);
                    break;
                case 7:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("Å nei hva skjedde NÅ da????");
                    break;
            }
        }


        private void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using the app, exiting program...");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }

        private void TestValidChoiceReached(int number)
        {
            Console.WriteLine($"Valid option number {number} reached.");
            Console.ReadLine();
        }
    }
}
