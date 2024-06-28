using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    /// <summary>
    /// Manages a collection of tasks, providing methods to add, retrieve, set, and clear tasks.
    /// </summary>
    internal class TaskManager
    {
        private List<Task> tasks;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManager"/> class.
        /// </summary>
        public TaskManager()
        {
            tasks = new List<Task>();
        }

        /// <summary>
        /// Adds a new task to the task list.
        /// </summary>
        /// <param name="priority">The priority of the task.</param>
        /// <param name="date">The date and time of the task.</param>
        /// <param name="description">The description of the task.</param>
        public void AddTask(PriorityType priority, DateTime date, string description)
        {
            tasks.Add(new Task(priority, date, description));
        }

        /// <summary>
        /// Gets the list of tasks.
        /// </summary>
        /// <returns>A list of tasks.</returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary>
        /// Sets the task list to the specified list of tasks.
        /// </summary>
        /// <param name="tasks">The list of tasks to set.</param>
        public void SetTasks(List<Task> tasks)
        {
            this.tasks = tasks;
        }

        /// <summary>
        /// Clears all tasks from the task list.
        /// </summary>
        public void ClearTasks()
        {
            tasks.Clear();
        }
    }
}
