using System;

namespace ValueType {
    class Program {
        static void Main(string[] args) {
            MyClass original = new MyClass();
            original.x = 10;
            MyClass replica = original;
            original.x = 20;
            Console.WriteLine(replica.x);
            Console.ReadLine();
        }
    }

    class MyClass {
        public int x;
    }

}
