using Todo.Api.Application.Models;

namespace Todo.Api.Application.Ports.Out.Repositories
{
    public interface ITodoItemsRepository
    {
        public void SaveNewTodoItem(NewTodoItemModel newTodoItemModel);
        public List<TodoItemModel> QueryAllTodoItemsByPage(int page, int pageSize);
    }
}
