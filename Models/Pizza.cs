using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Pizza Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        [Range(1,1000)]
        public string Description { get; set; }
    }
}
