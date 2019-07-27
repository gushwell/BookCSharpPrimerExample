using System;
using System.IO;
using System.Diagnostics;

namespace Gushwell.Sample {

    public class LogWriter {
        public virtual void Write(string format, params object[] args) {
            ;
        }
        public virtual void Write(string arg) {
            ;
        }
    }

    public class ConsoleLogWriter : LogWriter {
        public override void Write(string format, params object[] args) {
            string msg = string.Format(format, args);
            Write(msg);
        }
        public override void Write(string arg) {
            Console.WriteLine(arg);
        }
    }

    public class PlainTextLogWriter : LogWriter {
        public override void Write(string format, params object[] args) {
            string msg = string.Format(format, args);
            Write(msg);
        }
        public override void Write(string arg) {
            using (StreamWriter tw = new StreamWriter("Debug.log", true)) {
                tw.WriteLine(arg);
            }
        }
    }

    public class EventLogWriter : LogWriter {
        public override void Write(string format, params object[] args) {
            string msg = string.Format(format, args);
            Write(msg);
        }
        public override void Write(string arg) {
            EventLog.WriteEntry("Sample", arg, EventLogEntryType.Error);
        }
    }

}
