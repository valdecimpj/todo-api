using Todo.Api.Application.Models;

namespace Todo.Api.Application.Models.Validators
{
    public interface ITodoItemModelValidator
    {
        void ValidateThrowingExceptions(NewTodoItemModel newTodoItemModel);
    }
}
