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


        public Party (int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests];
        }
    }

}
