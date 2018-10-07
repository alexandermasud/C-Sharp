using System;
using System.Collections.Generic;
namespace Assignment2
{
    public class WholeNumbersForAdd
    {
        public WholeNumbersForAdd()
        {

            DisplayMenu();
            int amountOfNumbers = ReadAmountOfNumbers();
            int total = ReadNumbers(amountOfNumbers);
            DisplayTotal(total);
            return;
        }

        private void DisplayMenu(){

            int asterisk = Graphics.AmountOfAsterisk();


            Console.WriteLine(new string('*',asterisk) + " Summation of whole numbers " + new string('*', asterisk));
            Console.WriteLine(new string(' ', asterisk*2) + "using a for statemen");
            Graphics.EmptyRow();
            Graphics.RowOfDashes();

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
        private void DisplayTotal(int total){
            // Skriver ut summan av de angivna numrena
            Console.WriteLine(total);
        }
    }
}
