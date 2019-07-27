using System;
using System.IO;

namespace Sample {
    class Program {
        static void Main(string[] args) {
            NumericsPicker np = new NumericsPicker("Sample.txt");
            string line = np.GetNext();
            while (line != null) {
                Console.WriteLine(line);
                line = np.GetNext();
            }
            Console.ReadLine();
        }
    }

    class NumericsPicker {
        private StreamReader reader;
        public NumericsPicker(string filepath) {
            reader = new StreamReader(filepath);
        }

        private bool IsAllDigits(string line) {
            foreach (var c in line) {
                if (!char.IsDigit(c))  // '0'-'9'までの文字でないなら false
                    return false;
            }
            return true;
        }

        public string GetNext() {
            string line = reader.ReadLine();
            while (line != null && !IsAllDigits(line))
                line = reader.ReadLine();
            return line;
        }
    }
}
