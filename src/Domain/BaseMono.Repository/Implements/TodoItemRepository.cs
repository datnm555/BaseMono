using BaseMono.Entities.Models;
using BaseMono.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace BaseMono.Repository.Implements;

public class TodoItemRepository : RepositoryBase<TodoItem>, ITodoItemRepository
{
    public TodoItemRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public async Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync(bool trackChanges)
    {
        return await FindAll(trackChanges).OrderBy(c => c.Id).ToListAsync();
    }
}