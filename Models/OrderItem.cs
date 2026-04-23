using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StockManagementApp.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        [Display(Name = "Order Name")]
        public int OrderID { get; set; }
        public Order? Order { get; set; }
        [Display(Name = "Item Name")]
        public int ItemID { get; set; }
        public Item? Item { get; set; }


        // ensures that the Quantity ordered cannot be empty/null and must be between 1 and 10,000
        [Display(Name = "Quantity Ordered")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [Range(1, 10000, ErrorMessage = "Your Order Quantity must be between 1 and 10,000.")]
        public int QuantityOrdered { get; set; }

        
    }
}
