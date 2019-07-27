// NorthwindObjects.csを同一プロジェクトに追加してビルドしてください

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindObject;

namespace List9_26 {
    class Program {
        static void Main(string[] args) {
            // メソッド構文
            {
                var products = NorthwindObjects.GetProducts();
                var result = products.OrderBy(p => p.UnitPrice)
                                     .Take(10);
                foreach (var p in result)
                    Console.WriteLine("{0} : {1}", p.ProductName, p.UnitPrice);
            }
            Console.WriteLine();
            // クエリ構文
            {
                var products = NorthwindObjects.GetProducts();
                var query = (from p in products
                             orderby p.UnitPrice
                             select new { p.ProductName, p.UnitPrice }
                            ).Take(10);
                foreach (var p in query)
                    Console.WriteLine("{0} : {1}", p.ProductName, p.UnitPrice);
            }
            Console.ReadLine();
        }
    }
}
