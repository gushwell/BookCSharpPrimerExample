using System;
using System.Collections.Generic;
using System.Linq;

namespace Gushwell.Utilities {
    class Program {
        static void Main(string[] args) {
            var strs = new List<string> { "C#", "Java", "Ruby", "Python" };
            Console.WriteLine("\"{0}\"", strs.Join(" - "));
            int[] nums = { 2, 4, 6, 8, 10 };
            Console.WriteLine("\"{0}\"", nums.Join(", "));
            Console.ReadLine();
        }

    }
    public static class StringExtension {
        public static string Join<T>(this IEnumerable<T> items, string separator) {
            var array = items.Select(x => x.ToString()).ToArray();
            return string.Join(separator, array);
        }
    }
}
