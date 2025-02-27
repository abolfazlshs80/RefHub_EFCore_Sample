using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RefHub_EFCore_Sample.Database.Model
{
 
    public enum OrderStatus
    {
        Pending = 0,
        Processing = 1,
        Completed = 2,
        Cancelled = 3
    }
    public class Order
    {
        public int UserId { get; set; }
        public int UserAddressId { get; set; }

        [Key]
        public int OrderId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }

        public UserAddress UserAddress { get; set; }

        public User User { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
