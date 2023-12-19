using BaseMono.Contracts;
using BaseMono.Entities.Models;

namespace BaseMono.Repository.Implements;

public class TodoItemRepository : RepositoryBase<TodoItem>, ITodoItemRepository
{
    public TodoItemRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public IEnumerable<TodoItem> GetAllTodoItems(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Id)
            .ToList();
}