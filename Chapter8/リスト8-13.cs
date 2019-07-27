using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_13 {
    class Program {
        static void Main(string[] args) {
            int? a = 10;
            int? b = 20;
            int? c = a + b;    // + 演算子が使える
            if (c.HasValue)
                Console.WriteLine(c.Value);
            Console.ReadLine();
        }
    }
}
