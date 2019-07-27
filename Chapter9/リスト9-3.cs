using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_3 {
    class Program {
        static void Main(string[] args) {
            foreach (int n in GetNumbers()) {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static IEnumerable<int> GetNumbers() {
            yield return 0;
            yield return 2;
            yield return 4;
            var rnd = new Random();
            if (rnd.Next(0, 2) == 0)
                yield break;   // 条件に一致すれば反復を終了する
            yield return 6;
            yield return 8;
            yield return 10;
        }  
    }
}
