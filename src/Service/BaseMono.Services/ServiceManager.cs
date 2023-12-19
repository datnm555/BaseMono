using AutoMapper;
using BaseMono.Repository.Abstraction;
using BaseMono.Service.Contracts;
using BaseMono.Services.Implements;

namespace BaseMono.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<ITodoItemService> _todoItemService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
    {
        _todoItemService =
            new Lazy<ITodoItemService>(() => new TodoItemService(repositoryManager, loggerManager, mapper));
    }

    public ITodoItemService TodoItemService => _todoItemService.Value;
}