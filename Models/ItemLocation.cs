using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class ItemLocation
    {
        public int ItemLocationID { get; set; }
        
        
        [Display(Name = "Items'ID")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int ItemID { get; set; }
        
        
        [Display(Name = "Suppliers' ID")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int SupplierID { get; set; }
       
        
        [Display(Name = "Locations' ID")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        public int LocationID { get; set; }


        [Required(ErrorMessage = "This Field cannot be empty")]
        [Range(0, 10000, ErrorMessage = "Your Quantity must be between 0 and 10,000.")]
        public int Quantity { get; set; }
    }
}
