using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Party
    {

        private double costPerCapita;
        private string[] guestList;


        public Party(int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests];
        }

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

                return ok;
            }
        }

        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        }

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
        }

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
        }

        public int Count
        {
            get { return NumOfGuests(); }
        }

        public double CalcTotalCost (){
            int numOfGuests = NumOfGuests();
            double totalCost = numOfGuests * costPerCapita;
            return totalCost;
        }

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

        public bool CheckIndex (int index){
            return (index >= 0) && (index < guestList.Length);
        }

        public string GetItemAt (int index){
            if (CheckIndex (index)){
                return guestList[index];;
            }

            return null;
        }

        public bool DeleteAt (int index){

            if(CheckIndex (index)){

                guestList[index] = string.Empty;
                return true;
            }
            else{
                return false;
            }
        }

        public bool ChangeAt(int index, string firstName, string lastName){

            bool ok = false;

            if(CheckIndex (index)){
                guestList[index] = FullName(firstName, lastName);
            }
            else{
                ok = true;
            }
            return ok;
        }


    }
}