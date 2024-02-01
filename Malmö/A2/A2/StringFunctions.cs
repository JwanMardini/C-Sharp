using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    internal class StringFunctions
    {
        private static bool keepGoing = true; // Used to control the while loop in Start()
        private static void StringLength()
        {
            Console.WriteLine();
            string input = Console.ReadLine();
            int length = input.Length;

            Console.WriteLine();
            Console.WriteLine("---- STRENGTH LENGTH ----");
            Console.WriteLine();
            Console.WriteLine(input.ToUpper());
            Console.WriteLine($"Number of chars = {length}");
            Console.WriteLine();

        }

        private static void PredictMyDay()
        {
            string input = Console.ReadLine();
            Console.WriteLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;
                case "2":
                    Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                    break;
                case "3":
                    Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                    break
                        ;
                case "4":
                    Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                    break;
                case "5":
                    Console.WriteLine("Friday, you are in love!");
                    break;
                case "6":
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case "7":
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default:
                    Console.WriteLine("No day? A good day but it doesn't exist!");
                    break;
            }

        }

        private static void RunAgain()
        {
            Console.WriteLine();
            Console.Write("Continue with anoother round? (y/n): ");
            string input = Console.ReadLine();
            Console.WriteLine();
            
            // Check if the user wants to continue
            if (input == "y") {
                keepGoing = true;
            } else if (input == "n")
            {
                keepGoing = false;
            } else
            {
                Console.WriteLine("Invalid input!");
                RunAgain();
            }
        }
        

        public void Start()
        {
            while (keepGoing)
            {
                Console.WriteLine("Write a text with any number of characters and press Enter.");
                Console.WriteLine("You can even copy text from a file and paste it here!");
                StringLength();

                Console.WriteLine("+++++++++ The Fortune Teller +++++++++");
                Console.WriteLine("Let me predict your day! Select a number between 1 and 7:");
                PredictMyDay();
                Console.WriteLine();
                RunAgain();
            }

        }
    }
}
