using BlogEntities.Models;
using BlogRepositories.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

[ApiController]
[Route("api/posts")]
public class PostsController : ControllerBase
{
    [HttpPost]
    public void AddPost(Posts post)
    {
        PostRepository.AddPost(post);
    }

    [HttpPost("{id:int}")]
    public void AddComment([FromRoute] int id, [FromBody] Comments comment)
    {
        PostRepository.AddComment(id, comment);
    }

    [HttpGet]
    public List<Posts> GetAllPosts()
    {
        return PostRepository.GetAllPosts();
    }

    [HttpGet("{id:int}")]
    public List<Posts> GetAllPostsByAuthor([FromRoute] int id)
    {
        return PostRepository.GetAllPostsByAuthor(id);
    }

    [HttpGet("{postId:int}, {userId:int}")]
    public Posts? GetOnePostByAuthor([FromRoute] int postId, [FromRoute] int userId)
    {
        return PostRepository.GetOnePostByAuthor(postId, userId);
    }
}