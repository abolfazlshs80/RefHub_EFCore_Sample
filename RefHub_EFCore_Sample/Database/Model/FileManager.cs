using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class FileManager
    {
        [Key]
        public int FileId { get; set; }
        public string FileName{ get; set; }
        public string Type{ get; set; }

        public ICollection<FileToBlog> FileToBlog { get; set; }
        public ICollection<FileToBook> FileToBook { get; set; }
        public ICollection<FileToUser> FileToUser { get; set; }


    }
}
