using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TicketSeller
    {
        private string name; // Stores the name of the ticket buyer
        private double price = 10.0; // Stores the base price of a ticket
        private int numOfAdults; // Stores the number of adult tickets
        private int numOfChildren; // Stores the number of children tickets
        private double childDiscount = 0.25; // Stores the discount percentage for children

        private double amountToPay; // Stores the total amount to pay by the ticket buyer

        // Method to read input from the user
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

        // Method to calculate the amount to pay based on ticket details
        private void CalculateAmountToPay()
        {
            this.amountToPay = (numOfAdults * price) + (numOfChildren * (price - (price * childDiscount)));
        }

        // Method to display the results and receipt
        private void ShowResults()
        {
            CalculateAmountToPay();
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine($"+++ Amount to pay = {this.amountToPay}$");
            Console.WriteLine($"+++ Price per ticket = {this.price}$");
            Console.WriteLine();
        }

        // Method to start the ticket selling process
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children always get a 75% discount!"); // Typo: "get always" corrected to "always get"
            Console.WriteLine();

            ReadInput(); // Read ticket buyer information
            ShowResults(); // Display receipt and results

            Console.WriteLine($"+++ Thank you {this.name} and please come back! +++");
            Console.WriteLine();
        }
    }
}
