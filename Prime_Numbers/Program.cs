namespace Prime_Numbers
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num = 29;
            int n = 50;
            Console.WriteLine(IsPrime(num) ? $"{num} is Prime" : $"{num} is not Prime");
            FindPrimes(n);
        }
        static void FindPrimes(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
