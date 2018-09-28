using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class WholeNumbersForAdd
    {
        public WholeNumbersForAdd()
        {

            int amountOfNumbers = ReadAmountOfNumbers();
            int total = ReadNumbers(amountOfNumbers);
            DisplayTotal(total);
            return;
        }

        private int ReadAmountOfNumbers()
        {
            // Anger hur många nummer som kommer att anges
            Console.WriteLine("Hur många nummer vill du ange?");
            int num = Input.ReadIntegerConsole();;
            return num;
        }

        private int ReadNumbers(int amountOfNumbers)
        {
            // Anger numren samt summerar dessa
            List<int> numList = new List<int>();
            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.WriteLine("Ange nummer " + i + " av " + amountOfNumbers);
                int answer = Input.ReadIntegerConsole();
                numList.Add(answer);
            }

            int total = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                int tempNum  = numList[i];
                total = total + tempNum;
            }
            return total;
        }
        private void DisplayTotal(int total){
            // Skriver ut summan av de angivna numrena
            Console.WriteLine(total);
        }
    }
}
