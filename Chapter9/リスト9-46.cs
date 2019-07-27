
// ビルドするには、参照設定でEnumDisplay.dll を追加します。
// EnumDisplay.dllは、List9-47のファイルで示したコードをビルドして作成します。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gushwell.Sample;

namespace EnumDisplaySample {
    class Program {
        static void Main(string[] args) {
            Gender g1 = Gender.Male;
            Gender g2 = Gender.Female;
            Console.WriteLine(g1.GetName());   // "男性"が表示される
            Console.WriteLine(g2.GetName());   // "女性"が表示される

            Console.ReadLine();
        }
    }

    public enum Gender {
        [EnumDisplay("男性")]
        Male,
        [EnumDisplay("女性")]
        Female
    }
}
