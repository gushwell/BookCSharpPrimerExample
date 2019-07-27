using System;


namespace StaticSample {
    class Program {
        static void Main() {
            Console.Write("ヤード ->");
            string s = Console.ReadLine();
            double yard = double.Parse(s);
            double meter = YardToMeter(yard);  // 静的メソッドの呼び出し 
            Console.WriteLine("{0}ヤードは{1}メートルです。", yard, meter);
            Console.ReadLine();
        }

        // 静的メソッドとして定義
        static double YardToMeter(double yd) {
            double meter = yd * 0.9144;
            return meter;
        }
    }
}
