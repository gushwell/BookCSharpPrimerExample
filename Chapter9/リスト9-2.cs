using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_2 {
    class Program {
        static void Main(string[] args) {
            foreach (int n in GetRandom5(0, 100)) {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        static IEnumerable<int> GetRandom5(int min, int max) {
            Random rnd = new Random();
            yield return rnd.Next(min, max);
            yield return rnd.Next(min, max);
            yield return rnd.Next(min, max);
            yield return rnd.Next(min, max);
            yield return rnd.Next(min, max);
        }

    }
}
