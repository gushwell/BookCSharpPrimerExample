using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_38 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(TwiceIt(5));
            Console.WriteLine(TwiceIt(1.2));
            Console.WriteLine(TwiceIt("Hello"));

            Console.ReadLine();
        }

        private static dynamic TwiceIt(dynamic o) {
            return o + o;
        }

    }
}
