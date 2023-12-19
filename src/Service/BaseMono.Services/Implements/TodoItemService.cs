using BaseMono.Contracts;
using BaseMono.Entities.Models;
using BaseMono.Service.Contracts;

namespace BaseMono.Services.Implements;

public class TodoItemService : ITodoItemService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly ILoggerManager _loggerManager;

    public TodoItemService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
    {
        _repositoryManager = repositoryManager;
        _loggerManager = loggerManager;
    }

    public IEnumerable<TodoItem> GetAllTodoItems(bool trackChanges)
    {
        _loggerManager.LogInfo("Test");
        return _repositoryManager.TodoItemRepository.GetAllTodoItems(trackChanges);
    }
}