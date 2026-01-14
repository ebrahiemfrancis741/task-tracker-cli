using System;
using System.Collections.Generic;
using System.Text;

namespace task_tracker_cli
{
    public class TaskTrackerApp
    {
        static TaskTracker taskTracker;
        static void Main(string[] args)
        {
            taskTracker = new TaskTracker();

            if (args.Length <= 0)
            {
                Console.WriteLine("Use arguments to run the app");
                return;
            }

            switch (args[0])
            {
                case "add":
                    cliAddTask(args);
                    break;
                default:
                    Console.WriteLine("undefined operation specified");
                    break;
            }
            taskTracker.saveTasksToFile("tasks.json");
        }

        static void cliAddTask(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Correct usage: add 'id' 'description'");
                return;
            }
            Task task = new Task(Convert.ToInt32(args[1]), args[2], "todo", DateTime.Now, DateTime.Now);
            if (taskTracker.addTask(task))
            {
                Console.WriteLine("Task added successfully (ID: {0})", args[1]);
            }
            else
            {
                Console.WriteLine("Failed to add task");
            }
        }
    }
}
