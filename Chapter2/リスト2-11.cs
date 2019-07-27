using System;

namespace Gushwell.Sample {
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
    }
}
