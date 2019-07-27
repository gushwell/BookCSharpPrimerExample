using System;

namespace Gushwell.Sample {

    class Program {
        static void Main(string[] args) {
            Point point = new Point {
                X = 10,
                Y = 20
            };
            Console.WriteLine(point.ToString());   // (*)
            Console.ReadLine();
        }
    }

    public class Point {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() {
            return string.Format("({0},{1})", X, Y);
        }
    }

}