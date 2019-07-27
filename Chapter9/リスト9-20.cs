using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_20 {
    class Program {
        static void Main(string[] args) {
            string[] names = { "Microsoft", "Apple", "IBM", "Google", "HP", "Dell" };
            var query = from s in names
                        where s.Length > 5
                        select s;
            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine("------");

            names[2] = "Oracle";           // (*1)
            // 再度 foreachで取り出す。
            foreach (var item in query)    // (*2)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
