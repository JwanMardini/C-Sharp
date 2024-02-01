namespace Assignment1
{
    internal class Program
    {
        private static string classUsed;
        static void Main(string[] args)
        {
            SetupConsoleWindow(); // Set up console window appearance
            classUsed = "Pet";
            Console.Title = classUsed;
            Pet pet = new Pet();
            pet.Start();

            Console.Write("Press Enter to start next part!");
            Console.ReadLine();

            classUsed = "TicketSeller";
            Console.Title = classUsed;
            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.Start();

            Console.Write("Press Enter to start next part!");
            Console.ReadLine();

            classUsed = "Album";
            Console.Title = classUsed;
            Album album = new Album();
            album.Start();

            Console.Write("Press Enter to start next part!");
            Console.ReadLine();

            classUsed = "CarStore";
            Console.Title = classUsed;
            CarStore carStore = new CarStore();
            carStore.Start();
        }

        static void SetupConsoleWindow()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;   
        }
    }
}
