using Todo.Api.Application.Controllers;
using Todo.Api.Application.Controllers.Requests.Validators;
using Todo.Api.Application.Models.Validators;
using Todo.Api.Application.Ports.In.Controllers;
using Todo.Api.Application.Ports.Out.DependencyInjector;

namespace Todo.Api.Application.Ports.In.DependencyInjectionModule
{
    public class TodoApiApplicationDependencyInjectionModule
    {
        public void RegisterModule(IDependencyInjector dependencyInjector)
        {
            dependencyInjector.RegisterClassAsInterface<NewTodoItemController, INewTodoItemController>();
            dependencyInjector.RegisterClassAsInterface<QueryAllTodoItemsController, IQueryAllTodoItemsController>();
            dependencyInjector.RegisterClassAsInterface<QueryAllTodoitemsByPageRequestValidator, IQueryAllTodoitemsByPageRequestValidator>();
            dependencyInjector.RegisterClassAsInterface<TodoItemModelValidator, ITodoItemModelValidator>();
        }
    }
}
