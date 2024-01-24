using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CarStore
    {
        private string carModel;
        private int carYear;
        private double carPrice;
        private int carMileage;
        private string carColor;
        private DateTime carDatePurchased;

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
        }


        public void DisplayCarInfo()
        {
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine($"Model: {this.carModel} Year: {this.carYear}");
            Console.WriteLine($"Price: {this.carPrice} Mileage: {this.carMileage}");
            Console.WriteLine($"Color: {this.carColor} Date Purchased: {this.carDatePurchased.ToString("yyyy-MM-dd")}");
            Console.WriteLine("++++++++++++++++++++++++++++");

        }

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from the car store class");
            Console.WriteLine();

            ReadCarInfo();
            DisplayCarInfo();
            Console.WriteLine();
        }
    }



}
