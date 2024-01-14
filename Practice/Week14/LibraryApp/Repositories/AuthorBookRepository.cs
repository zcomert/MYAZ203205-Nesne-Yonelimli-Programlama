namespace Repositories;

public class AuthorBookRepository
{
    private RepositoryContext context;

    public AuthorBookRepository(RepositoryContext context)
    {
        this.context = context;
    }
}