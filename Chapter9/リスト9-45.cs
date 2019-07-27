// このソースは、クラスライブラリとして作成したプロジェクトの一部となります。
// プロジェクト名は、EnumDisplay とします。
//
// 最終的には、EnumDisplayExtentions クラスが、このファイルに追加されます。


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class EnumDisplayAttribute : Attribute {
        public string Name { get; private set; }
        public EnumDisplayAttribute(string name) {
            Name = name;
        }
    }

}
