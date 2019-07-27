using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadSample {
    class Program {
        static void Main(string[] args) {
            Sample obj = new Sample();

            int a = obj.MaxNumber((short)10, (short)20);
            double b = obj.MaxNumber((float)10.0, (float)20.0);

            Console.WriteLine("{0} {1}", a, b);
            Console.ReadLine();
        }
    }

    class Sample {
        public int MaxNumber(int x, int y) {
            return x > y ? x : y;
        }
        public double MaxNumber(double x, double y) {
            return x > y ? x : y;
        }


    }
}
