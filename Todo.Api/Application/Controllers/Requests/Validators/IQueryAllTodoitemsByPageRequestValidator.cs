namespace Todo.Api.Application.Controllers.Requests.Validators
{
    public interface IQueryAllTodoitemsByPageRequestValidator
    {
        void ValidateThrowingExceptions(
            QueryAllTodoitemsByPageRequest queryAllTodoitemsByPageRequest);
    }
}
