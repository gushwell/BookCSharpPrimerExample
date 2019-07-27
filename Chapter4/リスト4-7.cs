using System;

namespace CastSample {
    class Program {
        static void Main(string[] args) {
            object obj = new NoteBook();
            bool b1 = obj is NoteBook;
            bool b2 = obj is object;
            bool b3 = obj is Magazine;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.ReadLine();

        }
    }

    class NoteBook { }

    class Magazine { }
}
