using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_1 {
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
            for (int i = 0; i < 5; i++) {
                int val = rnd.Next(min, max);
                yield return val;
            }
        }

    }
}
