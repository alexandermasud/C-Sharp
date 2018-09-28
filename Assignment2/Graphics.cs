using System;
namespace Assignment2
{
    public class Graphics
    {
        public Graphics()
        {
        }

        public static int RowOfDashes(){
            // Returnerar antalet "-" tecken för en rad
            return 50;
        }

        public static int MarginLeft(){
            return 5;
        }

        public static int AmountOfAsterisk(){
            return 4;
        }

        public static void EmptyRow(){
            Console.WriteLine("");
        }
    }
}
