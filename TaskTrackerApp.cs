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
                //Console.WriteLine(taskTracker.taskList[0]);

                if (taskTracker.updateTaskDescription(1, "Become the most famous mathematician/physicist ever") &&
                     taskTracker.updateTaskStatus(1, "in-progress"))
                {
                    Console.WriteLine("Task updated");
                    //Console.WriteLine(taskTracker.taskList[0]);

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

            List<Task> todoTasks = taskTracker.getTasksByStatus("in-progress");

            Console.WriteLine("todo tasks:");
            for (int i =0; i < todoTasks.Count; i++)
            {
                Console.WriteLine(todoTasks[i]);
            }


            taskTracker.displayAllTasks();
            //taskTracker.deleteTask(1);
            taskTracker.displayAllTasks();
            //taskTracker.saveTasksToFile("tasks.json");
           
        }
    }
}
