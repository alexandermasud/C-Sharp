using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ShoppingItem
    {

        // Decalres variables for class
        private string description;
        private double amount;
        private UnitTypes unit;

        public ShoppingItem(string description, double amount, UnitTypes unit)
        {
            this.description = description;
            this.amount = amount;
            this.unit = unit;

        }

        public ShoppingItem() : this("Unknown", 1.0, UnitTypes.piece)
        {

        }

        public ShoppingItem(string description) : this(description, 1.0, UnitTypes.piece)
        {

        }

        // Get and set for Unit
        public UnitTypes Unit {

            get { return Unit; }
            set {
                // Check if value is defined in the enum
                if (Enum.IsDefined(typeof(UnitTypes), value)) {
                    unit = value;
                }
            }
        }

        // Get and set for description
        public string Description{
            get { return description; }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        // Get and set for amount
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value > 0.0)
                {
                    amount = value;
                }
                
            }
        }

        // Styles text for better readability 
        public override string ToString()
        {
            string textOut = string.Empty;
            textOut = $"{ description,-45} {amount,6:f2} {unit,-6}";
            return textOut;
        }

    }
}
