using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_31 {
    class Program {
        static void Main(string[] args) {
            object[] objs = new object[] { 1, 2, "abc", 4, "xyz" };
            var total = objs.OfType<int>()
                            .Sum();
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}