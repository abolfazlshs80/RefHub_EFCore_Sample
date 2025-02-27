using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class Another
    {
        [Key]
        public int AnotherId { get; set; }
        public int Name { get; set; }
        public int LanguageId { get; set; }

        public ICollection<BookToAnother> BookToAnother { get; set; }

        public Language Language { get; set; }
    
    }
}
