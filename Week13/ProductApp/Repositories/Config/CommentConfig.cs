using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.CommentId); // Id, CommentId

        builder.HasData(
           new Comment() { CommentId = 1, Text = "Harika bir ürün.", ProductId = 1 },
           new Comment() { CommentId = 2, Text = "Berbat bir ürün.", ProductId = 1 },
           new Comment() { CommentId = 3, Text = "Hızlı kargo, güvenilir satıcı.", ProductId = 1 }
        );
    }
}