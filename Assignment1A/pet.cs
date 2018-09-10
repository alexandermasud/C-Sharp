using System;

namespace Assignment1A
{
    class Pet
    {

        private String Name;
        private String TempAge;
        private Int32 Age;
        private String TempIsFemale;
        private Boolean IsFemale;


        public void AskTheUser()
        {
            Console.WriteLine("Vad heter husdjuret ? ");
            Name = Console.ReadLine();

            Console.WriteLine("Hur många år är husdjuret ? ");
            TempAge = Console.ReadLine();
            Int32.TryParse(TempAge, out Age);

            Console.WriteLine("Är husdjuret en hona? ");
            TempIsFemale = Console.ReadLine().ToLower();

            if (TempIsFemale == "y"){
                IsFemale = true;
            }
            else{
                IsFemale = false;
            }

            
        }

        public void PresentTheUser()
        {

            Console.WriteLine("*****");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Female: " + IsFemale);
            Console.WriteLine("*****");

        }

    }

}



