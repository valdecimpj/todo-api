using Todo.Api.Application.Models;
using Todo.Api.Application.Ports.Out.Repositories;

namespace Todo.Api.Adapters.Repositories
{
    public class TodoItemsMockRepository : ITodoItemsRepository
    {
        public List<TodoItemModel> QueryAllTodoItemsByPage(int page, int pageSize) => new List<TodoItemModel>
        {
            new TodoItemModel(1, "test", false),
            new TodoItemModel(2, "test2", false),
            new TodoItemModel(3, "test3", false),
        };

        public void SaveNewTodoItem(NewTodoItemModel newTodoItemModel)
        {
            
        }
    }
}
