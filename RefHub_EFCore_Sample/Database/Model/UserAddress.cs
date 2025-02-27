using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class UserAddress
    {
        [Key]
        public int UserAddressId { get; set; }
        public int UserId { get; set; }
        public string PostalCode{ get; set; }
        public string Phone{ get; set; }
        public string City { get; set; }
        public string Ostan { get; set; }
        public string Address{ get; set; }
        public string Desc{ get; set; }
        public string Name{ get; set; }
        //     public ICollection<Order> Order { get; set; }

        public User User { get; set; }
    }
}
