using System.Diagnostics;
using System.IO;

namespace InterfaceSample {
    // 本来このインターフェースは定義する必要はない
    public interface IDisposable {
        void Dispose();
    }

    public class MyFileStream : IDisposable {
        private FileStream _stream;
        //...
        //...
        void IDisposable.Dispose() {
            Close();
        }
        public void Close() {
            _stream.Dispose();
            System.GC.SuppressFinalize(this);
        }
    }

}
