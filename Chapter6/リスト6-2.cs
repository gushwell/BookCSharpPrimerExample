using System;
using System.Collections.Generic;

namespace PolySample {
    class Program {
        static void Main(string[] args) {
            List<Programmer> list = new List<Programmer>();
            list.Add(new CSharper());
            list.Add(new Rubyist());
            foreach (Programmer p in list) {
                p.Work();
            }
            Console.ReadLine();
        }
    }

    public abstract class Programmer {
        public abstract void Work();
    }

    public class CSharper : Programmer {
        public override void Work() {
            Console.WriteLine("C#でプログラムを書きます");
        }
    }

    public class Rubyist : Programmer {
        public override void Work() {
            Console.WriteLine("Rubyでプログラムを書きます");
        }
    }
}
