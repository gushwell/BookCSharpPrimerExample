using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            if (Date.IsLeapYear(2009))
                Console.WriteLine("2009年は閏年です");

            Date dt = new Date(2004, 3, 7);
            if (dt.IsLeapYear())
                Console.WriteLine("2004年は閏年です");
            
            Console.ReadLine();
        }
    }

    // 実際の開発では、ユーザが定義したクラスは、別のファイルに定義しておくのが
    // 一般的です。このときのファイル名は、「クラス名.cs」とします。
    // この例では、Date.cs ファイルに、Dateクラスを定義します。
    // Visual Studio での操作方法は、当ファイルと同梱した
    // 「プロジェクトにクラスファイルを追加する方法.pdf」をご覧ください。
    public class Date {
        public Date(int year, int month, int day) {
            Year = year;
            Month = month;
            Day = day;
        }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public static bool IsLeapYear(int year) {  // staticを付加する
            return ((year % 4 == 0) &&
                      ((year % 100 != 0) || (year % 400 == 0)));
        }

        // インスタンスメソッドとしても定義しておく
        public bool IsLeapYear() {
            return Date.IsLeapYear(this.Year);
        }
    }

}
