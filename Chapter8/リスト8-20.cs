using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_20 {
    class Program {
        static void Main(string[] args) {
            List<DateTime> list = new List<DateTime>();
            list.Add(new DateTime(2011, 1, 5));
            list.Add(new DateTime(2011, 2, 15));

            DateTime x = list[0];
            DateTime y = list[1];

        }
    }
}
