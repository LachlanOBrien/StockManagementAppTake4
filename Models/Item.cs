using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Item
    {
        public int ItemID { get; set; }
       
        
        [Display(Name = "Suppliers' ID")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int SupplierID { get; set; }
        
        
        [Display(Name = "Item Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid Name.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Item name must be between 5–100 characters.")]
        public string ItemName { get; set; }
        
        
        [Display(Name = "Item Description")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public string ItemDescription { get; set; }


        [Required(ErrorMessage = "This Field cannot be empty")]
        [Range(0.01, 100000.00, ErrorMessage = "Price of the Item must be between $0.01 and $100,000.00")]
        public int Price { get; set; }
        
        
        [Display(Name = "Minimum Stock")]
        [Range(0, 10000, ErrorMessage = "Your Minimum Item stock must be between 1 and 10,000.")]
        public int MinimumStock { get; set; }
        
        
        public ICollection<Item>? ItemLocation { get; set; }
        public ICollection<Item>? Order { get; set; }
    }
}
