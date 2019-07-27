using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_29 {
    class SampleProgram {
        static void Main(string[] args) {
            TextFinder tf = new TextFinder(@"D:\temp\test.txt");
            tf.TextFound += new TextFoundEventHandler(tf_TextFoundEvent);
            tf.Execute("public");
            Console.ReadLine();
        }

        private static void tf_TextFoundEvent(object sender, TextFoundEventArgs e) {
            Console.WriteLine(e.Line);
        }
    }

}
