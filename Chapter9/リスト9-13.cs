using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_13 {
    class Program {
        static void Main(string[] args) {
            Action[] del = new Action[3];
            for (int i = 0; i < 3; i++) {
                int x = i;
                del[i] = delegate { Console.WriteLine("{0} {1}", i, x); };
            }
            for (int j = 0; j < 3; j++) {
                del[j]();      // 匿名メソッドを呼び出している
            }
            Console.ReadLine();
        }
    }
}
