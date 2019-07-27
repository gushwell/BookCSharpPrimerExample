using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace List8_19 {
    class Program {
        static void Main(string[] args) {
            ArrayList list = new ArrayList();
            list.Add(new DateTime(2011, 1, 5));
            list.Add(new DateTime(2011, 2, 15));

            DateTime x = (DateTime)list[0];
            DateTime y = (DateTime)list[1];

        }
    }
}
