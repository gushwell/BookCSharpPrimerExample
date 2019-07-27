using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_11 {
    class Program {
        static void Main(string[] args) {
            int? n = 10;
            if (n.HasValue)
                Console.WriteLine(n.Value);
            else
                Console.WriteLine("値はありません");
            Console.ReadLine();
        }
    }
}
