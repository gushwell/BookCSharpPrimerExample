using System;

namespace Gushwell.Sample {
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
        public DateTime Birthday { get; private set; }

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
