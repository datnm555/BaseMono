using BaseMono.Entities.Models;

namespace BaseMono.Repository.Abstraction;

public interface ITodoItemRepository
{
    Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync(bool trackChanges);
}