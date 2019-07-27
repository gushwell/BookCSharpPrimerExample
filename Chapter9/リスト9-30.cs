// NorthwindObjects.csを同一プロジェクトに追加してビルドしてください

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindObject;

namespace List9_30 {
    class Program {
        static void Main(string[] args) {
            var products = NorthwindObjects.GetProducts();
            bool b = products.Any(p => p.UnitsInStock == 0);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}