using BaseMono.Repository.Abstraction;
using BaseMono.Service.Contracts.Manager;
using Microsoft.AspNetCore.Mvc;

namespace BaseMono.API.Controllers;

[ApiController]
[Route("api/[controller]")]
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
    public async Task<IActionResult> GetAllTodoItemsAsync()
    {
        var todoItems = await _serviceManager.TodoItemService.GetAllTodoItemsAsync(false);
        return Ok(todoItems);
    }
}