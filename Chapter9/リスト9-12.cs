using System;
using System.Collections.Generic;
using System.Linq;

namespace List9_12 {
    class Program {
        static void Main(string[] args) {
            var products = new List<Product>();
            products.Add(new Product("M100", 3200, "Mouse"));
            products.Add(new Product("KB2100", 8900, "Keyboard"));

            var query = from prod in products
                        select new { prod.Id, prod.Price };  // プロパティ名を省略
            foreach (var v in query) {
                Console.WriteLine("Id={0}, Price={1}", v.Id, v.Price);
            }
            Console.ReadLine();
        }
    }

    class Product {
        public string Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Product(string id, double price,string name) {
            this.Id = id;
            this.Price = price;
            this.Name = name;
        }
    }
}
