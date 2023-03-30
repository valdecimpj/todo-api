using Todo.Api.Application.Controllers.Requests;
using Todo.Api.Application.Models;

namespace Todo.Api.Application.Ports.In.Controllers
{
    public interface IQueryAllTodoItemsController
    {
        List<TodoItemModel> QueryAllTodoItemsByPage(
            QueryAllTodoitemsByPageRequest queryAllTodoitemsByPageRequest);
    }
}
