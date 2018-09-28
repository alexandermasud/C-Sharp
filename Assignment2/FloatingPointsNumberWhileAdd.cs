using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class FloatingPointsNumberWhileAdd
    {
        public FloatingPointsNumberWhileAdd()
        {
            double total = ReadNumbers();
            DisplayTotal(total);
            return;
        }

        private double ReadNumbers(){
            // Processar inputs och summerar talen
            double total = 0;
            while (true)
            {
                Console.WriteLine("Ange ett nummer till summan");
                string tempNum = Console.ReadLine();
                double num = Double.Parse(tempNum);
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
            Console.WriteLine("TOTAL: " + total);
        }
    }
}
