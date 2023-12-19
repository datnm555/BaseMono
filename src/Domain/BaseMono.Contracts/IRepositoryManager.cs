namespace BaseMono.Contracts;

public interface IRepositoryManager
{
    ITodoItemRepository TodoItemRepository { get; }
    void Save();
}