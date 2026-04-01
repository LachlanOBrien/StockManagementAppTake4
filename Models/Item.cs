using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Item
    {
        public int ItemID { get; set; }


        [Display(Name = "Suppliers Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int SupplierID { get; set; }
        public Supplier? Supplier { get; set; }
        // ensures that the suppliers id cannot be empty/null 

        [Display(Name = "Item Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid Name.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Item name must be between 5–100 characters.")]
        public string ItemName { get; set; }
        // ensures that the Item Name cannot be empty/null  only contain certain letters such as a-z A-z and 0-9 as well as some other special characters and must be 
        // between 5 and 100 characters long

        [Display(Name = "Item Description")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public string ItemDescription { get; set; }
        // ensures that the Item Description cannot be empty/null


        [Required(ErrorMessage = "This Field cannot be empty")]
        [Range(0.01, 100000.00, ErrorMessage = "Price of the Item must be between $0.01 and $100,000.00")]
        public int Price { get; set; }
        // ensures that the Price cannot be empty/null and must be between 0.01 and 100,000.00

        [Display(Name = "Minimum Stock")]
        [Range(0, 10000, ErrorMessage = "Your Minimum Item stock must be between 0 and 10,000.")]
        public int MinimumStock { get; set; }
        // ensures that the minimum stock cannot be empty/null and must be between 0 and 10,000

        public ICollection<ItemLocation>? ItemLocation { get; set; }
        public ICollection<Order>? Order { get; set; }
    }
}
