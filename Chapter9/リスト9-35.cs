using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_35 {
    class Program {
        static void Main(string[] args) {
            dynamic a = 10;
            dynamic b = DateTime.Today;
            Console.WriteLine("{0} {1}", a, a.GetType());
            Console.WriteLine("{0} {1}", b, b.GetType());
            a = "Hello";      // a に別の型を再代入
            Console.WriteLine("{0} {1}", a, a.GetType());

            Console.ReadLine();
        }
    }
}
