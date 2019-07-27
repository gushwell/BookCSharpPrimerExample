using System;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            Book[] books = new Book[2];
            books[0] = new Book {
                title = "伊豆の踊り子",
                author = "川端康成",
                price = 380,
                publisher = "新潮社"
            };
            books[1] = new Book {
                title = "坊ちゃん",
                author = "夏目漱石",
                price = 378,
                publisher = "岩波書店"
            };
            foreach (Book book in books)
                Console.WriteLine("{0} {1} {2} {3}",
                    book.title, book.author,
                    book.price, book.publisher);
            Console.ReadLine();
        }
    }

    class Book {
        public string title;       // 書籍名
        public string author;      // 著者
        public int price;          // 価格
        public string publisher;   // 出版社
    }
}
