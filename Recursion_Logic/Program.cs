namespace Recursion_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Factorial of " + num + " is " + Factorial(num));
            int num1 = 10;
            for (int i = 1; i <= num1; i++)
            {
                Console.WriteLine(Fibonacci(i) + " ");
            }

            Console.Write("Enter a string: ");
            string input = Console.ReadLine() ?? "";
            string reverse = ReverseString(input);
            Console.WriteLine("Reversed String: "+ reverse);
        }
        static int Factorial(int num)
        {
            if (num == 0) return 1;
            return num * Factorial(num - 1);
        }
        static int Fibonacci(int num)
        {
            if (num <= 1) return num;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
        //Reverse string using recursion
        static string ReverseString(string str)
        {
            if(str.Length<=1) return str;

            return ReverseString(str.Substring(1) + str[0]);
        }
    }
}
