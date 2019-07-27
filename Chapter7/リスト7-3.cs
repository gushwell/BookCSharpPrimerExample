using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List7_3 {
    class Program {
        static void Main(string[] args) {
            try {
                int[] nums = new int[3];
                nums[3] = 1;
            } catch (System.IndexOutOfRangeException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
