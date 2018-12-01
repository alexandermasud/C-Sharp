using System;
namespace Assignment2
{
    public class WorkingSchedule
    {
        public WorkingSchedule()
        {
            
            DisplayMenu();
        }

        private void DisplayMenu(){

            bool loopContinue = true;
            while (loopContinue)
            {



                Console.WriteLine(new string('-', 50));
                Console.WriteLine(new string(' ', 10) + "YOUR SCHEDULE PROGRAM");
                Console.WriteLine("Select from the menu which type of schedule you want to see.");
                Console.WriteLine(new string('-', 50));

                Console.WriteLine("");
                Console.WriteLine("1 Show a list of the weekends to work.");
                Console.WriteLine("2 Show a list of the nights to work.");
                Console.WriteLine("0 Return to the Main Menu.");
                Console.WriteLine("");

                Console.Write("Your choice: ");
                int userInput = Input.ReadIntegerConsole();
                bool closeApp = false;

                switch (userInput)
                {
                    case 1:
                        DisplaySchedule(1);
                        loopContinue = true;
                        closeApp = false;
                        break;
                    case 2:
                        DisplaySchedule(2);
                        loopContinue = true;
                        closeApp = false;
                        break;
                    case 0:
                        loopContinue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                if (loopContinue)
                {
                    if (closeApp != false)
                    {
                        Console.WriteLine("Invalid input");
                    }

                }
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
                Console.WriteLine("            Week " + i);
            }
        }
    }
}


