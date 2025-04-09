namespace Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 6, 7 };
            Console.WriteLine("Missing Number" + FindMissingNumber(arr, (arr.Length + 1)));
        }
        //Find Missing Number in a Sequence
        static int FindMissingNumber(int[] arr, int n)
        {
            int Total = n * (n + 1) / 2;
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return Total - sum;
        }
    }
}
