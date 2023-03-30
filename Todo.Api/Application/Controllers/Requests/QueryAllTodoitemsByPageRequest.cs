namespace Todo.Api.Application.Controllers.Requests
{
    public class QueryAllTodoitemsByPageRequest
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public QueryAllTodoitemsByPageRequest(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
