using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public enum OrderStatus{Default, Initiated, Ordered, Cancelled}
    public class OrderDetails
    {
        //Field
        public static int _orderID=1000;

        //Propersties
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }

        
        
    }
}