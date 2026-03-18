using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Supplier>? ItemLocation { get; set; }
        public ICollection<Supplier>? Item { get; set; }
        public ICollection<Supplier>? Order { get; set; }
    }
}
