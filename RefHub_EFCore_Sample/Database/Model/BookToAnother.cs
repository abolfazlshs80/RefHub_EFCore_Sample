namespace RefHub_EFCore_Sample.Database.Model
{
    public class BookToAnother
    {
        public int BookId { get; set; }
        public int AnotherId { get; set; }

        public Book Book { get; set; }
        public Another Another { get; set; }
    }
}
