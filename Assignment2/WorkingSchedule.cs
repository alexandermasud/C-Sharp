using System;
namespace Assignment2
{
    public class WorkingSchedule
    {
        public WorkingSchedule()
        {

            WorkingMenu();
        }

        private void WorkingMenu(){

            Console.WriteLine("Tryck 1 för helger");
            Console.WriteLine("Tryck 2 för kvällar");
            Console.WriteLine("Tryck 0 för att avsluta");

            int userInput = Input.ReadIntegerConsole();

            switch (userInput)
            {
                case 1:
                    DisplayWeekends();
                    break;
                case 2:
                    DisplayNights();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        private void DisplayWeekends(){

            for (int i = 1; i < 53; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }

        private void DisplayNights(){

            for (int i = 6; i < 53; i = i + 5)
            {
                Console.WriteLine(i);
            }
        }
        


    }
}
