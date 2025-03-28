using A2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    internal class MathWork
    {
        /// <summary>
        /// Will calculate the sum of numbers between two numbers
        /// </summary>
        public void Calculate()
        {
            
            Console.WriteLine();
            Console.WriteLine("Sum numbers between any two numbers");
            //Console.WriteLine("Give start number: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Give end number: ");
            //int end = int.Parse(Console.ReadLine());

            int start = Input.ReadIntegerConsole("Give start number: ");
            int end = Input.ReadIntegerConsole("Give end number: ");



            // Swap start and end if start is greater than end
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            Console.WriteLine();
            int sum = SumNumbers(start, end);
            Console.WriteLine($"The sum of numbers between {start} and {end} is: {sum}");

            Console.WriteLine();
            Console.WriteLine($"****Even numbers between {start} and {end}");
            PrintEvenNumbers(start, end);

            Console.WriteLine();
            Console.WriteLine($"****Odd numbers between {start} and {end}");
            PrintOddNumbers(start, end);

            Console.WriteLine();
            Console.WriteLine("**** Square Roots ****");
            CalculateSquareRoots(start, end);
            Console.WriteLine();

            // Ask user if they want to exit
            if (ExitCalculation())
            {
                return;
            }
            else
            {
                Calculate();
            }



        }
        /// <summary>
        /// will calculate the square roots of numbers between two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void CalculateSquareRoots(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                Console.Write($"Sqrt({i, 3} to {num2})");
                for (int j = i; j <= num2; j++) // to format the output
                {
                    Console.Write($"{Math.Sqrt(j), 6:F2}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Will ask the user if they want to exit the calculation
        /// </summary>
        /// <returns></returns>
        private bool ExitCalculation()
        {
            Console.WriteLine("Exit math work? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                return true;
            }else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return ExitCalculation();
            }
        }
        /// <summary>
        /// it will print even numbers between two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        private void PrintEvenNumbers(int number1, int number2)
        {
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "    ");
                }
            }
            Console.WriteLine();
        }

        private void PrintMultiplicationTable()
        {

        }
        /// <summary>
        /// it will print odd numbers between two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        private void PrintOddNumbers(int number1, int number2)
        {
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + "    ");
                }
            }
            Console.WriteLine();    
        }
        /// <summary>
        /// it will calculate the sum of numbers between two numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int SumNumbers(int start, int end)
        {
            int result = 0;
            for (int i = start; i <= end; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
