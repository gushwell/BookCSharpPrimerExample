using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_8 {
    class Program {
        static void Main(string[] args) {
            Directions ds1 = Directions.Fore;
            Console.WriteLine(ds1.ToString());
            Directions ds2 = Directions.Left | Directions.Back;
            Console.WriteLine(ds2.ToString());
            Console.ReadLine();
        }
    }

    [Flags]
    enum Directions {  // 異動可能な方向を表わす
        Right = 1,
        Left = 2,
        Fore = 4,
        Back = 8,
        All = Right | Left | Fore | Back,
        None = 0,
    }

}
