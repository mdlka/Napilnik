using System;

namespace Napilnik
{
    public abstract class Logger : ILogger
    {
        private readonly ILoggingCondition _loggingCondition;

        public Logger(ILoggingCondition loggingCondition)
        {
            if (loggingCondition == null)
                throw new ArgumentNullException(nameof(loggingCondition));

            _loggingCondition = loggingCondition;
        }

        public void TryLog(string message)
        {
            if (_loggingCondition.CanLog())
                Log(message);
        }

        protected abstract void Log(string message);
    }
}
