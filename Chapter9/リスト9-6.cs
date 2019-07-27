using Microsoft.VisualBasic;

namespace Gushwell.Utilities {
    public static class StringExtension {
        public static string ToTraditionalChinese(this string value) {
            return Strings.StrConv(value, VbStrConv.TraditionalChinese, 1);
        }
    }
}

