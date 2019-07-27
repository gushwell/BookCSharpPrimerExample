using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_1 {
    class Program {
        static void Main(string[] args) {
            ConstSample obj = new ConstSample();
            obj.Foo();
            Console.ReadLine();
        }
    }

    class ConstSample {
        private const int MaxNum = 255;
        private const int MinNum = -256;
        private const string Name = "MyClass";
        public void Foo() {
            Console.WriteLine(Name);
            Console.WriteLine(" MaxNum = " + MaxNum);
            Console.WriteLine(" MinNum = " + MinNum);
        }
    }

}
