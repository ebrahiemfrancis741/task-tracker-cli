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

        public bool addTask() { return false; }

        public bool updateTask() { return false; }

        public bool deleteTask() { return false; }

        public bool changeTaskStatus() { return false; }

        public List<Task> getCompletedTasks() { return null; }

        public List<Task> getIncompleteTasks() { return null; }

        public List<Task> getInProgressTasks() { return null; }

        public bool loadTasksFromSource() { return false; }

        public bool idExists(int id)
        {
            for (int i = 0; i < taskList.Count; i++) {
                if (taskList[i].id == id) {
                    return true;
                }
            }
            return false;
        }

    }
}
