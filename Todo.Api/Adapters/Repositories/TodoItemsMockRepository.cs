using Todo.Api.Application.Models;
using Todo.Api.Application.Ports.Out.Repositories;

namespace Todo.Api.Adapters.Repositories
{
    public class TodoItemsMockRepository : ITodoItemsRepository
    {
        private readonly TodoItemsDbContext todoItemsDbContext;

        public TodoItemsMockRepository(TodoItemsDbContext todoItemsDbContext)
        {
            this.todoItemsDbContext = todoItemsDbContext;
        }

        public List<TodoItemModel> QueryAllTodoItemsByPage(int page, int pageSize) => 
            todoItemsDbContext.TodoItemModels.Skip((page-1) * pageSize).Take(pageSize).ToList();

        public void SaveNewTodoItem(NewTodoItemModel newTodoItemModel)
        {
            todoItemsDbContext.Add(new TodoItemModel(0, newTodoItemModel.Description, false));
            todoItemsDbContext.SaveChanges();
        }
    }
}
