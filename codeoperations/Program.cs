namespace codeoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("Starting Program");
            Console.WriteLine("Starting Loop");
            for (int i=0; i < n; i++)
            {
                Console.WriteLine($"Iteration {i + 1}");
            }
            Console.WriteLine("Ending Program");
        }
    }
}
