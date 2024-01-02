using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class AuthorRepository
{
    public RepositoryContext context;

    public AuthorRepository(RepositoryContext context)
    {
        this.context = context;
    }

    public Authors AuthorInfo(int id)
    {
        var author = context
        .Authors
        .Include(a => a.Books)
        .SingleOrDefault(a => a.Id.Equals(id));

        if (author is null)
            throw new Exception("Author not find!");

        return author;
    }

    public void AddAuthor(Authors author)
    {
        context.Authors.Add(author);
        context.SaveChanges();
    }
}