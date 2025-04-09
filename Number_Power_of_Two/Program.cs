namespace Number_Power_of_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 16;
            Console.WriteLine(IsPowerOfTwo(num) ? "Yes" : "No");
        }
        static bool IsPowerOfTwo(int num)
        {
            return (num > 0) && ((num & (num - 1)) == 0);
        }
    }
}
