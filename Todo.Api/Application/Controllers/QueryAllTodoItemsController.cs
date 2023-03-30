using Todo.Api.Application.Controllers.Requests;
using Todo.Api.Application.Controllers.Requests.Validators;
using Todo.Api.Application.Models;
using Todo.Api.Application.Ports.In.Controllers;
using Todo.Api.Application.Ports.Out.Repositories;

namespace Todo.Api.Application.Controllers
{
    public class QueryAllTodoItemsController : IQueryAllTodoItemsController
    {
        private readonly IQueryAllTodoitemsByPageRequestValidator queryAllTodoitemsByPageRequestValidator;
        private readonly ITodoItemsRepository todoItemsRepository;

        public QueryAllTodoItemsController(
            IQueryAllTodoitemsByPageRequestValidator queryAllTodoitemsByPageRequestValidator,
            ITodoItemsRepository todoItemsRepository)
        {
            this.queryAllTodoitemsByPageRequestValidator = queryAllTodoitemsByPageRequestValidator;
            this.todoItemsRepository = todoItemsRepository;
        }

        public List<TodoItemModel> QueryAllTodoItemsByPage(
            QueryAllTodoitemsByPageRequest queryAllTodoitemsByPageRequest)
        {
            queryAllTodoitemsByPageRequestValidator.ValidateThrowingExceptions(
                queryAllTodoitemsByPageRequest);
            return todoItemsRepository.QueryAllTodoItemsByPage(queryAllTodoitemsByPageRequest.page,
                queryAllTodoitemsByPageRequest.pageSize);
        }
    }
}
