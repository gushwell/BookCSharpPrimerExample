using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_21 {
    class Program {
        static void Main(string[] args) {
            MyStack stack = new MyStack();
            stack.Push("abc");
            stack.Push("xyz");
            string s1 = (string)stack.Pop();
            Console.WriteLine(s1);
            string s2 = (string)stack.Pop();
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }

    public class MyStack {
        private int size = 0;
        private readonly int MaxSize = 100;
        private object[] items;
        public MyStack() {
            items = new object[MaxSize];
        }
        public void Push(object x) {
            items[size++] = x;
        }
        public object Pop() {
            return items[--size];
        }
    }

}
