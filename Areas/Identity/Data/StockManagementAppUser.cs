using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StockManagementApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the StockManagementAppUser class
public class StockManagementAppUser : IdentityUser
{
    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // Use the base IdentityUser.PhoneNumber (string). Keep this property as string
    // so it doesn't conflict with the base class.
    public string PhoneNumber { get; set; }
    public bool IsAdmin { get; set; }
}

