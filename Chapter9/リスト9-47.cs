// クラスライブラリとしてプロジェクトを作成してください。
// プロジェクト名は、EnumDisplay とします。
// 
// ここで定義したクラスを利用側では、
//   このプロジェクト（EnumDisplay)をビルドしてできたアセンブリを、
//   参照設定に追加してから、ビルドしてください。
//   「List9-46ファイル」にその利用例を示しています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Gushwell.Sample {

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class EnumDisplayAttribute : Attribute {
        public string Name { get; private set; }
        public EnumDisplayAttribute(string name) {
            Name = name;
        }
    }

    public static class EnumDisplayExtentions {
        private static object[] GetAttributes(Enum value) {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            return fi.GetCustomAttributes(typeof(EnumDisplayAttribute), false);
        }

        public static string GetName(this Enum value) {
            object[] attributes = GetAttributes(value);
            if (attributes.Length > 0) {
                EnumDisplayAttribute attr = attributes[0] as EnumDisplayAttribute;
                return attr.Name;
            } else
                return value.ToString();
        }
    }

}
