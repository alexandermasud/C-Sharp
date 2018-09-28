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
                    DisplaySchedule(1);
                    break;
                case 2:
                    DisplaySchedule(2);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        private void DisplaySchedule(int type){

            // Beroende på helger 1 eller kvällar 2 loopas schemat igenom
            int start;
            int jump;

            if(type == 1){
                start = 1;
                jump = 3;
            }
            else{
                start = 6;
                jump = 5;
            }

            for (int i = start; i < 53; i = i + jump)
            {
                Console.WriteLine(i);
            }
        }
    }
}
