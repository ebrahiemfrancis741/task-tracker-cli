using System;
using System.Collections.Generic;
using System.Text;

namespace task_tracker_cli
{
    public class TaskTracker
    {
        public List<Task> taskList { get; set; }
        public TaskTracker()
        {
            taskList = new List<Task>();
        }

        // adds a Task object to the tasklist if it is not already in there
        public bool addTask(Task task)
        {
            if (getTask(task.id) == null)
            {
                taskList.Add(task);
                return true;
            }
            return false;
        }

        public bool updateTaskDescription(int id, string description)
        {
            Task updatedTask = null;
            updatedTask = getTask(id);
            if (updatedTask != null)
            {
                updatedTask.description = description;
                updatedTask.updatedAt = DateTime.Now;
                return true;
            }
            return false;
        }

        public bool deleteTask(int id)
        {
            int taskIndex = getTaskIndex(id);
            if (taskIndex >= 0)
            {
                taskList.RemoveAt(taskIndex);
                return true;
            }
            return false;
        }

        public bool updateTaskStatus(int id, string status)
        {
            Task updatedTask = null;
            updatedTask = getTask(id);
            if (updatedTask != null)
            {
                updatedTask.status = status;
                updatedTask.updatedAt = DateTime.Now;
                return true;
            }
            return false;
        }

        public List<Task> getCompletedTasks() { return null; }

        public List<Task> getIncompleteTasks() { return null; }

        public List<Task> getInProgressTasks() { return null; }

        public bool loadTasksFromSource() { return false; }

        // gets the Task object with specified id from the task list if it exists
        public Task getTask(int id)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].id == id)
                {
                    return taskList[i];
                }
            }
            return null;
        }

        public int getTaskIndex(int id)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void displayAllTasks()
        {
            Console.WriteLine("Tasks: {0} task(s)", taskList.Count);
            Console.WriteLine("------------------\n");

            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks available");
            }

            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine(taskList[i]);
            }
        }

    }
}
