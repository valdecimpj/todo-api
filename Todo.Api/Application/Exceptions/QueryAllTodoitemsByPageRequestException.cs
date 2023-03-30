namespace Todo.Api.Application.Exceptions
{
    public class QueryAllTodoitemsByPageRequestException : Exception
    {
        public QueryAllTodoitemsByPageRequestException(string message) : base(message) { }
    }
}
