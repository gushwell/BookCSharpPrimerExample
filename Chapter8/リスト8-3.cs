using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_3 {
    class Program {
        static void Main(string[] args) {
            DayWeek dw = DayWeek.Sunday;
            if (dw == DayWeek.Saturday)
                Console.WriteLine("土曜日です");
            Console.ReadLine();
        }
    }

    public enum DayWeek {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

}
