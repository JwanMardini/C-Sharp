namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RomanToIntProblem problem = new RomanToIntProblem();

            Console.WriteLine(problem.RomanToInt("III"));
            Console.WriteLine(problem.RomanToInt("LVIII"));
            Console.WriteLine(problem.RomanToInt("MCMXCIV"));
            Console.WriteLine(problem.RomanToInt("IV"));

        }
    }
}
