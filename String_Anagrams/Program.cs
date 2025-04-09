namespace String_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "silent";
            string str2 = "listen";
            Console.WriteLine(AreAnagrams(str1, str2) ? "Anagrams" : "Not Anagrams");
        }
        static bool AreAnagrams(string str1, string str2)
        {
            return str1.Length == str2.Length && str1.OrderBy(s => s).Equals(str2.OrderBy(s => s));
        }
    }
}
