using BaseMono.Contracts;
using BaseMono.Service.Contracts.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BaseMono.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoItemsController : ControllerBase
{
    private readonly ILoggerManager _logger;
    private readonly IServiceManager _serviceManager;

    public TodoItemsController(ILoggerManager logger, IServiceManager serviceManager)
    {
        _logger = logger;
        _serviceManager = serviceManager;
    }

    [HttpGet]
    public IActionResult GetTodoItems()
    {
        var todoItems = _serviceManager.TodoItemService.GetAllTodoItems(false);
        return Ok(todoItems);
    }
}