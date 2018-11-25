using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Task
    {
        // Declaration of variables
        private string description;
        private PriorityType priority;
        private DateTime dateAndTime;

        // Constructor
        public Task(string description, PriorityType priority, DateTime dateAndTime) {
            this.description = description;
            this.priority = priority;
            this.dateAndTime = dateAndTime;
        }

        // Constructor
        public Task() : this("Unknown", PriorityType.Less_important, default(DateTime)) {
        }

        // Constructor
        public Task(string description) : this(description, PriorityType.Less_important, default(DateTime)) {
        }

        // Set and Get for PriorityType such as Normal, Important etc
        public PriorityType Priority {

            get { return Priority; }
            set {
                if (Enum.IsDefined(typeof(PriorityType), value)) {
                    priority = value;
                }
            }
        }

        // Get and Set for Description
        public string Description {
            get { return description; }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        // Get and set for date and time
        public DateTime DateAndTime {
            get { return dateAndTime;  }
            set {
                if (dateAndTime == default(DateTime))
                {
                    dateAndTime = value;
                }
            }
        }

        // Returns Time as string
        public string GetTimeString() {
            return dateAndTime.ToShortTimeString();
        }

        // REturns Priority as string
        public string GetPriorityString() {
            return priority.ToString();
        }

       
        // ToString method for princing out rows in Listbox
        public override string ToString()
        {
            
            string textOut = string.Empty;
            textOut = $"{ dateAndTime.ToShortDateString(),-60} {GetTimeString(),-25} {GetPriorityString(),-30} {description}";
            return textOut;
        }
    }
}
