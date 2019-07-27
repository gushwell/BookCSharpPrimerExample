using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_37 {
    class Program {
        static void Main(string[] args) {
            Execute();

            Console.ReadLine();

        }

        public static void CallDynamic(dynamic obj, int n) {
            dynamic r = obj.DoSomething(n);
            Console.WriteLine(r);
        }

        public static void Execute() {
            Foo foo = new Foo();
            CallDynamic(foo, 2);
            Bar bar = new Bar();
            CallDynamic(bar, 3);
        }

    }

    public class Foo {
        public string DoSomething(int n) {
            return (n + n).ToString();
        }
    }

    public class Bar {
        public int DoSomething(int n) {
            return n * 3;
        }
    }

}
