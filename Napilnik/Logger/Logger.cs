using System;

namespace Napilnik
{
    abstract class Logger : ILogger
    {
        private readonly ILoggingCondition _loggingCondition;

        public Logger(ILoggingCondition loggingCondition)
        {
            if (loggingCondition == null)
                throw new ArgumentNullException(nameof(loggingCondition));

            _loggingCondition = loggingCondition;
        }

        public abstract void Log(string message);

        protected bool CanLog() => _loggingCondition.CanLog();
    }
}
