using Todo.Api.Application.Models;

namespace Todo.Api.Application.Ports.In.Controllers
{
    public interface INewTodoItemController
    {
        void SaveNewTodoItem(NewTodoItemModel newTodoItemModel);
    }
}
