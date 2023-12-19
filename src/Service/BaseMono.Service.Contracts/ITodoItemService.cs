using BaseMono.Shared.Dtos.TodoItem;

namespace BaseMono.Service.Contracts;

public interface ITodoItemService
{
    Task<IEnumerable<TodoItemDto>> GetAllTodoItemsAsync(bool trackChanges);
}