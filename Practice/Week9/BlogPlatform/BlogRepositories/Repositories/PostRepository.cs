using BlogEntities.Models;

namespace BlogRepositories.Repositories;

public static class PostRepository
{
    private static List<Posts> posts;

    static PostRepository()
    {
        posts = new List<Posts>();
    }

    public static void AddPost(Posts post)
    {
        if (post.Equals(null))
            return;
        posts.Add(post);
    }

    public static void AddComment(int id, Comments comment)
    {
        if (comment.Equals(null) || id.Equals(null))
            return;

        for (int i = 0; i < posts.Count; i++)
        {
            if (posts[i].PostId.Equals(id))
            {
                posts[i].CommentList.Add(comment);
                return;
            }
        }
    }

    public static List<Posts> GetAllPosts()
    {
        return posts;
    }

    public static List<Posts> GetAllPostsByAuthor(int id)
    {
        // LINQ
        return posts
        .Where(post => post.Author.UserId.Equals(id))
        .ToList();
    }

    public static Posts? GetOnePostByAuthor(int postId, int userId)
    {
        return posts
        .Where(post => post.PostId.Equals(postId) && post.Author.UserId.Equals(userId))
        .SingleOrDefault();
    }
}
