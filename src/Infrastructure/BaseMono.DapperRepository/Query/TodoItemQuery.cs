namespace BaseMono.DapperRepository.Query;

public static class TodoItemQuery
{
    public const string SelectTodoItemQuery = @"SELECT * FROM TodoItems ORDER BY ID";
}