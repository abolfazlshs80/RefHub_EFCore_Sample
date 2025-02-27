namespace RefHub_EFCore_Sample.Database.Model
{
    public class FileToUser
    {
            public int UserId { get; set; }
            public int FileId { get; set; }
            public User User { get; set; }
            public FileManager FileManager { get; set; }
    }
}
