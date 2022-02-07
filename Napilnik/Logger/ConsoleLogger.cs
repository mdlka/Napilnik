using System;

namespace Napilnik
{
    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(ILoggingCondition loggingCondition) : base(loggingCondition) { }

        protected override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
