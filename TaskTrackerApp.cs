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
            Task task = new Task(1, "learn math", "todo", DateTime.Now, DateTime.Now);
            if (taskTracker.addTask(task))
            {
                Console.WriteLine("Task added");
                Console.WriteLine("task id: {0}", taskTracker.getTask(1).id);
                Console.WriteLine("task id: {0}", taskTracker.getTask(1).description);
                Console.WriteLine("task id: {0}", taskTracker.getTask(1).status);
                Console.WriteLine("task id: {0}", taskTracker.getTask(1).createdAt);
                Console.WriteLine("task id: {0}", taskTracker.getTask(1).updatedAt);

                if (taskTracker.updateTaskDescription(1, "Become the most famous mathematician/physicist ever"))
                {
                    Console.WriteLine("Task updated");
                    Console.WriteLine("task id: {0}", taskTracker.getTask(1).id);
                    Console.WriteLine("task id: {0}", taskTracker.getTask(1).description);
                    Console.WriteLine("task id: {0}", taskTracker.getTask(1).status);
                    Console.WriteLine("task id: {0}", taskTracker.getTask(1).createdAt);
                    Console.WriteLine("task id: {0}", taskTracker.getTask(1).updatedAt);
                }
                else
                {
                    Console.WriteLine("Failed to update Task");
                }
            }
            else
            {
                Console.WriteLine("task Id already exists, please choose a different one");
            }
        }
    }
}
