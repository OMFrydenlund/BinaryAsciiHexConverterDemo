using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAsciiHexConverter
{
    internal class App
    {
        public App()
        {
            ConversionMenu();
        }

        private void ConversionMenu()
        {
            while (true)
            {
                DisplayConversionTypeMenu();
            }
        }
        private void DisplayConversionTypeMenu()
        {
            Console.Clear();
            Console.Write("***-- CONVERTINGLOL --***" +
                "\n1. ASCII to Binary" +
                "\n2. ASCII to Hex" +
                "\n3. Binary to ASCII" +
                "\n4. Binary to Hex" +
                "\n5. Hex to ASCII" +
                "\n6. Hex to Binary" +
                "\n7. Exit" +
                "\n\nEnter 1-7 here: ");
            ProcessOption();
        }

        private void ProcessOption()
        {
            int chosenOption = GetInput();
            ChoiceToTask(chosenOption);
        }

        private void ChoiceToTask(int chosenOption)
        {
            Feature task = new Feature();
            task.FilterTask(chosenOption);
        }
        
        private int GetInput()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
    }
}
