using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIst9_40 {
    class Program {
        static void Main(string[] args) {
            var inums = new List<int> { 1, 3, 6, 10, 15 };
            foreach (var n in Diff(inums))
                Console.Write("{0} ", n);
            Console.WriteLine();

            var dnums = new List<double> { 1.3, 3.2, 6.9, 10.0, 15.2 };
            foreach (var n in Diff(dnums))
                Console.Write("{0} ", n);

            Console.ReadLine();

        }

        static IEnumerable<T> Diff<T>(IEnumerable<T> xs) {
            var ite = xs.GetEnumerator();
            if (ite.MoveNext())
                for (T prev = ite.Current; ite.MoveNext(); prev = ite.Current) {
                    yield return (dynamic)ite.Current - (dynamic)prev;
                }
        }

    }
}
