using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CarStore
    {
        private string carModel; // Stores the model of the car
        private int carYear; // Stores the year of the car
        private double carPrice; // Stores the price of the car
        private int carMileage; // Stores the mileage of the car
        private string carColor; // Stores the color of the car
        private int carId; // Stores the unique identifier of the car
        private DateTime carDatePurchased; // Stores the purchase date of the car

        // Method to read input and populate car information
        public void ReadCarInfo()
        {
            Console.Write("What is the car model? ");
            this.carModel = Console.ReadLine();

            Console.Write("What is the car year? ");
            string yearInput = Console.ReadLine();
            this.carYear = int.Parse(yearInput);

            Console.Write("What is the car price? ");
            string priceInput = Console.ReadLine();
            this.carPrice = double.Parse(priceInput);

            Console.Write("What is the car mileage (mil)? ");
            string mileageInput = Console.ReadLine();
            this.carMileage = int.Parse(mileageInput);

            Console.Write("What is the car color? ");
            this.carColor = Console.ReadLine();

            Console.Write("What is the car date purchased (mm/dd/yyyy)? ");
            string datePurchasedInput = Console.ReadLine();
            this.carDatePurchased = DateTime.Parse(datePurchasedInput);

            // Generate a random carId
            Random random = new Random();
            this.carId = random.Next(1, 9999);
        }

        // Method to display car information
        public void DisplayCarInfo()
        {
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine($"Model: {this.carModel} Year: {this.carYear}");
            Console.WriteLine($"Price: {this.carPrice} Mileage: {this.carMileage}");
            Console.WriteLine($"Color: {this.carColor} Date Purchased: {this.carDatePurchased.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Car Id: {this.carId}");
            Console.WriteLine("++++++++++++++++++++++++++++");
        }

        // Method to start the interaction with the car store
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from the car store class");
            Console.WriteLine();

            ReadCarInfo(); // Read car information from user
            DisplayCarInfo(); // Display the entered car information
            Console.WriteLine();
        }
    }
}
