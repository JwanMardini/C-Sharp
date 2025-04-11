namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses problem = new ValidParentheses();
            bool result = problem.IsValid("[}");
            Console.Write(result);

        }
    }
}
