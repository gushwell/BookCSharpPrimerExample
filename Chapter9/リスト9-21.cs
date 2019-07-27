using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_21 {
    class Program {
        static void Main(string[] args) {
            string[] names = { "Microsoft", "Apple", "IBM", "Google", "HP", "Dell" };
            var query = from s in names
                        where s.Length > 5
                        orderby s
                        select s;
            var result = query.ToList();  // ここでクエリを実行して、Listに変換
            // 1回目の出力
            foreach (string item in result)
                Console.WriteLine(item);
            Console.WriteLine("------");

            names[1] = "Oracle";
            // 2回目の出力
            foreach (string item in result)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
