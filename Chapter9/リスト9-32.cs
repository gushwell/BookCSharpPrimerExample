using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_32 {
    class Program {
        static void Main(string[] args) {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numberGroups = from n in numbers
                               group n by n % 4 into g
                               orderby g.Key
                               select new { Remainder = g.Key, Count = g.Count() };
            foreach (var obj in numberGroups) {
                Console.WriteLine("余りが {0} の個数は、{1}個です",
                                          obj.Remainder, obj.Count);
            }


            Console.ReadLine();
        }
    }
}