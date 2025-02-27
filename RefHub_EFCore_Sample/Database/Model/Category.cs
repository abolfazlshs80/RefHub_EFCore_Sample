using RefHub_EFCore_Sample.Exception;
using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{
    public class Category
    {

        private string _name;
        public int LanguageId { get; set; }

        [Key]
        public int CategoryId { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length>3&&!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ValidateModelException("this field has emty ");
                }
            }
        }

        public string Desc { get; set; }
        public Language Language { get; set; }

        public ICollection<Blog> Blog { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}
