using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Party
    {
        // Inits variables
        private double costPerCapita;
        private string[] guestList;


        // Creates array with party members
        public Party(int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests];
        }

        // Gets and sets the cost per person
        public double CostPerCapita
        {
            get
            {
                return costPerCapita;
            }
            set
            {
                if (value >= 0)
                {
                    costPerCapita = value;
                }
            }
        }

        //Adds a new memeber to the party, if full returns false
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();
            if (vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        // Changes Lastname to uppercase
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        }

        // Loops array to find an empty spot in array for a new person
        private int FindVacantPos()
        {
            int vacantPos = -1;

            for (int index = 0; index < guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }

        // The amount of guest in the party
        private int NumOfGuests()
        {
            int numGuests = 0;

            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }

        // The number of current amount of guest in the party
        public int Count
        {
            get { return NumOfGuests(); }
        }

        // Calculates the total cost of the party
        public double CalcTotalCost (){
            int numOfGuests = NumOfGuests();
            double totalCost = numOfGuests * costPerCapita;
            return totalCost;
        }

        // Gets the capacity of the party, ie slots in the array
        public string[] GetGuestList (){
            int size = NumOfGuests();

            if(size <= 0){
                return null;
            }

            string[] guests = new string[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if(!string.IsNullOrEmpty (guestList[i])){
                    guests[j++] = guestList[i];
                }
            }
            return guests;
        }

        // Checks index of array
        public bool CheckIndex (int index){
            return (index >= 0) && (index < guestList.Length);
        }

        // Gets member of slot x in array
        public string GetItemAt (int index){
            if (CheckIndex (index)){
                return guestList[index];;
            }

            return null;
        }

        // Deletes a memeber in a given slot in array
        public bool DeleteAt (int index){

            if(CheckIndex (index)){

                guestList[index] = string.Empty;
                return true;
            }
            else{
                return false;
            }
        }
    }
}