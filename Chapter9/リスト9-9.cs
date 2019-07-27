using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Utilities {
    class Program {
        static void Main(string[] args) {
            DateTime dt = DateTime.Now;
            // DateTimeExtensionが、同じ名前空間内なので、usingは必要ない。
            Console.WriteLine(dt.ToJapaniesDateString(null));
            Console.WriteLine(dt.ToJapaniesDateString("yy.MM.dd"));
            Console.ReadLine();
        }
    }


    public static class DateTimeExtension {
        public static string ToJapaniesDateString(this DateTime date,
                                                  string format) {
            System.Globalization.CultureInfo jp =
                        new System.Globalization.CultureInfo("ja-JP");
            jp.DateTimeFormat.Calendar =
                        new System.Globalization.JapaneseCalendar();
            if (format == null) {
                return date.ToString("ggyy年MM月dd日 dddd", jp);
            } else {
                return date.ToString(format, jp);
            }
        }
    }
}


