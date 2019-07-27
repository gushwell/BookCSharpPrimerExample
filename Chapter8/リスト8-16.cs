using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List8_16 {
    class Program {
        static void Main(string[] args) {
            ArrayBit data = new ArrayBit(5);
            uint bit = data.GetBit(0);             // 0ビット目を取り出す
            Console.WriteLine(bit);                // 1が表示される
            data.SetBit(3, 1);                     // 3ビット目に1を設定する
            Console.WriteLine(data.UIntValue);     // 13が表示される

            Console.ReadLine();

        }
    }

    public class ArrayBit {
        public uint UIntValue { get; private set; }
        public ArrayBit(uint val) {
            UIntValue = val;
        }
        public uint GetBit(int index) {
            return (UIntValue >> index) & 0x1;
        }

        public void SetBit(int index, uint value) {
            if (value == 0)
                UIntValue &= (uint)(~(1 << index));
            else
                UIntValue |= (uint)(1 << index);
        }
    }

}
