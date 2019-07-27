using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_14 {
    class Program {
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.TestDelegate();
            Console.ReadLine();
        }

        private delegate int MyFunction(int i);

        private int Triple(int n) {
            return n * 3;
        }

        public void TestDelegate() {
            MyFunction fun = new MyFunction(Triple);
            int n = fun(20);
            Console.WriteLine(n);
        }
    }
}
