namespace RefHub_EFCore_Sample.Database.Model
{
    public class FileToBook
    {
        public int FileId { get; set; }
        public int BookId{ get; set; }
        public Book Book { get; set; }
        public FileManager FileManager { get; set; }
    }
}
