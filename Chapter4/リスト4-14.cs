using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringSample {
    class Program {
        static void Main(string[] args) {
            string str = " C# programming  ";
            string str2 = str.Trim();          // 文字列の前後の空白を除去する
            string str3 = str2.ToUpper();      // 大文字に変換する
            int index = str3.IndexOf('#');     // 指定した文字が最初に見つかった位置を求める
            int len = str3.Length;             // 文字列の長さを求める

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(index);
            Console.WriteLine(len);
            Console.ReadLine();
        }
    }
}
