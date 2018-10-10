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

            int rowOfDashes = Graphics.RowOfDashes();
            int marginLeft = Graphics.MarginLeft();
            Console.WriteLine(new string('-', rowOfDashes));
            Console.WriteLine(new string(' ', 20) + "MENY");
            Console.WriteLine(new string('-', rowOfDashes));
            Console.WriteLine(new string(' ', marginLeft) + "Whole Numbers with For" + new string(' ', 17) + ": 1");
            Console.WriteLine(new string(' ', marginLeft) + "Floating Point Numbers With While" + new string(' ', 6) + ": 2");
            Console.WriteLine(new string(' ', marginLeft) + "Currency Converter With Do While Loop" + new string(' ', 2) + ": 3");
            Console.WriteLine(new string(' ', marginLeft) + "Work Schedule" + new string(' ', 26) + ": 4");
            Console.WriteLine(new string(' ', marginLeft) + "Temperatute Table" + new string(' ', 22) + ": 5");
            Console.WriteLine(new string(' ', marginLeft) + "Exit The Program" + new string(' ', 23) + ": 0");
            Console.WriteLine(new string('-', rowOfDashes));

            Console.Write("Your choice: ");
            int userInput = Input.ReadIntegerConsole();

            switch (userInput)
            {
                case 1:
                    new WholeNumbersForAdd();
                    break;
                case 2:
                    new FloatingPointsNumberWhileAdd();
                    break;
                case 3:
                    new CurrencyConverter();
                    break;
                case 4:
                    new WorkingSchedule();
                    break;
                case 5:
                    new TemperatureTable();
                    break;
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
