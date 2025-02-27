using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        [Key]
        public int OrderItemId { get; set; }
        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}
