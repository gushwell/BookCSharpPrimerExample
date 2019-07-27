using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_34 {
    class Program {
        static void Main(string[] args) {
            var days = GetDays(new DateTime(2000, 1, 1))
                          .Where(dt => dt.Day == dt.Month)
                     .Where(dt => dt.DayOfWeek == DayOfWeek.Monday)
                          .Take(5);
            foreach (var dt in days) {
                Console.WriteLine(dt.ToString("yyyy/MM/dd(ddd)"));
            }

            Console.ReadLine();
        }

        static IEnumerable<DateTime> GetDays(DateTime fromDate) {
            var date = fromDate;
            while (true) {
                yield return date;
                date = date.AddDays(1);
            }
        }
    }
}