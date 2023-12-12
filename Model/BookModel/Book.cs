namespace BookModel
{
    public class Book
    {
        public int BookId { get; set; }
        public String? Title { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}