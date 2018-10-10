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

            // Används för att skapa marginal till vänster för menyer
        public static int MarginLeft(){
            return 5;
        }

            // Anger hur många asterisker som ska användas i menyer
        public static int AmountOfAsterisk(){
            return 4;
        }

            // Används för att ska en tom rad
        public static void EmptyRow(){
            Console.WriteLine("");
        }

        public static int AmountOfStars(){
            return 4;
        }
    }
}
