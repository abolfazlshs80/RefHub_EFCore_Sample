namespace RefHub_EFCore_Sample.Database.Model
{
    public class TagToBlog
    {
        public int TagId { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public Tag Tag { get; set; }


    }
}
