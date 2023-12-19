﻿using BaseMono.Contracts;
using BaseMono.Repository.Implements;

namespace BaseMono.Repository.Manager
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private readonly Lazy<ITodoItemRepository> _todoItemRepo;

        public RepositoryManager(ApplicationDbContext context)
        {
            _context = context;
            _todoItemRepo = new(() => new TodoItemRepository(_context));
        }

        public ITodoItemRepository TodoItemRepository => _todoItemRepo.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}