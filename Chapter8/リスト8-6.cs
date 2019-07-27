using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// System.Windows.Forms を参照設定する

namespace List8_6 {
    class Program {
        static void Main(string[] args) {
            FontStyle fs = FontStyle.Bold | FontStyle.Italic;
            fs |= FontStyle.Underline;
            fs &= ~FontStyle.Bold;
            if ((fs & FontStyle.Italic) == FontStyle.Italic)
                MessageBox.Show("イタリック体です");
            if ((fs & FontStyle.Bold) == FontStyle.Bold)
                MessageBox.Show("ボールド体です");
            Console.ReadLine();
        }
    }

    [Flags]
    public enum FontStyle {
        Regular = 0,      // どのビットもオフならばRegular
        Bold = 1,         // 1ビット目が1なら Bold
        Italic = 2,       // 2ビット目が1なら Italic
        Underline = 4,    // 3ビット目が1なら Underline
        Strikeout = 8,    // 4ビット目が1なら Strikeout
    }
}
