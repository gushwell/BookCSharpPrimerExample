using System;

namespace Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            BaseClass baseObj = new BaseClass();
            baseObj.Foo();
            DelivedClass dc = new DelivedClass();
            dc.Foo();
            BaseClass dc2 = new DelivedClass();
            dc2.Foo();
            Console.ReadLine();
        }
    }

    class BaseClass {
        public void Foo() {
            Console.WriteLine("BaseClass.Foo");
        }
    }

    class DelivedClass : BaseClass {
        public new void Foo() {
            Console.WriteLine("DelivedClass.Foo");
        }
    }
}
