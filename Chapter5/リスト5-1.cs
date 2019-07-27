using System;
using System.Collections.Generic;

namespace ListSample {
    public class Book {
        private string name;
        public Book(string name) {
            this.name = name;
        }
        public string Name {
            get { return name; }
        }
    }

    class Program {
        static void Main(string[] args) {
            List<Book> list = new List<Book>();
            // 「List<T>」に要素を追加する
            Book mybook = new Book("伊豆の踊子");
            list.Add(mybook);
            list.Add(new Book("吾輩は猫である"));
            list.Add(new Book("銀河鉄道の夜"));

            //「List<T>」から要素を取り出す
            Console.WriteLine(list[0].Name); // 0番目の要素を取り出す
            Console.WriteLine();

            //すべての要素を取り出す
            for (int i = 0; i < list.Count; i++) {
                Book book = list[i];
                Console.WriteLine(book.Name);
            }
            Console.WriteLine();

            // Insertメソッド
            list.Insert(2, new Book("走れメロス"));

            // IndexOfメソッド
            int index = list.IndexOf(mybook);
            Console.WriteLine(index);

            //Removeメソッド
            list.Remove(mybook);    // 伊豆の踊子を削除

            //RemoveAtメソッド
            list.RemoveAt(2);   // 2番目の要素を削除
            foreach (Book book in list) {
                Console.WriteLine(book.Name);
            }
            Console.WriteLine();

            // Clearメソッド
            list.Clear();    // すべての要素をList<Book>から削除
            Console.WriteLine(list.Count);

            Console.ReadLine();

        }
    }
}


     