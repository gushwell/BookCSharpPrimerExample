using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample1 {
    class Program {
        static void Main(string[] args) {
            Person p = new Person();
            p.Name = "太田秀行";
            p.Age = 28;
            Console.WriteLine(p.Format());

            Employee emp = new Employee();
            emp.Name = "清水はるか";
            emp.Age = 26;
            emp.DeptName = "第一営業部";
            Console.WriteLine(emp.Format());

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
        public virtual string Format() {
            return string.Format("{0}({1})", Name, Age);
        }
    }

    public class Employee : Person {
        private int id;
        private string deptName;
        public int ID {
            get { return id; }
            set { id = value; }
        }
        public string DeptName {
            get { return deptName; }
            set { deptName = value; }
        }
        public override string Format() {
            return string.Format("{0}({1}) {2}", Name, Age, DeptName);
        }
    }
}
