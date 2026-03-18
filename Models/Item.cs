using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        [Display(Name = "Suppliers' ID")]
        public int SupplierID { get; set; }
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        [Display(Name = "Item Description")]
        public string ItemDescription { get; set; }
        public int Price { get; set; }
        [Display(Name = "Minimum Stock")]
        public int MinimumStock { get; set; }
        public ICollection<Item>? ItemLocation { get; set; }
        public ICollection<Item>? Order { get; set; }
    }
}
