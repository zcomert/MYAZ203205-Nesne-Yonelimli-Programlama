namespace Entities.Models;

public class Comment
{
    public int CommentId { get; set; }
    public int ProductId { get; set; }
    public String? Text { get; set; } = string.Empty;

    public DateTime AtCreatedDate { get; set; } = DateTime.UtcNow;
}