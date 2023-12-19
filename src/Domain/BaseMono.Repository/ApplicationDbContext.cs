using BaseMono.Entities.Models;
using BaseMono.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BaseMono.Repository;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TodoItem>? TodoItem { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoItemConfiguration());

        base.OnModelCreating(builder);
    }
}