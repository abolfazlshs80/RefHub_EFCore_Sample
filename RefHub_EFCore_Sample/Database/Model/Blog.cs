using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Text { get; set; }

        public ICollection<FileToBlog> FileToBlog { get; set; }
        public ICollection<CommentToBlog> CommentToBlog { get; set; }

        public Language Language { get; set; }
        public Category Category { get; set; }
        public PersonLevel PersonLevel { get; set; }
    }
}
