using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            Person p = new Person();
            p.Name = "半田義典";
            p.Age = 25;
            Console.WriteLine("{0}は、{1}歳です", p.Name, p.Age);
            Console.ReadLine();
        }
    }
    
    // 実際の開発では、ユーザが定義したクラスは、別のファイルに定義しておくのが
    // 一般的です。このときのファイル名は、「クラス名.cs」とします。
    // この例では、Person.cs ファイルに、Personクラスを定義します。
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

}
