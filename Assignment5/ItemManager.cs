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

        public ShoppingItem GetItem (int index) {
            if (!CheckIndex(index)) {
                return null;
            }

            return itemList[index];
               
        }

        public int Count {
            get { return itemList.Count; }
        }

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

        public bool CheckIndex(int index) {
            return (index >= 0) && (index < itemList.Count);
        }

        // Change item
        public bool ChangeItem(ShoppingItem itemIn, int index) {

            bool ok = false;
            if ((itemIn != null) && CheckIndex(index)) {
                itemList[index] = itemIn;
                ok = true;
            }
            return ok;
        }

        // Remove item
        public bool DeleteItem(int index) {
            bool ok = false;
            if (CheckIndex (index)) {
                itemList.RemoveAt(index);
                ok = true;
            }
            return ok;
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
