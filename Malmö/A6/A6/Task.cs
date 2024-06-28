using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    /// <summary>
    /// Represents a task with a priority, date and time, and description.
    /// </summary>
    internal class Task
    {
        private PriorityType priority;
        private DateTime dateTime;
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="Task"/> class with the specified priority, date and time, and description.
        /// </summary>
        /// <param name="priority">The priority of the task.</param>
        /// <param name="date">The date and time of the task.</param>
        /// <param name="description">The description of the task.</param>
        public Task(PriorityType priority, DateTime date, string description)
        {
            this.priority = priority;
            this.dateTime = date;
            this.description = description;
        }

        /// <summary>
        /// Gets or sets the priority of the task.
        /// </summary>
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        /// <summary>
        /// Gets or sets the date and time of the task.
        /// </summary>
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Returns a string that represents the current task.
        /// </summary>
        /// <returns>A string that represents the current task.</returns>
        public override string ToString()
        {
            string date = this.dateTime.ToString("MM/dd/yyyy");
            string time = this.dateTime.ToString("hh:mm tt");
            return $"{date,-33} {time,-24} {priority,-31} {description,-52}";
        }
    }
}
