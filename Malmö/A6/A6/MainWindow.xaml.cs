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
        public MainWindow()
        {
            InitializeComponent();
            InitializeCompBox();
            InitilizeApp();
            InitializeTimeLabel();
        }

        // Initializetions
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time every tick
            currentTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void InitilizeApp()
        {
            this.Title = "ToDo Reminder by Jwan";

            toDoTxt.Text = " ";
            toDoList.Items.Clear();
        }

        // Button handlers
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            CheckInputs();
        }

        private void CheckInputs()
        {
            // Check if the inputs are valid
            if (toDoTxt.Text == " ")
            {
                System.Windows.MessageBox.Show("Please enter a description");
                return;
            }
            if(priorityComboBox.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show("Please select a priority");
                return;
            }
            if(!dateTimePicker.Value.HasValue)
            {
                System.Windows.MessageBox.Show("Please select a date and time");
                return;

            }

            DateTime selectedDateTime = dateTimePicker.Value.Value;

            // Add the task to the list
            Task task = new Task((PriorityType)priorityComboBox.SelectedItem, selectedDateTime, toDoTxt.Text);
            toDoList.Items.Add(task.ToString());
            CLearInputs();
        }

        private void CLearInputs()
        {
            // Clear the inputs
            toDoTxt.Text = " ";
            priorityComboBox.SelectedIndex = 2;
            dateTimePicker.Value = null;
        }



        // Main Menu handlers
        private void New_Click(object sender, RoutedEventArgs e)
        {
            // Handle New click
            System.Windows.MessageBox.Show("New clicked");
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            // Handle Open click
            System.Windows.MessageBox.Show("Open clicked");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Handle Save click
            System.Windows.MessageBox.Show("Save clicked");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Handle Exit click
            this.Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            // Handle About click
            System.Windows.MessageBox.Show("ToDo Reminder by Jwan");
        }

    }
}