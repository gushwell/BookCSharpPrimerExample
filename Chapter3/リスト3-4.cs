using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceSample1 {
    class Program {
        static void Main(string[] args) {
            Employee emp = new Employee();
            emp.ID = 100;
            emp.Name = "山﨑直宏";
            emp.Age = 23;
            emp.DeptName = "第一営業部";
            Console.WriteLine("{0}({1}歳)は、{2}に所属しています。",
                   emp.Name, emp.Age, emp.DeptName);
            Console.ReadLine();
        }
    }

    // 実際の開発では、ユーザが定義したクラスは、別のファイルに定義しておくのが
    // 一般的です。このときのファイル名は、「クラス名.cs」とします。
    // この例では、Person.cs , Employee.csファイルを作成します。
    // Visual Studio での操作方法は、当ファイルと同梱した
    // 「プロジェクトにクラスファイルを追加する方法.pdf」をご覧ください。
    public class Person {
        private string name;
        private int age;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
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
    }

}
