using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ShoppingItem
    {

        private string description;
        private double amount;
        private UnitTypes unit;

        public ShoppingItem(string description, double amount, UnitTypes unit)
        {
            this.description = description;
            this.amount = amount;
            this.unit = unit;

        }
    }
}
