using BaseMono.Contracts;
using BaseMono.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseMono.Repository.Implements;

public class TodoItemRepository : RepositoryBase<TodoItem>, ITodoItemRepository
{
    public TodoItemRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public async Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync(bool trackChanges) =>
        await FindAll(trackChanges).OrderBy(c => c.Id).ToListAsync();
}