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
                    // A to B
                    break;
                case 2:
                    // A to H
                    break;
                case 3:
                    // B to A
                    break;
                case 4:
                    // B to H
                    break;
                case 5:
                    // H to A
                    break;
                case 6:
                    // H to B
                    break;
                case 7:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("Å nei hva skjedde NÅ da????");
                    break;
            }
        }

        private void AscToB()
        {
            string inputToConvert = GetConversionInput();
        }

        private void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using the app, exiting program...");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }

        private string GetConversionInput()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
