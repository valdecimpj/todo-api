using Todo.Api.Adapters.Repositories;
using Todo.Api.Application.Ports.In.DependencyInjectionModule;
using Todo.Api.Application.Ports.Out.DependencyInjector;
using Todo.Api.Application.Ports.Out.Repositories;

namespace Todo.Api.DependencyInjectionModule
{
    public class TodoApiDependencyInjectionModule
    {
        public void RegisterAllModules(IDependencyInjector dependencyInjector)
        {
            new TodoApiApplicationDependencyInjectionModule().RegisterModule(dependencyInjector);
            dependencyInjector.RegisterClassAsInterface<TodoItemsMockRepository, ITodoItemsRepository>();
        }
    }
}
