using Entities.Models;

namespace Repositories.Interfaces;

public interface ICommentRepository
{
    // CRUD
    // CREATE
    public void AddComment(Comment comment);

    // READ
    public Comment GetOneComment(int id);
    public List<Comment> GetAllComment();

    // UPDATE
    public void UpdateComment(int id, Comment comment);

    // DELETE
    public Comment DeleteOneComment(int id);
}