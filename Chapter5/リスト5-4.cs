using System;
using System.Collections.Generic;

namespace ListSample {

    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int> { 5, 3, -3, 6, -7, 2 };
            bool b = list.TrueForAll(IsPositive);
            Console.WriteLine(b);
            Console.ReadLine();
        }

        static bool IsPositive(int num) {
            return num > 0;
        }
    }
}
