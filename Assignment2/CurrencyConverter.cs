using System;
namespace Assignment2
{
    public class CurrencyConverter
    {
        public CurrencyConverter()
        {

            double total = ReadNumbers();
            string currency = ReadCurrency();
            double exchangeRate = ReadExchangeRate();
            double totalSum = CalculationOfNumbers(total, exchangeRate);
            DisplayTotal(total, currency, exchangeRate, totalSum);
        }

        private double ReadNumbers()
        {
            // Processar inputs och summerar dessa
            double total = 0;
            while (true)
            {
                Console.WriteLine("Ange ett nummer till summan");
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
            Console.WriteLine("Ange valuta:");
            string answer = Console.ReadLine();
            return answer;
        }

        private double ReadExchangeRate()
        {
            // Användaren anger valutans växelkurs
            Console.WriteLine("Ange växelkurs:");
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
            Console.WriteLine("Att växla " + total + " SEK");
            Console.WriteLine("");
            Console.WriteLine(total + " SEK blir " + totalSum + " " + currency + " med en växelkurs av " + exchangeRate + " SEK/" + currency);
        }
    }
}
