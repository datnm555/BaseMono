using BaseMono.DapperRepository.Abstraction;
using BaseMono.DapperRepository.Query;
using BaseMono.Shared.Dtos.TodoItem;
using Dapper;

namespace BaseMono.DapperRepository.Implements;

public class TodoItemRepository : ITodoItemRepository
{
    private readonly DapperDbContext _context;

    public TodoItemRepository(DapperDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TodoItemDto>> GetAllTodoItemsAsync(bool trackChanges)
    {
        const string query = TodoItemQuery.SelectTodoItemQuery;
        await using var connection = _context.CreateConnection();
        return await connection.QueryAsync<TodoItemDto>(query);
    }
}