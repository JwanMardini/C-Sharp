using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    internal class Task
    {
        private PriorityType priority;
        private DateTime dateTime;
        private string description;

        public Task(PriorityType priority, DateTime date, string description)
        {
            this.priority = priority;
            this.dateTime = date;
            this.description = description;
        }

        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public override string ToString()
        {
            string date = this.dateTime.ToString("MM/dd/yyyy");
            string time = this.dateTime.ToString("hh:mm tt");
            return $"{date,-33} {time,-24} {priority,-31} {description,-52}";
        }
    }
}
