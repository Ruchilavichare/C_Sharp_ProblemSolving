namespace Intersection_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };

            var intersaction = arr1.Intersect(arr2);
            Console.WriteLine("Intersection: "+string.Join(",",intersaction));
        }
    }
}
