using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class ItemLocation
    {
        public int ItemLocationID { get; set; }
        [Display(Name = "Items'ID")]
        public int ItemID { get; set; }
        [Display(Name = "Suppliers' ID")]
        public int SupplierID { get; set; }
        [Display(Name = "Locations' ID")]
        public int LocationID { get; set; }
        public int Quantity { get; set; }
    }
}
