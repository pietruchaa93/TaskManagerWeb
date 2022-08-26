namespace TaskManager.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
