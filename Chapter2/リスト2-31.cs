using System;

namespace Gushwell.Sample {
    public struct Person {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public DateTime Birthday { get; set; }
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
