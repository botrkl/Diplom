using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.API.Entities
{
    public class ShippingAddress : BaseEntity
    {
        [Required(ErrorMessage = "Країна обов'язкова.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Місто обов'язкове.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Вулиця обов'язкова.")]
        public string Street { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Номер будинку має бути більше 0.")]
        public uint HouseNumber { get; set; }

        [ForeignKey("Order")] // Вказуємо зовнішній ключ
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
