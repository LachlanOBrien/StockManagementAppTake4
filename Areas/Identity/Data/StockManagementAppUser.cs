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
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public bool IsAdmin { get; set; }
}

