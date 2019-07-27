using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List7_2 {
    class Program {
        static void Main(string[] args) {
            try {
                int n = 100;
                string s = Console.ReadLine();
                int m = int.Parse(s);
                int ans = n / m;
                Console.WriteLine(ans);
            } catch (System.DivideByZeroException) {
                Console.WriteLine("ゼロで除算しました");
            } catch (System.FormatException) {
                Console.WriteLine("整数を入力してください");
            }
            Console.ReadLine();
        }

    }
}
