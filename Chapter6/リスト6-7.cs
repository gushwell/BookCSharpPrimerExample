using System.Diagnostics;

namespace InterfaceSample {
    class Program {
        static void Main(string[] args) {
        }
    }

    public interface ICommand {
        int Execute(params object[] args);
    }


    public class MyCommand : ICommand {
        public int Execute(params object[] args) {
            Process p = new Process();
            p.StartInfo.FileName = "NotePad.exe";
            p.StartInfo.Arguments = args[0] as string;
            p.Start();
            p.WaitForExit();
            return p.ExitCode;
        }
    }

}
