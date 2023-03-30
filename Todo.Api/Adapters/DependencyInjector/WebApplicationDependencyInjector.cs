using Todo.Api.Application.Ports.Out.DependencyInjector;

namespace Todo.Api.Adapters.DependencyInjector
{
    public class WebApplicationDependencyInjector : IDependencyInjector
    {
        private readonly WebApplicationBuilder webApplicationBuilder;

        public WebApplicationDependencyInjector(WebApplicationBuilder webApplicationBuilder) 
            => this.webApplicationBuilder = webApplicationBuilder;

        public void RegisterClassAsInterface<TClass, TInterface>() where TInterface : class
            where TClass : class, TInterface =>
            webApplicationBuilder.Services.AddScoped<TInterface, TClass>();
    }
}
