using Entities.Models;
using Repositories.Interfaces;

namespace Repositories;

public class CommentRepository : ICommentRepository
{
    private RepositoryContext context;

    public CommentRepository(RepositoryContext context)
    {
        this.context = context;
    }

    public void AddComment(Comment comment)
    {
        if (comment.ProductId <= 0)
            throw new Exception("Required field have wrong value!");

        context.Comments.Add(comment);
        context.SaveChanges();
    }

    public Comment DeleteOneComment(int id)
    {
        var cmt = GetOneComment(id);
        context.Comments.Remove(cmt);
        try
        {
            context.SaveChanges();
            return cmt;
        }
        catch (Exception e)
        {
            throw new Exception($"Something go wrong!: {e.Message}");
        }
    }

    public List<Comment> GetAllComment()
    {
        return context.Comments.ToList();

    }

    public Comment GetOneComment(int id)
    {
        var cmt = context
        .Comments
        .SingleOrDefault(cmt => cmt.ProductId.Equals(id));

        if (cmt is null)
            throw new Exception("Comment not found!");

        return cmt;
    }

    public void UpdateComment(int id, Comment comment)
    {
        if (comment.ProductId <= 0)
            throw new Exception("Required field value is wrong!");

        var cmt = GetOneComment(id);

        cmt.Text = comment.Text;
        cmt.ProductId = comment.ProductId;
        // cmt.AtCreatedDate = comment.AtCreatedDate;

        try
        {
            context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception($"Something go wrong!: {e.Message}");
        }
    }
}