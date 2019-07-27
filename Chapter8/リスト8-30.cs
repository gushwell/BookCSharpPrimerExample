using System;
using System.IO;

namespace EventSample {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            TextFinder tf = new TextFinder(@"C:\temp\test.cs");
            tf.TextFound += new EventHandler<TextFoundEventArgs>(tf_TextFound);
            tf.Execute("public");
            Console.ReadLine();
        }

        static void tf_TextFound(object sender, TextFoundEventArgs e) {
            Console.WriteLine(e.Line);
        }
    }

    public class TextFoundEventArgs : EventArgs {
        public TextFoundEventArgs(string line) {
            Line = line;
        }
        public string Line { get; private set; }
    }

    public class TextFinder {
        private string _filename;
        public event EventHandler<TextFoundEventArgs> TextFound;
        public TextFinder(string filename) {
            _filename = filename;
        }
        protected virtual void OnTextFound(TextFoundEventArgs e) {
            if (TextFound != null) {
                TextFound(this, e);
            }
        }
        public void Execute(string target) {
            using (StreamReader sr = new StreamReader(_filename)) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    if (line.TrimStart().StartsWith(target)) {
                        TextFoundEventArgs e = new TextFoundEventArgs(line);
                        OnTextFound(e);
                    }
                }
            }
        }
    }
}
