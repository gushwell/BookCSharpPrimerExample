using System;

namespace Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            Person p = new Person {
                name = "小林知典",
                weight = 68,
                height = 176,
                birthday = new DateTime(1976, 6, 13)
            };
            int age = p.GetAge();
            double bmi = p.GetBmi();            
            Console.WriteLine("{0}({1})さんのBMIは、{2:#.00}です",p.name, age, bmi);
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

        public int GetAgeAt(DateTime today) {
            int age = today.Year - birthday.Year;
            if (today.Month < birthday.Month)
                age--;
            else if (today.Month == birthday.Month &&
                     today.Day < birthday.Day)
                age--;
            return age;
        }

        public int GetAge() {
            return GetAgeAt(DateTime.Today);
        }

        public double GetBmi() {
            double mh = height / 100.0;
            return weight / (mh * mh);
        }
    }
}
