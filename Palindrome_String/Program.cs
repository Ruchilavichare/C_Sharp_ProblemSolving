namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "madam";
            Console.WriteLine(ISPalindrom(input) ? "Palindrom" : "Not a Palindrom");
        }
        //Check If a String is a Palindrome
        static bool ISPalindrom(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if(s[left] != s[right]) return false;
                
                left++;
                right--;
                
            }
            return true;
        }
    }
}
