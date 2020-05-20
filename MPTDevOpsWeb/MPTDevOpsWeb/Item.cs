using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPTDevOpsWeb
{
    public class Item
    {
        public int ItemID { get; set; }

        public String ItemCode { get; set; }

        public bool IsAvailable { get; set; }

        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public int ItemCount { get; set; }

        public string itemSize { get; set; }
        public Item()
        {

            ItemID = 0;
            ItemCode = "";
            IsAvailable = false;
            Width = 0;
            Height = 0;
            itemSize = ""; 
        }

        public String GetItemCode()
        {
            string icode = ItemCode;

            return "";
        }

        public int IncreaseItemCount(int amount)
        {
             ItemCount= ItemCount + amount;
            string msg = string.Empty;
            if (ItemCount >=0 ) {
                 msg = "item gt eq zero";
            }
            else {
                 msg = "item lt zero";
            }

            return ItemCount;
        }
        public int DecreaseItemCount(int amount)
        {
            ItemCount = ItemCount - amount;

            return ItemCount;
        }



    }
}