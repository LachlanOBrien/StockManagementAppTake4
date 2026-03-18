using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Display(Name = "Items' ID")]
        public int ItemID { get; set; }
        [Display(Name = "Locations' ID")]
        public int LocationID { get; set; }
        [Display(Name = "Suppliers' ID")]
        public int SupplierID { get; set; }
        [Display(Name = "Order Name")]
        public string OrderName { get; set; }
        [Display(Name = "QUantity Ordered")]
        public int QuantityOrdered { get; set; }
        [Display(Name = "Estimated Time Of Arrival")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstimatedTimeOfArrival { get; set; }
        public ItemStatus Status { get; set; }

        public enum ItemStatus
        {

            Pending,
            Shipped,
            Delivered,
            Cancelled
        }
    }
}
