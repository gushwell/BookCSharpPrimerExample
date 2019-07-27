using System;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            Book myBook = new Book {
                title = "伊豆の踊り子",
                author = "川端康成",
                price = 380,
                publisher = "新潮社",
            };

            Console.WriteLine("{0} {1} {2}円 {3}",
                myBook.title, myBook.author,
                myBook.price, myBook.publisher);
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
