using Todo.Api.Application.Models;
using Todo.Api.Application.Models.Validators;
using Todo.Api.Application.Ports.In.Controllers;
using Todo.Api.Application.Ports.Out.Repositories;

namespace Todo.Api.Application.Controllers
{
    public class NewTodoItemController : INewTodoItemController
    {
        private readonly ITodoItemModelValidator todoModelValidator;
        private readonly ITodoItemsRepository todoItemsRepository;

        public NewTodoItemController(ITodoItemModelValidator todoModelValidator,
            ITodoItemsRepository todoItemsRepository) 
        {
            this.todoModelValidator = todoModelValidator;
            this.todoItemsRepository = todoItemsRepository;
        }

        public void SaveNewTodoItem(NewTodoItemModel newTodoItemModel)
        {
            todoModelValidator.ValidateThrowingExceptions(newTodoItemModel);
            todoItemsRepository.SaveNewTodoItem(newTodoItemModel);
        }
    }
}
