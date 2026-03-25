using System.ComponentModel.DataAnnotations;

namespace StockManagementApp.Models
{
    public class Location
    {
        public int LocationID { get; set; }
       
        
        [Display(Name = "Location Name")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid Location Name.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name must be between 5–100 characters.")]
        public string LocationName { get; set; }
        
        
        [Display(Name = "Location Address")]
        [Required(ErrorMessage = "This Field cannot be empty")]
        [RegularExpression(@"^[a-zA-Z0-9\s,'\-\/\.#]+$", ErrorMessage = "Please enter a valid address.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be 5–100 characters.")]
        public string LocationAddress { get; set; }


        public ICollection<Location>? ItemLocations { get; set; }
        public ICollection<Location>? Orders { get; set; }
    }
}
