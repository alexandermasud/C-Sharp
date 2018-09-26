using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class WholeNumbersForAdd
    {
        public WholeNumbersForAdd()
        {

            int AmountOfNumbers = ReadAmountOfNumbers();
            int Total = ReadNumbers(AmountOfNumbers);
            DisplayTotal(Total);
            return;
        }

        private int ReadAmountOfNumbers()
        {

            Console.WriteLine("Hur många nummer vill du ange?");
            string TempNum = Console.ReadLine();
            int Num = Int32.Parse(TempNum);
            return Num;
        }

        private int ReadNumbers(int AmountOfNumbers)
        {

            List<int> NumList = new List<int>();
            for (int i = 0; i < AmountOfNumbers; i++)
            {
                Console.WriteLine("Ange nummer " + i + " av " + AmountOfNumbers);
                string TempAnswer = Console.ReadLine();
                int Answer = Int32.Parse(TempAnswer);
                NumList.Add(Answer);
            }

            int Total = 0;
            for (int i = 0; i < NumList.Count; i++)
            {
                int TempNum  = NumList[i];
                Total = Total + TempNum;
            }
            return Total;
        }
        private void DisplayTotal(int Total){
            Console.WriteLine(Total);
        }
    }
}
