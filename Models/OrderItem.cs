using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StockManagementApp.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public Order? Order { get; set; }
        public string OrderName { get; set; }
        public int ItemID { get; set; }
        public Item? Item { get; set; }
        public int QuantityOrdered { get; set; }
    }
}
