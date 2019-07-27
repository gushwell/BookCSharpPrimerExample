using System;

namespace Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            try {
                int n = 100;
                string s = Console.ReadLine();
                int m = int.Parse(s);  // (*1)
                int ans = n / m;         // (*2)
                Console.WriteLine(ans);
            } catch {
                Console.WriteLine("エラーが発生");
            }
            Console.ReadLine();
        }
    }
}
