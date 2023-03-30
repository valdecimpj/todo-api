namespace Todo.Api.Application.Models
{
    public class NewTodoItemModel
    {
        public string Description { get; set; }

        public NewTodoItemModel(string description) => 
            Description = description;
    }
}
