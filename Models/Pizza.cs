using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
