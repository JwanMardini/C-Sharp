using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    internal class Scheduler
    {
        /// <summary>
        /// will show the menu and start the scheduler
        /// </summary>
        public void Start()
        {
            ShowHeader();
            ShowMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            while (choice != "0")
            {
                switch (choice)
                {
                    case "1":
                        ShowWeekends();
                        break;
                    case "2":
                        ShowNights();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                ShowMenu();
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();
            }
            
        }

        /// <summary>
        /// it will show the weekends to work
        /// </summary>
        private static void ShowWeekends()
        {
            int counter = 0;
            for (int i = 2; i <= 52; i+=2)
            {
                Console.Write($" Week {i, 2} ");
                counter++;
                if (counter % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n----------------------------------------------------");

        }


        /// <summary>
        /// it will show the nights to work
        /// </summary>
        private static void ShowNights()
        {
            int counter = 0;
            for (int i = 1; i <= 52; i+=4)
            {
                Console.Write($" Week {i, 2} ");
                counter++;
                if (counter % 4 == 0)
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine("\n----------------------------------------------------");
        }


        /// <summary>
        /// it will show the header
        /// </summary>
        private static void ShowHeader()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("               YOUR WORK SCHEDULE                   ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// it will show the menu
        /// </summary>
        private static void ShowMenu()
        {
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit");
            Console.WriteLine();
        }
    }
}
