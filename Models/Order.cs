using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StockManagementApp.Models
{
    public class Order : IValidatableObject
    { //[Required(ErrorMessage="This Field cannot be empty")]

        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

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
        public ICollection<OrderItem>? OrderItem { get; set; } = new List<OrderItem>();
    }
}
