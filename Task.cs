
namespace TaskTracker
{
  class Task
  {
    public int id;
    public string description;
    public string status;
    public DateTime createdAt;
    public DateTime updatedAt;

    Task(int id, string description, string status, DateTime createdAt, DateTime updatedAt)
    {
      this.id = id;
      this.description = description;
      this.status = status;
      this.createdAt = createdAt;
      this.updatedAt = updatedAt;
    }
  }
}