﻿namespace A2
{
    internal class Program
    {
        /// <summary>
        /// it will start the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Temperature Converter";
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            temperatureConverter.Start();

            ContinueToNextPart("String Functions");
            StringFunctions stringFunctions = new StringFunctions();
            stringFunctions.Start();

            ContinueToNextPart("Math Work");
            MathWork mathWork = new MathWork();
            mathWork.Calculate();

            ContinueToNextPart("Scheduler");
            Scheduler scheduler = new Scheduler();
            scheduler.Start();

        }

        /// <summary>
        /// it will clear the console and set the title to the next part
        /// </summary>
        /// <param name="title"></param>
        private static void ContinueToNextPart(string title)
        {
            Console.WriteLine("\n PRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.ReadLine();
            Console.Clear();
            Console.Title = title;
            Console.WriteLine("+++++++++++++ " + title + " +++++++++++++");
        }
    }
}
