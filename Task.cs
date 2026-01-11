
namespace task_tracker_cli
{
    public class Task
    {
        public int id { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public Task(int id, string description, string status, DateTime createdAt, DateTime updatedAt)
        {
            this.id = id;
            this.description = description;
            this.status = status;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }

        public override string ToString()
        {
            return $"id: {id}\ndescription: {description}\nstatus: {status}\ndate created: {createdAt}\ndate updated: {updatedAt}\n\n";
        }
    }
}