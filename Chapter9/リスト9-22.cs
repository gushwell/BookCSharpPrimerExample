using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSample {
    public class Book {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public int Price { get; set; }
        public BookCategory Category { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
    }

    public enum BookCategory {
        Science,
        History,
        Business,
        Novel,
        Nonfiction,
        Health,
    }

    class Program {
        static void Main(string[] args) {
            List<Book> books = new List<Book>();
            books.Add(new Book {
                Name = "ロングテール",
                Author = "クリス アンダーソン",
                Category = BookCategory.Business,
                PublishedYear = 2009,
                Price = 1470,
                Isbn = "978-4153200043"
            });

            books.Add(new Book {
                Name = "計算理論の基礎",
                Author = "マイケル シプサ",
                Category = BookCategory.Science,
                PublishedYear = 2000,
                Price = 8085,
                Isbn = "978-4320029484"
            });

            books.Add(new Book {
                Name = "ゲーデル、エッシャー、バッハ",
                Author = "ダグラス・R. ホフスタッター",
                Category = BookCategory.Science,
                PublishedYear = 2005,
                Price = 6090,
                Isbn = "978-4826901253"
            });

            books.Add(new Book {
                Name = "フェルマーの最終定理",
                Author = "サイモン シン",
                Category = BookCategory.Science,
                PublishedYear = 2000,
                Price = 2415,
                Isbn = "978-4105393014"
            });

            Test1(books);
            Console.WriteLine();
            Test2(books);
            Console.WriteLine();
            Test3(books);
            Console.WriteLine();
            Test4(books);
            Console.WriteLine();
            Test5(books);
            Console.ReadLine();
        }

        private static void Test1(List<Book> books) {
            var query = from book in books
                        select book.Name;
            foreach (var name in query)
                Console.WriteLine(name);
        }

        private static void Test2(List<Book> books) {
            var query = from book in books
                        select new { book.Isbn, book.Name };
            foreach (var b in query)
                Console.WriteLine("{0} {1}", b.Isbn, b.Name);
        }

        private static void Test3(List<Book> books) {
            var query = from book in books
                        where book.Price >= 5000
                        select new { book.Name, NewPrice = book.Price * 0.8 };
            foreach (var b in query)
                Console.WriteLine("{0} {1}", b.Name, b.NewPrice);
        }

        private static void Test4(List<Book> books) {
            var query = from book in books
                        where book.Category == BookCategory.Science
                        select new { book.Name, book.Author, book.PublishedYear };
            foreach (var b in query)
                Console.WriteLine("{0} {1} {2}", b.Name, b.Author, b.PublishedYear);
        }

        private static void Test5(List<Book> books) {
            var query = books.Where(book => book.Category == BookCategory.Science)
                             .Select(book => new {
                                  book.Name,
                                  book.Author,
                                  book.PublishedYear
                              });
            foreach (var b in query)
                Console.WriteLine("{0} {1} {2}", b.Name, b.Author, b.PublishedYear);
        }
    }
}
