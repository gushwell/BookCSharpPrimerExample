using System;
using System.IO;
using System.Diagnostics;

namespace LogWriterSample {
    public abstract class LogWriter {
        public virtual void Write(string format, params object[] args) {
            string msg = string.Format(format, args);
            Write(msg);  // (*)
        }
        public abstract void Write(string arg);
    }

    // コンソールへの出力用
    public class ConsoleLogWriter : LogWriter {
        public override void Write(string arg) {
            Console.WriteLine(arg);
        }
    }

    // テキスト・ファイルへの出力用
    public class PlainTextLogWriter : LogWriter {
        public override void Write(string arg) {
            using (StreamWriter tw = new StreamWriter("Debug.log", true)) {
                tw.WriteLine(arg);
            }
        }
    }

    // イベント・ファイルへの出力用
    public class EventLogLogWriter : LogWriter {
        public override void Write(string arg) {
            EventLog.WriteEntry("Sample", arg, EventLogEntryType.Error);
        }
    }


    // Factoryクラス
    public static class LoggerFactory {
        private static LogWriter logWriter = new ConsoleLogWriter();
        public static LogWriter Create() {
            return logWriter;
        }
    }

}
