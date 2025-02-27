namespace RefHub_EFCore_Sample.Database.Model
{
    public class UserToRole
    {
        public int RoleId { get; set; }
        public int UserId{ get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
