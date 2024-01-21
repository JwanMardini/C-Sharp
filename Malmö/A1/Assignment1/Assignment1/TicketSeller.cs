using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TicketSeller
    {
        private string name;
        private double price = 10.0;
        private int numOfAdults;
        private int numOfChildren;
        private double childDiscount = 0.25;

        private double amountToPay;

        public void ReadInput()
        {
            Console.WriteLine("Your name please:");
            this.name = Console.ReadLine();
            Console.WriteLine("Number of adults:");
            string inputString = Console.ReadLine();
            this.numOfAdults = int.Parse(inputString);
            Console.WriteLine("Number of children:");
            string inputString1 = Console.ReadLine();
            this.numOfChildren = int.Parse(inputString1);
        }

        private void ShowResults()
        {
            CalculateAmountToPay();
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine($"+++ Amount to pay = {this.amountToPay}$");
            Console.WriteLine($"+++ Price per ticket = {this.price}$");
            Console.WriteLine();
        }

        private void CalculateAmountToPay()
        {
            this.amountToPay = (numOfAdults * price) + (numOfChildren * (price - (price * childDiscount)));
        }

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children getalways a 75% discount!");
            Console.WriteLine();

            ReadInput();
            ShowResults();

            Console.WriteLine($"+++ Thank you {this.name} and please come back! +++");
            Console.WriteLine();
        }
    }
}
