using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class FloatingPointsNumberWhileAdd
    {
        public FloatingPointsNumberWhileAdd()
        {
            double Total = ReadNumbers();
            DisplayTotal(Total);
            return;
        }

        private double ReadNumbers(){
            // Processas inputs och summerar dessa
            double Total = 0;
            while (true)
            {
                Console.WriteLine("Ange ett nummer till summan");
                string TempNum = Console.ReadLine();
                double Num = Double.Parse(TempNum);
                Num = Math.Round(Num, 2);

                if (Num == 0.00){
                    return Total;
                }
                else{   
                    Total = Total + Num;
                }
            }
        }

        private void DisplayTotal(double Total){
            // Skriver ut den totala summan
            Console.WriteLine("TOTAL: " + Total);
        }
    }
}
