using System;
using System.Collections.Generic;
using System.Text;

namespace task_tracker_cli
{
    public class TaskTrackerApp
    {
        static void Main(string[] args)
        {
            TaskTracker taskTracker = new TaskTracker();
            //taskTracker.loadTasksFromFile("tasks.json");
            //Task task = new Task(1, "learn math", "todo", DateTime.Now, DateTime.Now);
            //taskTracker.addTask(task);
            //taskTracker.addTask(new Task(2,"learn c#", "in-progress", DateTime.Now, DateTime.Now));
            taskTracker.displayAllTasks();
            //taskTracker.saveTasksToFile("tasks.json");

        }
    }
}
