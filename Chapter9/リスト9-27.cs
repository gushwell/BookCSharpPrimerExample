// NorthwindObjects.csを同一プロジェクトに追加してビルドしてください

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindObject;

namespace List9_27 {
    class Program {
        static void Main(string[] args) {
            var products = NorthwindObjects.GetProducts();
            var result = products.OrderBy(p => p.UnitPrice)
                                 .TakeWhile(p => p.UnitPrice < 20);
            foreach (var p in result)
                Console.WriteLine("{0} : {1}", p.ProductName, p.UnitPrice);

            Console.ReadLine();
        }
    }
}