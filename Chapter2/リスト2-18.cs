using System;

namespace Gushwell.Sample {
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
