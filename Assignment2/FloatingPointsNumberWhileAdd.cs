using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class FloatingPointsNumberWhileAdd
    {
        public FloatingPointsNumberWhileAdd()
        {
            int asterisk = Graphics.AmountOfAsterisk();
            int rowOfDashes = Graphics.RowOfDashes();
            DisplayMenu(asterisk, rowOfDashes);
            double total = ReadNumbers();
            DisplayTotal(total);
            return;
        }

        private void DisplayMenu(int asterisk, int rowOfDashes){
            // Presenterar menyn för att sumera decimaltal
            Console.WriteLine(new string('*', asterisk) + " Summation of real numbers " + new string('*', asterisk));
            Console.WriteLine(new string(' ', asterisk * 2) + "using a while loop");
            Graphics.EmptyRow();
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine(new string('-', rowOfDashes));
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
