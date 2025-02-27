using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string DisplayName{ get; set; }


        public ICollection<Blog> Blog { get; set; }
        public ICollection<Book> Book { get; set; }
        public ICollection<Tag> Tag { get; set; }
        public ICollection<Category> Category { get; set; }
        public ICollection<PersonLevel> PersonLevel { get; set; }

    }
}
