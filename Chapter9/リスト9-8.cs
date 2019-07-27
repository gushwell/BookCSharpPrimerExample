using System;

namespace Gushwell.Utilities {
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

