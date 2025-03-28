using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    internal class TemperatureConverter
    {
        private static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double celsius = Double.Parse(temperatureCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        private static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double fahrenheit = Double.Parse(temperatureFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        public void Start()
        {
            while (true)
            {
                ShowMenu();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "0")
                {
                    break;
                }
                switch (choice)
                {
                    case "1":
                        for (int i = 0; i <= 212; i += 10)
                        {
                            string input = $"{i}";
                            Console.WriteLine($"{i.ToString("F2"), 6} F = {FahrenheitToCelsius(input).ToString("F2"), 6} C");
                            
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        for (int i = 0; i <= 100; i += 5)
                        {
                            string input = $"{i}";
                            Console.WriteLine($"{i.ToString("F2"), 6} C = {CelsiusToFahrenheit(input).ToString("F2"), 6} F");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("************************");
            Console.WriteLine("       Main Menu        ");
            Console.WriteLine("************************");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.WriteLine("************************");
            Console.WriteLine();
        }
    }
}
