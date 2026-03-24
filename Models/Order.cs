using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Order
    { //[Required(ErrorMessage="This Field cannot be empty")]
        public int OrderID { get; set; }
        
        [Display(Name = "Items' ID")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int ItemID { get; set; }
        

        [Display(Name = "Locations' ID")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int LocationID { get; set; }
        

        [Display(Name = "Suppliers' ID")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int SupplierID { get; set; }
        

        [Display(Name = "Order Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid address.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be 5–100 characters.")]
        public string OrderName { get; set; }
        

        [Display(Name = "Quantity Ordered")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [Range(1, 10000, ErrorMessage = "Your Order Quantity must be between 1 and 10,000.")]
        public int QuantityOrdered { get; set; }
        

        public DateTime TimeAdd100()
        {
            DateTime maxDate = DateTime.Now;
            DateTime maxDateAdd100 = maxDate.AddYears(100);

            return maxDateAdd100;
        }
        public DateTime CurrentTime()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate;
        }
        
        [Display(Name = "Estimated Time Of Arrival")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        // [Range(typeof(DateTime),  "2030-12-31", ErrorMessage = "Please enter a valid date between 2024 and 2030.")]
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
