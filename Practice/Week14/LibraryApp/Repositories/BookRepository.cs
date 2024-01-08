using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class BookRepository
{
    public RepositoryContext context;

    public BookRepository(RepositoryContext context)
    {
        this.context = context;
    }

    public Books BookInfo(int id)
    {
        var book = context
        .Books
        .Include(a => a.Authors)
        .SingleOrDefault(a => a.Id.Equals(id));

        if (book is null)
            throw new Exception("Book not find!");

        return book;
    }

    public void AddBook(Books book)
    {
        context.Books.Add(book);
        context.SaveChanges();
    }

    // PUT
    public void Borrow(int id)
    {
        var book = BookInfo(id);
        if (book.Quantity <= 0)
            throw new Exception($"The {book.Title} is not in stock!");

        book.Quantity -= 1;
        context.SaveChanges();
    }

    public void Return(int id){
        var book = BookInfo(id);

        book.Quantity += 1;
        context.SaveChanges();
    }

}