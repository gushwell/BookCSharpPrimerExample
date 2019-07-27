using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_17 {
    class Program {
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.TestRamda();
            Console.ReadLine();
        }

        private delegate int MyFunction(int i);

        public void TestRamda() {
            // 単一ステートメントでは、{ } と return は省略できる
            MyFunction fun1 = (int x) => x * 3;
            int n1 = fun1(20);
            Console.WriteLine(n1);

            // 引数の型は省略できる (MyFunctionデリゲートは、int型の引数であることが明白)
            MyFunction fun2 = (x) => x * 3;
            int n2 = fun2(20);
            Console.WriteLine(n2);

            // 引数が1つのときは、( )も省略できる
            MyFunction fun3 = x => x * 3;
            int n3 = fun3(20);
            Console.WriteLine(n3);
        }

    }
}
