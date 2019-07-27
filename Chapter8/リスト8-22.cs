using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_22 {
    class Program {
        static void Main(string[] args) {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("abc");
            stack.Push("xyz");
            string s1 = stack.Pop();
            Console.WriteLine(s1);
            string s2 = stack.Pop();
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }

    public class MyStack<T> {
        private int size = 0;
        private readonly int MaxSize = 100;
        private T[] items;
        public MyStack() {
            items = new T[MaxSize];
        }
        public void Push(T x) {
            items[size++] = x;
        }
        public T Pop() {
            return items[--size];
        }
    }

}
