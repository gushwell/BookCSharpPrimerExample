using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace List9_44 {
    class Program {
        [DllImport("user32.dll", EntryPoint = "MessageBoxW", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text,
                                                            string caption, uint type);

        static void Main(string[] args) {
            MessageBox(new IntPtr(0), "Hello World", "DllImport Sample", 0);
        }
    }
}
