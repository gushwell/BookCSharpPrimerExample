/* このコンソールアプリケーションは、SampleLib.dll を動的に読み込み、
 * SampleLib.dllに含まれる Fooクラスのインスタンスを生成し、
 * DoSOmethingメソッドを呼び出します。
 * 
 * 実行には、SampleLib.dllが必要です。このプログラムの実行ファイルと同じ
 * フォルダに、SampleLiob.dllをコピーしてから実行してください。
 * 
 * デバッグ実行したいならば、bin/Debugフォルダにコピーしてから
 * デバッグ実行してください。
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace List9_43 {
    class Program {
        static void Main() {
            var asm = Assembly.LoadFrom("SampleLib.dll");
            Type type = asm.GetType("Sample.Foo", true);
            dynamic obj = (dynamic)Activator.CreateInstance(type);
            string result = obj.DoSomething(10);   // 書籍では、2でしたが、10に変更しています。
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
