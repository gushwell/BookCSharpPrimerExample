using System;
using System.Collections.Generic;

namespace ListSample {
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(-40);
            list.ForEach(Print);  // すべての要素に対してPrintを呼び出す。
            Console.ReadLine();
        }

        static void Print(int n) {
            string s = n.ToString();
            Console.WriteLine(s);
        }
    }
}
