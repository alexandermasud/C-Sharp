using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class TaskManager
    {
        private List<Task> itemList;


        public TaskManager() {
            itemList = new List<Task>();
        }

        public Task GetItem(int index) {
            if (!CheckedIndex(index)){
                return null;
            }
            return itemList[index];

        }

        public int Count {
            get { return itemList.Count; }
        }

        public bool AddItem(Task itemIn) {

            Console.WriteLine("itemIn: " + itemIn);

            bool ok = false;
            if (itemIn != null) {
                itemList.Add(itemIn);
                ok = true;
            }
            return ok;
        }

        public bool CheckedIndex(int index) {
            return ((index >= 0) && (index < itemList.Count));
        }

        public string[] GetItemsInfoStrings() {
            string[] stringInfoStrings = new string[itemList.Count];

            int i = 0;

            foreach (Task Itemobj in itemList)
            {
                stringInfoStrings[i++] = Itemobj.ToString();

            }

            return stringInfoStrings;
        }


    }


}
