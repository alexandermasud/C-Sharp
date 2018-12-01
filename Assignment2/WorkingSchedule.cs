using System;
namespace Assignment2
{
    public class WorkingSchedule
    {
        public WorkingSchedule()
        {
            
            DisplayMenu();
        }

        private void PrintMenu() {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(new string(' ', 10) + "YOUR SCHEDULE PROGRAM");
            Console.WriteLine("Select from the menu which type of schedule you want to see.");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("");
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Return to the Main Menu.");
            Console.WriteLine("");
        }

        private void DisplayMenu(){

            int userInput = 0;
            do
            {
            PrintMenu();
            
            Console.Write("Your choice: ");
            userInput = Input.ReadIntegerConsole();


                switch (userInput)
                {
                        case 1:
                            DisplaySchedule(1);
                            break;
                        case 2:
                            DisplaySchedule(2);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Invalid option. Choose between 0 and 2");
                            break;
                }
            } while (userInput != 0);
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


