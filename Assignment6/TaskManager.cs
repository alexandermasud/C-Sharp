using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class TaskManager
    {   
        // Creates itemList
        private List<Task> itemList;

        // Starts itemlist
        public TaskManager() {
            itemList = new List<Task>();
        }

        // Returns index of list
        public Task GetItem(int index) {
            if (!CheckedIndex(index)){
                return null;
            }
            return itemList[index];

        }

        // Counts length of itemlist
        public int Count {
            get { return itemList.Count; }
        }


        // Adds item to list
        public bool AddItem(Task itemIn) {

            bool ok = false;
            if (itemIn != null) {
                itemList.Add(itemIn);
                ok = true;
            }
            return ok;
        }

        // Checks if there is more in list
        public bool CheckedIndex(int index) {
            return ((index >= 0) && (index < itemList.Count));
        }

        // Assigns ItemObjects to given index in stringInfoStrings list
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
