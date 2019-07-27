using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace List7_10 {
    class Program {
        static void Main(string[] args) {
            StreamReader sr = new StreamReader("TestFile.txt");
            try {
                String line;
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            } finally {
                sr.Dispose();
            }
        }
    }
}
