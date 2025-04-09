namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1, 4 };
            BubbleSort(arr);
            Console.WriteLine("Sorted Array " + string.Join(",", arr));
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
