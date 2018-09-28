using System;
namespace Assignment2

{
    public class Input
    {
        public Input()
        {
        }

        public static int ReadIntegerConsole(){
            // Processar string till int

            string tempUserInput = Console.ReadLine();
            int userInput;
            int.TryParse(tempUserInput, out userInput);
            return userInput;

        }

        public static double ReadDoubleConsole(){

            // Processar string till double
            string tempUserInput = Console.ReadLine();
            double userInput;
            double.TryParse(tempUserInput, out userInput);
            return userInput;

        }
    }
}
