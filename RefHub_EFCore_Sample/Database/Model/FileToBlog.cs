namespace RefHub_EFCore_Sample.Database.Model
{
    public class FileToBlog
    {
        public int BlogId { get; set; }
        public int FileId { get; set; }
        public Blog Blog { get; set; }
        public FileManager FileManager { get; set; }
    }
}
