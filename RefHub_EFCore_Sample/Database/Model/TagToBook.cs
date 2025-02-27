namespace RefHub_EFCore_Sample.Database.Model
{
    public class TagToBook
    {
        public int TagId { get; set; }
        public int BookId{ get; set; }
        public Book Book { get; set; }
        public Tag Tag { get; set; }
    }
}
