using Microsoft.EntityFrameworkCore;
using Todo.Api.Application.Models;

namespace Todo.Api.Adapters.Repositories
{
    public class TodoItemsDbContext : DbContext
    {
        public DbSet<TodoItemModel> TodoItemModels { get; set; }

        public TodoItemsDbContext(DbContextOptions<TodoItemsDbContext> dbContextOptions) : base(dbContextOptions) => 
            Database.EnsureCreated();
    }
}
