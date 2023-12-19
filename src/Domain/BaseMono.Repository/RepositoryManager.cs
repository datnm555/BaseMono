using BaseMono.Repository.Abstraction;
using BaseMono.Repository.Implements;

namespace BaseMono.Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly ApplicationDbContext _context;
    private readonly Lazy<ITodoItemRepository> _todoItemRepo;

    public RepositoryManager(ApplicationDbContext context)
    {
        _context = context;
        _todoItemRepo = new Lazy<ITodoItemRepository>(() => new TodoItemRepository(_context));
    }

    public ITodoItemRepository TodoItemRepository => _todoItemRepo.Value;

    public void Save()
    {
        _context.SaveChanges();
    }
}