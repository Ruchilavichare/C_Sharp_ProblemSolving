namespace Largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 224, 697, 10, 45, 897, 43 };
            Console.WriteLine("Largest element is: " + Largest_Element(arr));
            Console.WriteLine("Second Largest element is: " + Second_Largest(arr));

            Console.WriteLine("Largest element is " + Find_Max(arr));
            Console.WriteLine("Second Largest element is: " + FindSecondLargest(arr));

            //Longest Word in a Sentence
            string sentence = "The quick brown fox jumps over the lazy dog";
            var LongestWord = sentence.Split(' ').OrderByDescending(s => s.Length).First();
            Console.WriteLine("Longest word is: " + LongestWord);

        }
        static int Largest_Element(int[] arr)
        {
            int LargestElement = arr.Max(x => x);
            return LargestElement;
        }
        static int Second_Largest(int[] arr)
        {
            int Second = arr.Distinct().OrderByDescending(x => x).Skip(1).FirstOrDefault();
            return Second;
        }
        static int Find_Max(int[] arr)
        {
            int Max = arr[0];
            foreach (int num in arr)
            {
                if (num > Max) Max = num;
            }
            return Max;
        }
        static int FindSecondLargest(int[] arr)
        {
            int first = int.MinValue, second = int.MinValue;
            foreach (int num in arr)
            {
                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    second = num;
                }

            }
            return second;
        }



    }
}
