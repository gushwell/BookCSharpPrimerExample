using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace List7_12 {
    class Program {
        static void Main(string[] args) {
            using (StreamReader sr = new StreamReader("TestFile.txt")) {
                String line;
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
