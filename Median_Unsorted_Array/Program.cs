namespace Median_Unsorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 2, 5 };
            Array.Sort(arr);
            double median= arr.Length%2== 0 ? (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2.0
            : arr[arr.Length / 2];
            Console.WriteLine("Median: " + median);
        }
    }
}
