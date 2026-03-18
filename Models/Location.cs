using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }
        [Display(Name = "Location Address")]
        public string LocationAddress { get; set; }
        public ICollection<Location>? ItemLocations { get; set; }
        public ICollection<Location>? Orders { get; set; }
    }
}
