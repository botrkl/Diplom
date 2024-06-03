using System.ComponentModel.DataAnnotations;

namespace OnlineShop.API.Entities
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Ім'я категорії обов'язкове.")]
        [MaxLength(100, ErrorMessage = "Максимальна довжина імені категорії - 100 символів.")]
        public string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
