using System;
using System.IO;

namespace Gushwell.Sample {
    class Class1 {
        static void Main(string[] args) {
            FileSystemWatcher fsw = new FileSystemWatcher(@"C:\temp");
            fsw.Created += new FileSystemEventHandler(fsw_Created);
            fsw.EnableRaisingEvents = true;
            Console.ReadLine();
        }

        // Createdイベントが発生した時に呼び出されるイベント・ハンドラ
        private static void fsw_Created(object sender,
                                          FileSystemEventArgs e) {
            Console.WriteLine(e.FullPath + "が作成されました");
        }
    }
}
