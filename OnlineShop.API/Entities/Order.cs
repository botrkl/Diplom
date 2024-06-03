using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.API.Entities
{
    public class Order : BaseEntity
    {
        [Required(ErrorMessage = "Ім'я замовника обов'язкове.")]
        [MaxLength(100, ErrorMessage = "Максимальна довжина імені замовника - 100 символів.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Електронна пошта замовника обов'язкова.")]
        [EmailAddress(ErrorMessage = "Некоректний формат електронної пошти.")]
        public string CustomerEmail { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
    }
}
