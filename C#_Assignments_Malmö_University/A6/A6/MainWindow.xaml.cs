using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Xceed.Wpf.Toolkit;

namespace A6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private FileManager fileManager;
        private TaskManager taskManager;
        private string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "tasks.txt");

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            taskManager = new TaskManager();
            fileManager = new FileManager(path);
            InitializeComponent();
            InitializeCompBox();
            InitilizeApp();
            InitializeTimeLabel();
        }

        // Initializations

        /// <summary>
        /// Initializes the ComboBox with priority items and sets default selection.
        /// </summary>
        private void InitializeCompBox()
        {
            // Add items to the ComboBox
            priorityComboBox.Items.Add(PriorityType.VeryImportant);
            priorityComboBox.Items.Add(PriorityType.Important);
            priorityComboBox.Items.Add(PriorityType.Normal);
            priorityComboBox.Items.Add(PriorityType.LessImportant);
            priorityComboBox.Items.Add(PriorityType.NotImportant);
            // Set the default selected item
            priorityComboBox.SelectedIndex = 2;
        }

        /// <summary>
        /// Initializes the current time label and starts the timer.
        /// </summary>
        private void InitializeTimeLabel()
        {
            // Set the initial time
            currentTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
            // Initialize the timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Event handler for timer tick, updates the current time label.
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time every tick
            currentTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Initializes the application title and clears input fields.
        /// </summary>
        private void InitilizeApp()
        {
            this.Title = "ToDo Reminder by Jwan";
            toDoTxt.Text = string.Empty;
            toDoList.Items.Clear();
        }

        // Button handlers

        /// <summary>
        /// Event handler for the Add button click, validates inputs and adds a task.
        /// </summary>
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            CheckInputs();
        }

        /// <summary>
        /// Validates user inputs and adds a task if inputs are valid.
        /// </summary>
        private void CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(toDoTxt.Text))
            {
                System.Windows.MessageBox.Show("Please enter a description");
                return;
            }

            if (priorityComboBox.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show("Please select a priority");
                return;
            }

            if (!dateTimePicker.Value.HasValue)
            {
                System.Windows.MessageBox.Show("Please select a date and time");
                return;
            }

            DateTime selectedDateTime = dateTimePicker.Value.Value;
            taskManager.AddTask((PriorityType)priorityComboBox.SelectedItem, selectedDateTime, toDoTxt.Text);
            ShowTasks();
            ClearInputs();
        }

        /// <summary>
        /// Clears the input fields after adding a task.
        /// </summary>
        private void ClearInputs()
        {
            toDoTxt.Text = string.Empty;
            priorityComboBox.SelectedIndex = 2;
            dateTimePicker.Value = null;
        }

        /// <summary>
        /// Displays the list of tasks in the to-do list.
        /// </summary>
        private void ShowTasks()
        {
            toDoList.Items.Clear();
            List<Task> tasks = taskManager.GetTasks();
            foreach (Task task in tasks)
            {
                toDoList.Items.Add(task);
            }
        }

        // Main Menu handlers

        /// <summary>
        /// Event handler for the New menu item click, resets the application state.
        /// </summary>
        private void New_Click(object sender, RoutedEventArgs e)
        {
            InitilizeApp();
            taskManager.ClearTasks();
        }

        /// <summary>
        /// Event handler for the Open menu item click, loads tasks from file and displays them.
        /// </summary>
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            List<Task> tasks = fileManager.LoadTasks();
            taskManager.SetTasks(tasks);
            ShowTasks();
        }

        /// <summary>
        /// Event handler for the Save menu item click, saves tasks to file.
        /// </summary>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            fileManager.SaveTasks(taskManager.GetTasks());
        }

        /// <summary>
        /// Event handler for the Exit menu item click, prompts user to confirm program exit.
        /// </summary>
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for the About menu item click, displays information about the application.
        /// </summary>
        private void About_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("ToDo Reminder by Jwan");
        }

        /// <summary>
        /// Event handler for the window closing event, prompts user to confirm program exit.
        /// </summary>
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            MessageBoxResult result =  System.Windows.MessageBox.Show("Are you sure you want to exit the program?", "Think Twice", MessageBoxButton.OKCancel);
            if (result != MessageBoxResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
