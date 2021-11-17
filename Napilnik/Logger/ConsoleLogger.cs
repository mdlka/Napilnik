using System;

namespace Napilnik
{
    class ConsoleLogger : Logger
    {
        public ConsoleLogger(ILoggingCondition loggingCondition) : base(loggingCondition) { }

        public override void Log(string message)
        {
            if (CanLog())
                Console.WriteLine(message);
        }
    }
}
