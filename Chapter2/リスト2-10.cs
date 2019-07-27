using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            Person p = new Person {
                name = "小林知典",
                weight = 68,
                height = 176,
                birthday = new DateTime(1976, 6, 13)
            };
            int age = p.GetAge();  // (*)メソッドの呼び出し
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }


    // 実際の開発では、ユーザが定義したクラスは、別のファイルに定義しておくのが
    // 一般的です。このときのファイル名は、「クラス名.cs」とします。
    // この例では、Person.cs ファイルに、Personクラスを定義します。
    // Visual Studio での操作方法は、当ファイルと同梱した
    // 「プロジェクトにクラスファイルを追加する方法.pdf」をご覧ください。
    class Person {
        public string name;
        public double weight;
        public int height;
        public DateTime birthday;

        // GetAgeメソッドの定義
        public int GetAge() {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            // 誕生日前ならば -1 する。
            if (today.Month < birthday.Month)
                age--;
            else if (today.Month == birthday.Month &&
                         today.Day < birthday.Day)
                age--;
            return age;
        }
    }

}
