using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_9 {
    class Program {
        enum Colors { Red, Green, Blue };
        static void Main(string[] args) {
            foreach (string name in Enum.GetNames(typeof(Colors)))
                Console.WriteLine(name);
            foreach (int i in Enum.GetValues(typeof(Colors)))
                Console.WriteLine(i);
            Console.WriteLine(Enum.IsDefined(typeof(Colors), 4));

            Console.ReadLine();
        }

    }
}
