using System;

namespace Gushwell.Sample {
    class Program {
        static void Main() {
            Person p = new Person {
                Name = "檜山玄太郎",
                Weight = 89,
                Height = 188,
                Birthday = new DateTime(1979, 5, 25)
            };
            int age = p.GetAge();
            Console.WriteLine("{0} {1:f2}", age, p.GetBmi());
            Console.ReadLine();
        }
    }

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
