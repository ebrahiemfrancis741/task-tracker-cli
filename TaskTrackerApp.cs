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
                case "update-description":
                    cliUpdateTaskDescription(args);
                    break;
                case "delete":
                    cliDeleteTask(args);
                    break;
                case "update-status":
                    cliUpdateTaskStatus(args);
                    break;
                case "list":
                    list(args);
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

        static void cliUpdateTaskDescription(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Correct usage: update-description 'id' 'description'");
                return;
            }
            if (taskTracker.updateTaskDescription(Convert.ToInt32(args[1]), args[2]))
            {
                Console.WriteLine("Task updated (ID: {0})", args[1]);
            }
            else
            {
                Console.WriteLine("Failed to update Task, id not valid or does not exist");
            }

        }

        static void cliDeleteTask(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Correct usage: delete 'id'");
                return;
            }
            if (taskTracker.deleteTask(Convert.ToInt32(args[1])))
            {
                Console.WriteLine("Successfully removed task (ID: {0})", args[1]);
            }
            else
            {
                Console.WriteLine("Failed to remove task, id does not exist");
            }
        }

        static void cliUpdateTaskStatus(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Correct usage: update-status 'id' 'description'");
            }
            if (taskTracker.updateTaskStatus(Convert.ToInt32(args[1]), args[2]))
            {
                Console.WriteLine("Successfully updated task status (ID: {0})", args[1]);
            }
            else
            {
                Console.WriteLine("Failed to update task status, id does not exist");
            }
        }

        static void list(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Correct usage: list all/todo/in-progress/done");
                return;
            }
            if (args[1].Equals("all"))
            {
                taskTracker.displayAllTasks();
            }
            else
            {
                // display specific status
                List<Task> tasks = taskTracker.getTasksByStatus(args[1]);
                foreach (Task task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
