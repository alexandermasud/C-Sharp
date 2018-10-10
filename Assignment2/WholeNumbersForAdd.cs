using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class WholeNumbersForAdd
    {
        public WholeNumbersForAdd()
        {
            int asterisk = Graphics.AmountOfAsterisk();
            int rowOfDashes = Graphics.RowOfDashes();

            DisplayMenu(asterisk, rowOfDashes);
            int amountOfNumbers = ReadAmountOfNumbers();
            int total = ReadNumbers(amountOfNumbers);
            DisplayTotal(total, rowOfDashes);
            return;
        }

        private void DisplayMenu(int asterisk, int rowOfDashes){


            Console.WriteLine(new string('*',asterisk) + " Summation of whole numbers " + new string('*', asterisk));
            Console.WriteLine(new string(' ', asterisk*2) + "using a for statement");
            Graphics.EmptyRow();
            Console.WriteLine(new string('-', rowOfDashes));

        }

        private int ReadAmountOfNumbers()
        {
            // Anger hur många nummer som kommer att anges

            Console.Write("Number of whole numbers to add?");
            int num = Input.ReadIntegerConsole();
            return num;
        }

        private int ReadNumbers(int amountOfNumbers)
        {
            // Anger numren samt summerar dessa
            List<int> numList = new List<int>();
            Graphics.EmptyRow();
            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.Write("Please give the value number no " + (i+1) + " (whole number): ");
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
        private void DisplayTotal(int total, int rowOfDashes){
            // Skriver ut summan av de angivna numrena

            Console.WriteLine(new string('-', rowOfDashes));
            Console.WriteLine("The sum is: " + total);
        }
    }
}
