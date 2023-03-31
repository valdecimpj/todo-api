using Microsoft.EntityFrameworkCore;
using Todo.Api.Adapters.DependencyInjector;
using Todo.Api.Adapters.Repositories;
using Todo.Api.Application.Ports.In.DependencyInjectionModule;
using Todo.Api.Application.Ports.Out.Repositories;

namespace Todo.Api.DependencyInjectionModule
{
    public class TodoApiDependencyInjectionModule
    {
        public void RegisterAllModules(WebApplicationBuilder webApplicationBuilder)
        {
            webApplicationBuilder.Services.AddDbContext<TodoItemsDbContext>(options => options
                .UseNpgsql(webApplicationBuilder.Configuration.GetConnectionString("PostgreSQL")));
            var dependencyInjector = new WebApplicationDependencyInjector(webApplicationBuilder);
            new TodoApiApplicationDependencyInjectionModule().RegisterModule(dependencyInjector);
            dependencyInjector.RegisterClassAsInterface<TodoItemsMockRepository, ITodoItemsRepository>();
        }
    }
}
