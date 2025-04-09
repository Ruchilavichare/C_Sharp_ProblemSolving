namespace Factorial_Number
{
    internal class Program
    {
        public static int Factorial_Number(int UpperLimit)
        {
            int result = 1;
            for (int i = 2; i <= UpperLimit; i++)
            {
                result = result * i;
            }
            return result;
        }
        public static int Factorial_recursion(int UpperLimit)
        {
            int result = 1;
            result = (result <= 1) ? 1 : UpperLimit * Factorial_Number(UpperLimit - 1);
            return result;
        }
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"Factorial of {number} is {Factorial_Number(number)}");
            Console.WriteLine($"Factorial of {number} is {Factorial_recursion(number)}");
        }
    }
}
