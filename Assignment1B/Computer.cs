using System;
namespace Assignment1B
{
    public class Computer
    {

        private String Brand;
        private String TempScreenSize;
        private Int32 ScreenSize;
        private String TempLaptop;
        private Boolean Laptop = false;

        public void SetComputer() {

            Console.WriteLine("Ange datorns märke");
            Brand = Console.ReadLine();

            Console.WriteLine("Ange skärmens storlek");
            TempScreenSize = Console.ReadLine();
            Int32.TryParse(TempScreenSize, out ScreenSize);

            Console.WriteLine("Är datorn en laptop (y/n)?");
            TempLaptop = Console.ReadLine().ToLower();
            if (TempLaptop == "y")
            {
                Laptop = true;
            }
        }

        public void GetComputer()
        {
            Console.WriteLine("");
            Console.WriteLine("*****");
            Console.WriteLine("");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Screen size: " + ScreenSize);
            Console.WriteLine("Laptop: " + Laptop);
            Console.WriteLine("");
            Console.WriteLine("*****");

        }
    }
}