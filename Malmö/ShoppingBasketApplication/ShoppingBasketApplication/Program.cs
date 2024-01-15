using System.Runtime.InteropServices;

namespace ShoppingBasketApplication
{
    internal class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Welcome to my shop!");
            Console.WriteLine("Name of the product?");
            String name = Console.ReadLine();
            Console.WriteLine($"Thanks {name}!");
            Console.WriteLine("Price?");
            double price;
            while (true)
            {
                try{
                    String priceInput = Console.ReadLine();
                    price = double.Parse(priceInput);
                    break;
                }
                catch (Exception){
                    Console.WriteLine("Something went wrong, try again!");
                }
            }
            /*try/catch is slow, we can do it this way for parseing:
            int price;
            bool success = int.TryParse(priceInput, out price)
            if(!success){
            //Error
            }*/
            Console.WriteLine($"The price of {name} is {price}");
            Console.WriteLine("Quantity of the product?");
            int quantity;
            while (true)
            {
                try
                {
                    String quantityInput = Console.ReadLine();
                    quantity = int.Parse(quantityInput);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong, try again!");
                }
            }
            Product product = new Product(name, price, quantity);
            product.printReceipt();
        }
    }
}
