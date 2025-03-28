using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace A6
{
    /// <summary>
    /// Manages the loading and saving of tasks to and from a file.
    /// </summary>
    internal class FileManager
    {
        private readonly string path;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileManager"/> class with the specified file path.
        /// If the file does not exist, it will be created.
        /// </summary>
        /// <param name="path">The path to the file where tasks will be saved and loaded from.</param>
        public FileManager(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                try
                {
                    File.Create(path).Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating file: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Saves the list of tasks to the file.
        /// </summary>
        /// <param name="tasks">The list of tasks to save.</param>
        public void SaveTasks(List<Task> tasks)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(this.path))
                {
                    foreach (Task task in tasks)
                    {
                        file.WriteLine($"{task.Priority},{task.DateTime},{task.Description}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving tasks: {ex.Message}");
            }
        }

        /// <summary>
        /// Loads the list of tasks from the file.
        /// </summary>
        /// <returns>A list of tasks loaded from the file.</returns>
        public List<Task> LoadTasks()
        {
            List<Task> tasks = new List<Task>();

            try
            {
                if (!File.Exists(this.path))
                {
                    MessageBox.Show("File does not exist.");
                    return tasks;
                }

                FileStream fileStream = new FileStream(this.path, FileMode.Open, FileAccess.Read);
                {
                    if (fileStream.Length == 0)
                    {
                        MessageBox.Show("File is empty.");
                        return tasks;
                    }

                    StreamReader file = new StreamReader(fileStream);
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            try
                            {
                                string[] parts = line.Split(',');
                                PriorityType priority = (PriorityType)Enum.Parse(typeof(PriorityType), parts[0]);
                                DateTime date = DateTime.Parse(parts[1]);
                                string description = parts[2];
                                tasks.Add(new Task(priority, date, description));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error parsing task: {ex.Message}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}");
            }

            return tasks;
        }
    }
}
