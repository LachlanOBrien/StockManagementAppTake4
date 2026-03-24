using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [Display(Name = "Supplier Name")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid address.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be 5–100 characters.")]
        public string SupplierName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber), MaxLength(15)]
        [RegularExpression(@"^(\+64\s?\d{1,2}\s?\d{3,4}\s?\d{3,4}|0\d{1,2}\s?\d{3,4}\s?\d{3,4})$", ErrorMessage = "Please enter a valid New Zealand phone number (e.g., +64 21 234 5678 or 021 234 5678).")]
        public int PhoneNumber { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid address.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be 5–100 characters.")]
        public string Address { get; set; }
        public ICollection<Supplier>? ItemLocation { get; set; }
        public ICollection<Supplier>? Item { get; set; }
        public ICollection<Supplier>? Order { get; set; }
    }
}
