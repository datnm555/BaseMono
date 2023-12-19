using BaseMono.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseMono.Repository.Configuration;

public class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
{
    public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        builder.HasData(
            new TodoItem
            {
                Id = Guid.NewGuid(),
                Name = "Sample"
            }
        );
    }
}