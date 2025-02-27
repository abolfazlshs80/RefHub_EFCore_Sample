using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class PersonLevel
    {
        [Key]
        public int PersonLevelId { get; set; }
        public int LanguageId { get; set; }
        public string TypeName { get; set; }

        public Language Language { get; set; }

        public ICollection<Book> Book { get; set; }
 
    }
}
