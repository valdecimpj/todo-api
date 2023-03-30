namespace Todo.Api.Application.Models
{
    public class TodoItemModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItemModel(int id, string description, bool isCompleted)
        {
            Id = id;
            Description = description;
            IsCompleted = isCompleted;
        }
    }
}
