using System;
namespace Assignment2
{
    public class Menu
    {
        public Menu()
        { 
        }

        public void Start()
        {
            // Användaren matar in siffra för att välja vilken funktion som ska köras
           
            Console.WriteLine("Ange 1-5 för att starta funktioner, 0 för avsluta");
            string userInput = Console.ReadLine();



            switch (userInput)
            {
                case "1":
                    new WholeNumbersForAdd();
                    break;
                case "2":
                    new FloatingPointsNumberWhileAdd();
                    break;
                case "3":
                    new CurrencyConverter();
                    break;
                case "4":
                    new TemperatureTable();
                    break;
                case "5":
                    Console.WriteLine("Case 5");
                    break;
                case "0":
                    Console.WriteLine("Case 0");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
