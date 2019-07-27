using System;
using System.Collections.Generic;

namespace ListSample {
    class Program {
        static void Main(string[] args) {

            List<int> list = new List<int> { 5, 3, -3, 6, -7, 2 };
            List<int> list2 = list.FindAll(IsPositive);
            foreach (var n in list2)
                Console.WriteLine(n);
            Console.ReadLine();
        }

        static bool IsPositive(int num) {
            return num > 0;
        }
    }
}
