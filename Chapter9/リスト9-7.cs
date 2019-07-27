using System;
using Microsoft.VisualBasic;
using Gushwell.Utilities;

namespace List9_7 {
    class Program {
        static void Main(string[] args) {
            string str = "全国大学選手権大会";
            string s1 = str.ToTraditionalChinese();                 // (*1)
            string s2 = StringExtension.ToTraditionalChinese(str);  // (*2)
            Console.WriteLine(str);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

// 本来はこのコードは別ファイルとして作成する
namespace Gushwell.Utilities {
    public static class StringExtension {
        public static string ToTraditionalChinese(this string value) {
            return Strings.StrConv(value, VbStrConv.TraditionalChinese, 1);
        }
    }
}

