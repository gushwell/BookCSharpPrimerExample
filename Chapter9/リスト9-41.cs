/*
 * このプログラムを実際に動かすには、プロジェクトを新規作成する際に、
 * クラスライブラリのテンプレートを選択し、プロジェクトを作成します。
 * プロジェクト名は、「SampleLib」としてください。
 * プロジェクトには、Class1.csが作成されますので、このファイルのコードを
 * 以下のコードと完全に置き換えてください。
 *
 * Clas1.csという名前は変更可能です。通常は、クラス名と同じ名前にします。
 * ソリューションエクスプローラで、Class1.cs を選択し、F2キーを押すと
 * 変更モードになりますので、Foo.cs に変更します。
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample {
    public class Foo {
        public string DoSomething(int n) {
            return Enumerable.Range(1, n).Sum().ToString("#,0");
        }
    }
}

