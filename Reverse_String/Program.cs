namespace Reverse_String
{
    internal class Program
    {
        public static void ReverseString()
        {
            string input = "HelloWorld";
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string output = new string(charArray);
            Console.WriteLine("Reversed String : " + output);
        }
        public static string ManualReverseString()
        {
            string input = "HelloWorld";
            string output = "";
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = input[input.Length - 1 - i];
            }
            return new string(output);
        }
        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        static int ReversedNumber(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            return rev;
        }
        public static void Main(string[] args)
        {
            int num = 12345;
            Console.WriteLine("Reversed Number: "+ReversedNumber(num));
            ReverseString();
            ManualReverseString();

            string sentence = "C# is awesome";
            Console.WriteLine("Reverse word string is "+ReverseWords(sentence));
        }
    }
}
