using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketApplication
{
    internal class Product
    {
        private String name;
        private double price;
        private int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public String getName() {return this.name;}

        public double getPrice() { return this.price;}

        public int getQuantity() { return this.quantity;}

        public void printReceipt()
        {
            Console.WriteLine("The number of this prooduct is 9\n");
            Console.WriteLine("***** Receipt *****\n");
            Console.WriteLine($"Product      :      {this.name}");
            Console.WriteLine($"Unit price   :      {this.price}");
            Console.WriteLine($"Quantity     :      {this.quantity}\n");

            Console.WriteLine($"Amount to pay:      {this.quantity * this.price}\n");
            Console.WriteLine(" **** Welcome back! ****");
        }


    }
}
