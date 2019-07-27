using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_39 {
    class Program {
        static void Main(string[] args) {
            var nums = new List<int> { 1, 3, 6, 10, 15 };
            foreach (var n in Diff(nums))
                Console.Write("{0} ", n);
            Console.ReadLine();
        }

        static IEnumerable<int> Diff(IEnumerable<int> xs) {
            var ite = xs.GetEnumerator();
            if (ite.MoveNext())
                for (int prev = ite.Current; ite.MoveNext(); prev = ite.Current) {
                    yield return ite.Current - prev;
                }
        }

    }
}
