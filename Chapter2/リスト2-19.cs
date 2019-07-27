using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    class Program {
        static void Main(string[] args) {
            Person p = new Person("檜山玄太郎", new DateTime(1979, 5, 25));
            p.Height = 173;                        // プロパティに代入
            Console.WriteLine(p.Height);           // プロパティを参照
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
        public DateTime birthday;
        public double weight;
        private int height;

        // Height プロパティの定義
        public int Height {
            get {
                return height;
            }
            set {
                if (value > 50)
                    height = value;
            }
        }

        // コンストラクタの定義 (クラスメイト同じ名前にする)
        public Person(string name, DateTime birthday) {
            this.name = name;
            this.birthday = birthday;
        }
        // 引数なしコンストラクタの定義
        public Person() {
            // なんらかの初期設定
            this.name = "(無題)";
        }


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
