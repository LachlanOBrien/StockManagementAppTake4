using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class ItemLocation
    {
        public int ItemLocationID { get; set; }
        
        
        [Display(Name = "Items Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int ItemID { get; set; }
        public Item? Item { get; set; }
        // ensures that the item ID cannot be empty/null

        [Display(Name = "Suppliers Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int SupplierID { get; set; }
        public Supplier? Supplier { get; set; }
        // ensures that the Supplier ID cannot be empty/null

        [Display(Name = "Locations Address")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int LocationID { get; set; }
        public Location? Location { get; set; }
        // ensures that the Location ID cannot be empty/null

        [Required(ErrorMessage = "This Field cannot be empty")]
        [Range(0, 10000, ErrorMessage = "Your Quantity must be between 0 and 10,000.")]
        public int Quantity { get; set; }
        // ensures that the Quantity cannot be empty/null and must be between 0 and 10,000
    }
}
