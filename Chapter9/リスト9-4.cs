using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_4 {
    class Program {
        static void Main(string[] args) {
            EnumSample sample = new EnumSample();
            foreach (int num in sample)  // sampleオブジェクトから要素を列挙する
                Console.Write("{0} ", num);
            Console.ReadLine();
        }
    }

    public class EnumSample {
        public IEnumerator<int> GetEnumerator() {
            for (int i = 0; i <= 10; i += 2) {
                yield return i;
            }
        }
    }
}
