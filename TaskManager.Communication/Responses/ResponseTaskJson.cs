using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses
{
    public class ResponseTaskJson
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public TaskPriority Priority { get; set; }
        public Enums.TaskStatus Status { get; set; }
    }
}
