namespace TaskManagerApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Priority PriorityLevel { get; set; }

        public int? CategoryId { get; set; } //for testing of CreateTask function, after that remove "?"
        public Category? Category { get; set; }


        public int? UserId { get; set; } //for testing of CreateTask function, after that remove "?"
        public User? User { get; set; }


    }
}
