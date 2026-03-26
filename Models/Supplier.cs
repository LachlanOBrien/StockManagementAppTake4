using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        
        
        [Display(Name = "Supplier Name")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid Name.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "name must be between 5–100 characters.")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "This Field cannot be empty")]
        [StringLength(50, ErrorMessage = "Email must be under 50 characters.")]
        public string Email { get; set; }
        
        
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^(\d{1,2}\s?\d{3,4}\s?\d{3,4})$", ErrorMessage = "Please enter a valid New Zealand phone number (e.g. 021 234 5678).")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int PhoneNumber { get; set; }
        
        
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid address.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be 5–100 characters.")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public string Address { get; set; }
        
        
        public ICollection<Supplier>? ItemLocation { get; set; }
        public ICollection<Supplier>? Item { get; set; }
        public ICollection<Supplier>? Order { get; set; }
    }
}
