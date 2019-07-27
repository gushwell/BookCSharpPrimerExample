using System;

namespace Gushwell.Sample {
    class Person {
        public string name;
        public double weight;
        public int height;
        public DateTime birthday;

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
