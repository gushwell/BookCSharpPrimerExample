using System;

namespace ValueType {
    class Program {
        static void Main(string[] args) {
            MyStruct original = new MyStruct();
            original.x = 10;
            MyStruct replica = original;
            original.x = 20;
            Console.WriteLine(replica.x);
            Console.ReadLine();
        }
    }

    struct MyStruct {
        public int x;
    }
}
