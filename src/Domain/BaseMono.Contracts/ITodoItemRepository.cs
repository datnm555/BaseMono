using BaseMono.Entities.Models;

namespace BaseMono.Contracts;

public interface ITodoItemRepository
{
    IEnumerable<TodoItem> GetAllTodoItems(bool trackChanges);
}