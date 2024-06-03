using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.API.Entities
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "Назва товару обов'язкова.")]
        [MaxLength(200, ErrorMessage = "Максимальна довжина назви товару - 200 символів.")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Ціна має бути більше 0.")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Кількість на складі не може бути від'ємною.")]
        public uint StockQuantity { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
