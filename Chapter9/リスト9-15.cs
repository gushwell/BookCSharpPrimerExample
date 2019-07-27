using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_15 {
    class Program {
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.TestAnonymous();
            Console.ReadLine();
        }

        private delegate int MyFunction(int i);

        public void TestAnonymous() {
            // C#2.0 匿名メソッド
            MyFunction fun = delegate(int x) { return x * 3; };
            int n = fun(20);
            Console.WriteLine(n);
        }
    }
}
