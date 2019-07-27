using System;

namespace Gushwell.Sample {
    class Person {
        public string name;
        public double weight;
        public int height;
        public DateTime birthday;
        // GetAgeメソッドの定義
        public int GetAge() {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            // 誕生日前ならば  -1  する。
            if (today.Month < birthday.Month)
                age--;
            else if (today.Month == birthday.Month &&
            today.Day < birthday.Day)
                age--;
            return age;
        }
    }
}
