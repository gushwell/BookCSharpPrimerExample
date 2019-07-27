using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    class MyClass {
        public int X;
        public int Y;
    }

    struct MyStruct {
        public int X;
        public int Y;
    }

    class Sample {
        static void Main() {
            MyClass mc1 = new MyClass();
            mc1.X = 10;
            mc1.Y = 20;
            MyClass mc2 = mc1;
            mc2.X = 0;
            mc2.Y = 1;
            Console.WriteLine("{0}, {1}", mc1.X, mc1.Y);
            Console.WriteLine("{0}, {1}", mc2.X, mc2.Y);

            MyStruct ms1 = new MyStruct();
            ms1.X = 10;
            ms1.Y = 20;
            MyStruct ms2 = ms1;
            ms2.X = 0;
            ms2.Y = 1;
            Console.WriteLine("{0}, {1}", ms1.X, ms1.Y);
            Console.WriteLine("{0}, {1}", ms2.X, ms2.Y);
            Console.ReadLine();
        }
    }

}
