using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace List8_10 {
    class Program {
        static void Main(string[] args) {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (var i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }
            foreach (var n in nums) {
                Console.WriteLine(n);
            }
            using (var file = new StreamReader("sample.txt")) {
                string line = file.ReadLine();
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
