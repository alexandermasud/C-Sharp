using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class FloatingPointsNumberWhileAdd
    {
        public FloatingPointsNumberWhileAdd()
        {
            
            
            DisplayMenu();
            double total = ReadNumbers();
            DisplayTotal(total);
            return;
        }

        private void DisplayMenu(){
            // Presenterar menyn för att sumera decimaltal
            Console.WriteLine(new string('*', 4) + " Summation of real numbers " + new string('*', 4));
            Console.WriteLine(new string(' ', 4 * 2) + "using a while loop");
            Console.WriteLine("");
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine(new string('-', 50));
        }

        private double ReadNumbers(){
            // Processar inputs och summerar talen
            double total = 0;
            while (true)
            {
                Console.Write("Write a number to add to the sum: ");
                double num = Input.ReadDoubleConsole();
                num = Math.Round(num, 2);

                if (num == 0.00){
                    return total;
                }
                else{   
                    total = total + num;
                }
            }
        }

        private void DisplayTotal(double total){
            // Skriver ut den totala summan
            Console.WriteLine("The sum is: " + total);
        }
    }
}
