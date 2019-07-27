using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_25 {

    class Program {
        public static void Main() {
            MyDelegate func = DelegateFunction;
            DoSomething(func);
            Console.ReadLine();
        }

        public delegate void MyDelegate(int i);

        public static void DelegateFunction(int n) {
            Console.WriteLine("{0}が引数として渡されました", n);
        }

        public static void DoSomething(MyDelegate Function) {
            Function(10);
        }
    }

}
