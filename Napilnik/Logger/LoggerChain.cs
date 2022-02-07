using System;
using System.Collections.Generic;

namespace Napilnik
{
    public class LoggerChain : ILogger
    {
        private IEnumerable<ILogger> _loggers;

        private LoggerChain(IEnumerable<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public void TryLog(string message)
        {
            foreach (var logger in _loggers)
                logger.TryLog(message);
        }

        public static LoggerChain Create(params ILogger[] loggers)
        {
            if (loggers == null)
                throw new ArgumentNullException(nameof(loggers));

            return new LoggerChain(loggers);
        }
    }
}
