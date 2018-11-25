using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Task
    {

        private string description;
        private PriorityType priority;
        private DateTime dateAndTime;


        public Task(string description, PriorityType priority, DateTime dateAndTime) {

            this.description = description;
            this.priority = priority;
            this.dateAndTime = dateAndTime;
        }

        public Task() : this("Unknown", PriorityType.Less_important, default(DateTime)) {

        }

        public Task(string description) : this(description, PriorityType.Less_important, default(DateTime)) {
        }

        public PriorityType Priority {

            get { return Priority; }
            set {
                if (Enum.IsDefined(typeof(PriorityType), value)) {
                    priority = value;
                }
            }
        }

        public string Description {
            get { return description; }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        public DateTime DateAndTime {
            get { return dateAndTime;  }
            set {
                if (dateAndTime == default(DateTime))
                {
                    dateAndTime = value;
                }
            }
        }

        public string GetTimeString() {
            return dateAndTime.ToShortTimeString();
        }

        public string GetPriorityString() {
            return priority.ToString();
        }

       

        public override string ToString()
        {
            return $"{dateAndTime.ToShortDateString(),-12}" +
                   $"{GetTimeString(),-7}" +
                   $"{GetPriorityString(),-16}" +
                   $"{description}";
        }
    }
}
