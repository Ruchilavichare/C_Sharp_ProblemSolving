using System;
using System.Collections.Generic;

namespace Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2,3,5,4,6,7,2,4,6,7,8,9,1,23,43,11,22,11,44};

            FindDuplicates(arr);
            ContainsDuplicated(arr);
            ContainsDuplicatedLinq(arr);

            string str = "swiss";
            Console.WriteLine("First Non-Repeating Character: " + FirstNonRepeatingChar(str));
        }
        static bool ContainsDuplicated(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int i in arr)
            {
               if (seen.Contains(i)) return true;
                seen.Add(i);
            }
            return false;
        }
        static bool ContainsDuplicatedLinq(int[] arr)
        {
           // var duplicates = arr.ToLookup(s => s).Where(g => g.Count() > 1).Select(s => s.Key);
            return arr.Distinct().Count().Equals(arr.Length);
        }
        static void FindDuplicates(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int item in arr)
            {
                if(seen.Contains(item))
                {
                    duplicates.Add(item);
                }
                else
                {
                    seen.Add(item);
                }
                Console.WriteLine("Duplicate elements: "+string.Join(",", duplicates));
            }
        }

        //First Non-Repeating Character in a String
        static char FirstNonRepeatingChar(string str)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (count.ContainsKey(c))
                    count[c]++;
                else
                    count[c] = 1;
            }

            foreach (char c in str)
            {
                if (count[c] == 1)
                    return c;
            }

            return '_'; // No non-repeating character found
        }
    }
}
