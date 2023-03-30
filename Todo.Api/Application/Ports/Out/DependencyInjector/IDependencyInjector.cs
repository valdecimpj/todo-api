namespace Todo.Api.Application.Ports.Out.DependencyInjector
{
    public interface IDependencyInjector
    {
        void RegisterClassAsInterface<TClass, TInterface>() where TInterface : class
            where TClass : class, TInterface;
    }
}
