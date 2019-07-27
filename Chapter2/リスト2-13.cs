using System;

namespace Sample {
    class Program {
        static void Main(string[] args) {
            DateUtility du = new DateUtility();
            // IsEndOfMonth(DateTime date) を呼び出す
            DateTime date = new DateTime(2011, 5, 30);
            bool eom1 = du.IsEndOfMonth(date);
            Console.WriteLine(eom1 == true ? "月末です" : "月末ではありません");
            // IsEndOfMonth(int year, int month, int day) を呼び出す
            bool eom2 = du.IsEndOfMonth(2011, 2, 28);
            Console.WriteLine(eom2 == true ? "月末です" : "月末ではありません");

            Console.ReadLine();
        }
    }

    class DateUtility {
        public bool IsEndOfMonth(DateTime date) {
            Console.WriteLine("Call IsEndOfMonth(DateTime date)");
            return date.AddDays(1).Day == 1;
        }

        public bool IsEndOfMonth(int year, int month, int day) {
            Console.WriteLine("Call IsEndOfMonth(int year, int month, int day)");
            DateTime date = new DateTime(year, month, day);
            return IsEndOfMonth(date);  // オーバーロードされた別メソッドを呼ぶ
        }
    }
}
