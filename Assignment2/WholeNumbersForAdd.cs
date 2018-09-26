using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class WholeNumbersForAdd
    {
        public WholeNumbersForAdd()
        {

            int AmountOfNumbers = ReadAmountOfNumbers();
            List<int> Numbers = ReadNumbers(AmountOfNumbers);

            Console.WriteLine(Numbers[0]);
           
        }

        private int ReadAmountOfNumbers()
        {

            Console.WriteLine("Hur många nummer vill du ange?");
            string TempNum = Console.ReadLine();

            int Num = Int32.Parse(TempNum);

            return Num;
        }

        private List<int> ReadNumbers(int AmountOfNumbers)
        {

            List<int> NumList = new List<int>();
            for (int i = 0; i < AmountOfNumbers; i++)
            {
                Console.WriteLine("Ange nummer " + i + " av " + AmountOfNumbers);
                string TempAnswer = Console.ReadLine();
                int Answer = Int32.Parse(TempAnswer);
                NumList.Add(Answer);

            }
           
            return NumList;
        }


    }
}
