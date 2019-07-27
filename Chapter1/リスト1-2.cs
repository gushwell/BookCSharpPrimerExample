using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeetToMeter {
    class Program {
        static void Main(string[] args) {
            // フィート と メートルの対応表を作成
            // 1フィートは 30.48 センチメートル
            for (int feet = 1; feet <= 20; feet++) {
                double meter = feet * 0.3048;
                Console.WriteLine("{0,2}ft : {1:f4}m", feet, meter);
            }
            Console.ReadLine();
        }
    }
}
