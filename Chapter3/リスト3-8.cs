using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceSample1 {
    class Program {
        static void Main(string[] args) {
            Person p = new Person();
            p.Name = "太田秀行";
            p.Age = 28;
            Console.WriteLine(p.Format());
            Console.ReadLine();
        }
    }

    public class Person {
        private string _name;
        private int _age;
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public int Age {
            get { return _age; }
            set { _age = value; }
        }
        public string Format() {
            return string.Format("{0}({1})", Name, Age);
        }
    }
}
