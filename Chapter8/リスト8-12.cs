using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_12 {
    class Program {
        static void Main(string[] args) {
            int i = 123;
            int? n = i;            // int --> int?
            double? d = n;        // int? --> double?
            int j = (int)n;       // int? --> int

        }
    }
}
