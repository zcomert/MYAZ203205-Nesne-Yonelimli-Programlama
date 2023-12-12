namespace BookModel
{
    public class Category
    {
        public int CategoryId { get; set;}
        public String? CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}