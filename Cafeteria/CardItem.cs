using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class CardItem
    {
        //Fields
        public static int _itemID = 100;
        //Properties
        public string ItemID { get; set; }
        public string OrderID { get; set; }
        public double OrderPrice { get; set; }
        public int OrderQuantity { get; set; }
        
    }
}