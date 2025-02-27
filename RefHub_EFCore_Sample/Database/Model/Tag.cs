using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public int LanguageId { get; set; }
        public string Name{ get; set; }

        public Language Language { get; set; }
        public ICollection<TagToBlog> TagToBlog { get; set; }
        public ICollection<TagToBook> TagToBook { get; set; }

    }
}
