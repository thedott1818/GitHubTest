namespace GitHubTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int n = 1;
            Print();
        }
        static void Print(int n)
        {
            Console.WriteLine($"{n++} {Console.ReadLine()}");
        }
    }
}
