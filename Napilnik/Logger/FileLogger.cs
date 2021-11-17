using System.IO;

namespace Napilnik
{
    class FileLogger : Logger
    {
        public FileLogger(ILoggingCondition loggingCondition) : base(loggingCondition) { }

        public override void Log(string message)
        {
            if (CanLog())
                File.WriteAllText("log.txt", message);
        }
    }
}
