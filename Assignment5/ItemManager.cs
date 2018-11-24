using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ItemManager 
    {
        private List<ShoppingItem> itemList;

        public ItemManager()
        {

            // Creates the list object
            itemList = new List<ShoppingItem>();


        }

        // Checks if item is avaiable in given index 
        public ShoppingItem GetItem (int index) {
            if (!CheckIndex(index)) {
                return null;
            }

            return itemList[index];
               
        }

        // Counts how long to shoppinglist is
        public int Count {
            get { return itemList.Count; }
        }

        // Adds item to shoppinglist
        public bool AddItem(ShoppingItem itemIn)
        {
            bool ok = false;

            Console.WriteLine(itemIn);

            if (itemIn != null) {
                    itemList.Add(itemIn);
                    ok = true;
                }
                return ok;
        }

        // Checks if index exist
        public bool CheckIndex(int index) {
            return (index >= 0) && (index < itemList.Count);
        }


        // Info about items
        public string[] GetItemsInfoStrings() {

            string[] stringInfoStrings = new string[itemList.Count];

            int i = 0;

            foreach (ShoppingItem Itemobj in itemList) {
                stringInfoStrings[i++] = Itemobj.ToString();
            }
            return stringInfoStrings;
        }

    }
}
