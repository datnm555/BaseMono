using AutoMapper;
using BaseMono.Entities.Exceptions;
using BaseMono.Repository.Abstraction;
using BaseMono.Service.Contracts;
using BaseMono.Shared.Dtos.TodoItem;

namespace BaseMono.Services.Implements;

public class TodoItemService : ITodoItemService
{
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly IRepositoryManager _repositoryManager;

    public TodoItemService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TodoItemDto>> GetAllTodoItemsAsync(bool trackChanges)
    {
        try
        {
            throw new NotFoundException("Test");
            var todoItems = await _repositoryManager.TodoItemRepository.GetAllTodoItemsAsync(trackChanges);
            return _mapper.Map<IEnumerable<TodoItemDto>>(todoItems);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}