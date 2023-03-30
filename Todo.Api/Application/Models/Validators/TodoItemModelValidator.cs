using Todo.Api.Application.Exceptions;
using Todo.Api.Application.Models;

namespace Todo.Api.Application.Models.Validators
{
    public class TodoItemModelValidator : ITodoItemModelValidator
    {
        public void ValidateThrowingExceptions(NewTodoItemModel newTodoItemModel)
        {
            if (string.IsNullOrWhiteSpace(newTodoItemModel.Description))
                throw new InvalidNewTodoItemException("The todo item's description must not be empty.");
        }
    }
}
