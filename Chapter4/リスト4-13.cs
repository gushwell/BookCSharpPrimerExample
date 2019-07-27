using System;

namespace ValueType {

    class Program {
        static void Main(string[] args) {
            MyData obj = new MyData();
            obj.x = 10;
            Test(obj);
            Console.WriteLine(obj.x);
            Console.ReadLine();
        }

        static void Test(MyData obj) {
            obj.x = 123;
        }
    }

    class MyData {
        public int x { get; set; }
    }

    //struct MyData {
    //    public int x { get; set; }
    //}
}
