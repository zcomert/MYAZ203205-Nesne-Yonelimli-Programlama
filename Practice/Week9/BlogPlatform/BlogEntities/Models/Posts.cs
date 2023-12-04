namespace BlogEntities.Models;

public class Posts
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public Users Author { get; set; }
    public List<Comments> CommentList { get; set; }

    public Posts()
    {
        CommentList = new List<Comments>();
    }
}