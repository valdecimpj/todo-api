using Todo.Api.Application.Exceptions;

namespace Todo.Api.Application.Controllers.Requests.Validators
{
    public class QueryAllTodoitemsByPageRequestValidator : IQueryAllTodoitemsByPageRequestValidator
    {
        public void ValidateThrowingExceptions(QueryAllTodoitemsByPageRequest queryAllTodoitemsByPageRequest)
        {
            if (queryAllTodoitemsByPageRequest.page <= 0)
                throw new QueryAllTodoitemsByPageRequestException(
                    "The page must be between 1 and the maximum amount.");

            if (queryAllTodoitemsByPageRequest.pageSize >= 100 ||
                queryAllTodoitemsByPageRequest.pageSize <= 0)
                throw new QueryAllTodoitemsByPageRequestException(
                    "The page size must be between 1 and 100.");
        }
    }
}
