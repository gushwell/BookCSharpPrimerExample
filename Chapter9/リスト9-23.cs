using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_23 {
    class Program {
        static void Main(string[] args) {
            string[] names = {
                "Microsoft", "Apple", "Oracle", "IBM", "Google", "Adobe",
            };

            // メソッド構文
            var query1 = names.Where(s => s.Length > 3)
                              .OrderBy(s => s)
                              .Select(s => s);

            // クエリ構文
            var query2 = from s in names
                         where s.Length > 3
                         orderby s
                         select s;

            foreach (var s in query1)
                Console.WriteLine(s);
            Console.WriteLine();
            foreach (var s in query2)
                Console.WriteLine(s);
        }
    }
}
