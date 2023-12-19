namespace BaseMono.Repository.Abstraction;

public interface IRepositoryManager
{
    ITodoItemRepository TodoItemRepository { get; }
    void Save();
}