using System;

namespace Assignment1A
{
    class PetOwnerMain
    {
        public static void Main(string[] args)
        {
            var pet = new Pet();

            pet.AskTheUser();
            pet.PresentThePet();
        }
    }
}
