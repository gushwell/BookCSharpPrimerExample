using System;

namespace StaticSample2 {
    class Program {
        static void Main(string[] args) {
            SampleClass h1 = new SampleClass();
            SampleClass h2 = new SampleClass();
            SampleClass h3 = new SampleClass();
            Console.WriteLine(SampleClass.InstanceCount);  // 「3」が出力される
            Console.ReadLine();
        }
    }

    class SampleClass {
        private static int instanceCount = 0;
        public SampleClass() {
            instanceCount++;
        }

        // 静的なプロパティを定義
        public static int InstanceCount {
            get {
                return instanceCount;
            }
        }
    }

}
