using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.API.Entities
{
    public class OrderItem : BaseEntity
    {
        [Range(1, int.MaxValue, ErrorMessage = "Кількість має бути більше 0.")]
        public uint Quantity { get; set; }

        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }

}
