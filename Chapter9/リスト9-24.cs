using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_24 {
    class Program {
        static void Main(string[] args) {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberGroups = numbers.GroupBy(n => n % 5);    //...(*)
            foreach (var g in numberGroups) {
                Console.Write("余りが {0} の数は、", g.Key);
                foreach (var n in g)
                    Console.Write("{0}, ", n);
                Console.WriteLine("です。");
            }
            Console.ReadLine();
        }
    }
}
