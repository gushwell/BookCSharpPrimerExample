using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_18 {
    class Program {
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.TestRamda();
            Console.ReadLine();
        }

        public void TestRamda() {
            Func<int, int> fun = x => x * 3;
            int n = fun(20);
            Console.WriteLine(n);
        }

    }
}
