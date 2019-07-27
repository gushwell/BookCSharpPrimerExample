using System;
using System.IO;

namespace ExceptionSample {
    class Program {
        static void Main(string[] args) {
            try {
                Foo();
            } catch (System.ArgumentException) {
                Console.WriteLine("FooでArgumentException発生");
            }
            try {
                Bar();
            } catch (System.ArgumentException) {
                Console.WriteLine("BarでArgumentException発生");
            }

            Console.ReadLine();
        }

        public static void Foo() {
            try {
                Exec();
            } catch (System.ArgumentException) {
                Console.WriteLine("ExecでArgumentException発生");
            }
            Console.WriteLine("Foo終了");
        }

        public static void Bar() {
            try {
                Exec();
            } catch (System.ArgumentException) {
                Console.WriteLine("ExecでArgumentException発生");
                throw;   // 例外を再スロー
            }
            Console.WriteLine("Bar終了");
        }

        public static void Exec() {
            throw new System.ArgumentException();
        }
    }
}
