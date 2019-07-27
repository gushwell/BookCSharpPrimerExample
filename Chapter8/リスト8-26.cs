using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_26 {
    // delegateは、「型」なので、classと同列で定義できる
    public delegate void MyDelegate(int i);

    class Program {
        static void Main(string[] args) {
            Program pgm = new Program();
            pgm.Execute();
            Console.ReadLine();
        }

        public void Execute() {
            MyDelegate func = DelegateFunction1;
            func += DelegateFunction2;
            MyClass obj = new MyClass();
            obj.DoSomething(func);
        }

        private void DelegateFunction1(int n) {
            Console.WriteLine("{0}が引数として渡されました", n);
        }
        private void DelegateFunction2(int n) {
            Console.WriteLine("引数は、{0}です。", n);
        }
    }

    class MyClass {
        public void DoSomething(MyDelegate function) {
            for (int i = 0; i < 3; i++)
                function(i);
        }
    }

}
