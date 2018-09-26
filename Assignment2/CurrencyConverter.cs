using System;
namespace Assignment2
{
    public class CurrencyConverter
    {
        public CurrencyConverter()
        {

            double Total = ReadNumbers();
            string Currency = ReadCurrency();
            double ExchangeRate = ReadExchangeRate();
            double TotalSum = CalculationOfNumbers(Total, ExchangeRate);
            DisplayTotal(Total, Currency, ExchangeRate, TotalSum);
        }

        private double ReadNumbers()
        {
            // Processas inputs och summerar dessa
            double Total = 0;
            while (true)
            {
                Console.WriteLine("Ange ett nummer till summan");
                string TempNum = Console.ReadLine();
                double Num = Double.Parse(TempNum);


                if (Num == 0.00)
                {
                    return Total;
                }
                else
                {
                    Total = Total + Num;
                }
            }
        }
        private string ReadCurrency()
        {
            Console.WriteLine("Ange valuta:");
            string Answer = Console.ReadLine();
            return Answer;
        }

        private double ReadExchangeRate()
        {
            Console.WriteLine("Ange växelkurs:");
            string TempAnswer = Console.ReadLine();
            double Answer = Double.Parse(TempAnswer);
            return Answer;
        }

        private double CalculationOfNumbers(double Total, double ExchangeRate){

            double TotalSum = Total / ExchangeRate;
            TotalSum = Math.Round(TotalSum, 2);
            return TotalSum;
        }
        private void DisplayTotal(double Total, string Currency, double ExchangeRate, double TotalSum)
        {
            // Skriver ut den totala summan
            Console.WriteLine("Att växla " + Total + " SEK");
            Console.WriteLine("");
            Console.WriteLine(Total + " SEK blir " + TotalSum + " " + Currency + " med en växelkurs av " + ExchangeRate + " SEK/" + Currency);
        }
    }
}
