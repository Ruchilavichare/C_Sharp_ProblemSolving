namespace Fibonacci_Series
{
    internal class Program
    {
        static int Fibonacci_recersive(int n)
        {
            return n <= 1 ? n : Fibonacci_recersive(n - 1) + Fibonacci_recersive(n - 2);
        }
        static void Fibonacci_Iterative(int n)
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a + " " + b + " ");
            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b; b = c;
            }
        }
        static void Main(string[] args)
        {
            int n = 20;
            Fibonacci_Iterative(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci_recersive(i) + " ");
            }

        }
    }
}
