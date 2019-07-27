// NorthwindObjects.csを同一プロジェクトに追加してビルドしてください

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindObject;

namespace List9_25 {
    class Program {
        static void Main(string[] args) {
            var orders = NorthwindObjects.GetOrders();
            var query = orders.Where(o => o.OrderDate.Year >= 1988)
                                           .Select(o => o.CustomerID)
                                           .OrderBy(id => id)
                                           .Distinct();
            foreach (var o in query)
                Console.WriteLine(o.ToString());
            Console.ReadLine();
        }
    }
}
