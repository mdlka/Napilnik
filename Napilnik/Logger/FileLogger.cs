using System.IO;

namespace Napilnik
{
    public class FileLogger : Logger
    {
        public FileLogger(ILoggingCondition loggingCondition) : base(loggingCondition) { }

        protected override void Log(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}
