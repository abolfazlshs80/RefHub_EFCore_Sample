using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
     
        public Dictionary<string, string>? Attributes { get; set; }
        //   public int  PictrueId { get; set; }
        public ICollection<FileToUser> FileToUser { get; set; }
        public ICollection<UserAddress> UserAddress { get; set; }
        public ICollection<UserToRole> UserToRole { get; set; }
        public ICollection<Order> Order { get; set; }

    }


}
