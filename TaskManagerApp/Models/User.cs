namespace TaskManagerApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public List<TaskItem> Tasks { get; set; } = new();
    }
}
