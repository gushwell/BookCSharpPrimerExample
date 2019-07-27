using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    public class Date {
        public Date(int year, int month, int day) {
            Year = year;
            Month = month;
            Day = day;
        }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        // あまり良くない IsLeapYearメソッド (1)
        public bool IsLeapYear() {
            return ((Year % 4 == 0) &&
            ((Year % 100 != 0) || (Year % 400 == 0)));
        }

        // あまり良くない IsLeapYearメソッド (2)
        public bool IsLeapYear(int year) {
            return ((Year % 4 == 0) &&
            ((Year % 100 != 0) || (Year % 400 == 0)));
        }

    }
}
