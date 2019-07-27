using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_14 {
    class Program {
        static void Main(string[] args) {
            int? a = null;
            int? b = 20;
            Console.WriteLine(a == null);
            Console.WriteLine(a != b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a > b);

            Console.ReadLine();
        }
    }
}
