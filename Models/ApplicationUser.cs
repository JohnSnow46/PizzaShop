using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string? StreetAddres { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
}
