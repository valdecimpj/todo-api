namespace Todo.Api.Application.Exceptions
{
    public class InvalidNewTodoItemException : Exception
    {
        public InvalidNewTodoItemException(string message) : base(message)
        {
        }
    }
}
