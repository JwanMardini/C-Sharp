namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(0, 1000);
            int score = 0;
            Console.WriteLine(answer);
            while (true)
            {
                Console.Write("Guess: ");
                string text = Console.ReadLine();
                int guess = int.Parse(text);

                if (answer == guess)
                {
                    Console.WriteLine($"Correct!, {score}");
                    return;
                }
                else if (answer < guess)
                {
                    Console.WriteLine("Too large");
                }
                else
                {
                    Console.WriteLine("Too small");
                }
                score++;
            }
        }
    }
}
