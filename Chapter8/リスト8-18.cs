using System;
using System.Collections.Generic;
using System.Text;

namespace Gushwell.Sample {
    public class Book {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public Book(string name, string author, string publisher, string isbn) {
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
            this.ISBN = isbn;
        }
    }

    public class BookList {
        private List<Book> books = new List<Book>();
        public void Add(Book book) {
            books.Add(book);
        }

        // インデクサの定義
        public Book this[int index] {
            get {
                return books[index];
            }
        }
        public Book this[string ISBN] {
            get {
                foreach (Book b in books)
                    if (b.ISBN == ISBN)
                        return b;
                return null;
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            BookList books = new BookList();
            books.Add(new Book("こころ", "夏目漱石",
                                       "新潮社", "978-4101010137"));
            books.Add(new Book("人間失格", "太宰治",
                                       "角川書店", "978-4041099124"));
            Book book1 = books[0];
            Console.WriteLine(book1.Name);
            Book book2 = books["978-4041099124"];
            Console.WriteLine(book2.Name);
            Console.ReadLine();
        }
    }
}
