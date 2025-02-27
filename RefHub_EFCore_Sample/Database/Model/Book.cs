using System.ComponentModel.DataAnnotations;

namespace RefHub_EFCore_Sample.Database.Model
{

    public readonly struct Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
    }
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public int LanguageId { get; set; }
        public int CategoryId { get; set; }
        public int PersonLevelId { get; set; }
        public string ISBN { get; set; }
        public string PublisherName { get; set; }
        public string PublisherYear { get; set; }
        public int View { get; set; }
        public Money Price { get; set; }

        public ICollection<BookToAnother> Another { get; set; }
        public ICollection<FileToBook> FileToBook { get; set; }
        public ICollection<CommentToBook> CommentToBook { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }

        public Language Language { get; set; }
        public Category Category { get; set; }
        public PersonLevel PersonLevel { get; set; }
    }
}
