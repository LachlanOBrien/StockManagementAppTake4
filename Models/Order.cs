using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StockManagementApp.Models
{
    public class Order : IValidatableObject
    { //[Required(ErrorMessage="This Field cannot be empty")]
        public int OrderID { get; set; }

        [Display(Name = "Items Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int ItemID { get; set; }
        public Item? Item { get; set; }
        // ensures that the Item ID cannot be empty/null

        [Display(Name = "Locations Address")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int LocationID { get; set; }
        public Location? Location { get; set; }
        // ensures that the Location ID cannot be empty/null

        [Display(Name = "Suppliers Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int SupplierID { get; set; }
        public Supplier? Supplier { get; set; }
        // ensures that the Supplier ID cannot be empty/null

        [Display(Name = "Order Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid address.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Order Name must be 5–100 characters.")]
        public string OrderName { get; set; }
        // ensures that the Order Name cannot be empty/null  only contain certain letters such as a-z A-z and 0-9 as well as some other special characters and must be 
        // between 5 and 100 characters long

        [Display(Name = "Quantity Ordered")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [Range(1, 10000, ErrorMessage = "Your Order Quantity must be between 1 and 10,000.")]
        public int QuantityOrdered { get; set; }
        // ensures that the Quantity ordered cannot be empty/null and must be between 1 and 10,000

        [Display(Name = "Estimated Time Of Arrival")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstimatedTimeOfArrival { get; set; }
        // ensures that the Estimated Time OF arrival cannot be empty/null and must be a date in the format of yyyy-MM-dd and between the current date and 100 years from now

        public ItemStatus Status { get; set; }

        public enum ItemStatus
        {

            Pending,
            Shipped,
            Delivered,
            Cancelled
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EstimatedTimeOfArrival <= DateTime.Now)
            {
                yield return new ValidationResult(
                    "Estimated Time Of Arrival cannot be in the past.",
                    new[] { nameof(EstimatedTimeOfArrival) }
                );
            }
            else
            {
                if (EstimatedTimeOfArrival >= DateTime.Now.AddYears(100))
                {
                    yield return new ValidationResult(
                                       "Estimated Time Of Arrival cannot be Greater than 100 Years from now.",
                                       new[] { nameof(EstimatedTimeOfArrival) }
                                   );
                }
            }
        }
    }
}
