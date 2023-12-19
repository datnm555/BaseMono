using BaseMono.Entities.Models;

namespace BaseMono.Contracts;

public interface ITodoItemRepository
{
    Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync(bool trackChanges);
}