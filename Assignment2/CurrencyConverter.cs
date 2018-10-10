using System;
namespace Assignment2
{
    public class CurrencyConverter
    {
        public CurrencyConverter()
        {

            int stars = Graphics.AmountOfStars();
            int rowOfDashes = Graphics.RowOfDashes();
            DisplayMenu(stars);
            double total = ReadNumbers();
            string currency = ReadCurrency();
            double exchangeRate = ReadExchangeRate();
            double totalSum = CalculationOfNumbers(total, exchangeRate);
            DisplayTotal(total, currency, exchangeRate, totalSum, rowOfDashes);
        }

        private void DisplayMenu(int stars)
        {
            Console.WriteLine(new string('+', stars) + " The currency converter " + new string('+', stars));
            Graphics.EmptyRow();
            Console.WriteLine("Write 0 to finish input!");
        }

        private double ReadNumbers()
        {
            // Processar inputs och summerar dessa
            double total = 0;
            while (true)
            {
                Console.Write("Write an amount to add to total: ");
                double num = Input.ReadDoubleConsole();


                if (num == 0.00)
                {
                    return total;
                }
                else
                {
                    total = total + num;
                }
            }
        }
        private string ReadCurrency()

        {
            // Användaren anger valutans namn 
            Console.Write("Name of foreign currency ");
            string answer = Console.ReadLine();
            return answer;
        }

        private double ReadExchangeRate()
        {
            // Användaren anger valutans växelkurs
            Console.Write("Exchange rate: ");
            double answer = Input.ReadDoubleConsole();
            return answer;
        }

        private double CalculationOfNumbers(double total, double exchangeRate){

            // Valutan omvandlas enligt växelkurs samt avrundas
            double totalSum = total / exchangeRate;
            totalSum = Math.Round(totalSum, 2);
            return totalSum;
        }
        private void DisplayTotal(double total, string currency, double exchangeRate, double totalSum, int rowOfDashes)
        {
            // Skriver ut den totala summan
            Console.WriteLine(new string('-', rowOfDashes));
            Console.WriteLine("The sum is " + total + " kr.");
            Graphics.EmptyRow();
            Console.WriteLine(total + " kr is converted to " + totalSum + " " + currency + " at the rate of " + exchangeRate + " kr/" + currency + ".");
        }
    }
}
