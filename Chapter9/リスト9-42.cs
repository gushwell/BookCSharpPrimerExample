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

namespace List9_42 {
    class Program {
        static void Main() {
            var asm = Assembly.LoadFrom("SampleLib.dll");
            Type type = asm.GetType("Sample.Foo", true);
            object obj = Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("DoSomething");
            object[] args = new object[] { 10 };   // 書籍では、2でしたが、10に変更しています。
            object result = mi.Invoke(obj, args);
            Console.WriteLine((string)result);

            Console.ReadLine();
        }
    }
}
