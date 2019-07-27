using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            Person p = new Person("檜山玄太郎", new DateTime(1979, 5, 25));
            p.Weight = 72;
            p.Height = 181;
            int age = p.GetAge();
            Console.WriteLine(age);
            Console.WriteLine("{0:f2}", p.GetBmi());  //メソッドの戻り値を直接引数で渡している。

            Console.ReadLine();
        }
    }

    // 実際の開発では、ユーザが定義したクラスは、別のファイルに定義しておくのが
    // 一般的です。このときのファイル名は、「クラス名.cs」とします。
    // この例では、Person.cs ファイルに、Personクラスを定義します。
    // Visual Studio での操作方法は、当ファイルと同梱した
    // 「プロジェクトにクラスファイルを追加する方法.pdf」をご覧ください。
    public class Person {
        public string Name { get; set; }

        public double _weight;
        public double Weight {
            get { return _weight; }
            set {
                if (value > 0)
                    _weight = value;
            }
        }
        public double _height;
        public double Height {
            get { return _height; }
            set {
                if (value > 50)
                    _height = value;
            }
        }
        public DateTime Birthday { get; set; }

        public Person(string name, DateTime birthday) {
            Name = name;
            Birthday = birthday;
        }

        public double GetBmi() {
            double mh = Height / 100.0;
            return Weight / (mh * mh);
        }

        public int GetAge() {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today.Month < Birthday.Month)
                age--;
            else if (today.Month == Birthday.Month &&
                         today.Day < Birthday.Day)
                age--;
            return age;
        }
    }
}
