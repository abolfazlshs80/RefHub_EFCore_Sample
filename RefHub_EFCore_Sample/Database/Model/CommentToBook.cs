using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class CommentToBook
    {
        [Key]
        public int CommentId { get; set; }
        public int BookId { get; set; }
        public int SubCommentId { get; set; }
        public string FullName { get; set; }
        public string Email{ get; set; }
        public string Title{ get; set; }
        public string Text{ get; set; }

        public Book Book { get; set; }

    }
}
