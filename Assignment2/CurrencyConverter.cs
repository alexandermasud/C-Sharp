using System;
namespace Assignment2
{
    public class CurrencyConverter
    {
        public CurrencyConverter()
        {

           
            
            DisplayMenu();
            double total = ReadNumbers();
            string currency = ReadCurrency();
            double exchangeRate = ReadExchangeRate();
            double totalSum = CalculationOfNumbers(total, exchangeRate);
            DisplayTotal(total, currency, exchangeRate, totalSum);
        }

        private void DisplayMenu()
        {
            Console.WriteLine(new string('+', 4) + " The currency converter " + new string('+', 4));
            Console.WriteLine("");
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
        private void DisplayTotal(double total, string currency, double exchangeRate, double totalSum)
        {
            // Skriver ut den totala summan
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The sum is " + total + " kr.");
            Console.WriteLine("");
            Console.WriteLine(total + " kr is converted to " + totalSum + " " + currency + " at the rate of " + exchangeRate + " kr/" + currency + ".");
        }
    }
}
