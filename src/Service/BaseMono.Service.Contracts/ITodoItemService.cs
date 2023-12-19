using BaseMono.Entities.Models;

namespace BaseMono.Service.Contracts;

public interface ITodoItemService
{
    IEnumerable<TodoItem> GetAllTodoItems(bool trackChanges);
}