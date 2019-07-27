using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_16 {
    class Program {
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.TestRamda();
            Console.ReadLine();
        }

        private delegate int MyFunction(int i);

        public void TestRamda() {
            // C#3.0 ラムダ式
            MyFunction fun = (int x) => { return x * 3; };   // (*)
            int n = fun(20);
            Console.WriteLine(n);
        }

    }
}
