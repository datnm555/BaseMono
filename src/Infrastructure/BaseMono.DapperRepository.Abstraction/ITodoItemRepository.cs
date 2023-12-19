using BaseMono.Shared.Dtos.TodoItem;

namespace BaseMono.DapperRepository.Abstraction;

public interface ITodoItemRepository
{
   Task<IEnumerable<TodoItemDto>> GetAllTodoItemsAsync(bool trackChanges);
}