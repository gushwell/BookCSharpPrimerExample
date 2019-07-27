using System;
using System.Collections.Generic;

namespace PolySample {
    class Program {
        static void Main(string[] args) {
            List<object> list = new List<object>();
            list.Add(new CSharper());
            list.Add(new Rubyist());
            foreach (object p in list) {
                if (p is CSharper) {
                    (p as CSharper).Work();
                } else if (p is Rubyist) {
                    (p as Rubyist).Work();
                }
            }
            Console.ReadLine();
        }
    }

    public class CSharper {
        public void Work() {
            Console.WriteLine("C#でプログラムを書きます");
        }
    }

    public class Rubyist {
        public void Work() {
            Console.WriteLine("Rubyでプログラムを書きます");
        }
    }
}
