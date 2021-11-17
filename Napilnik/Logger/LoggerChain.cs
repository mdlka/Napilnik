using System;
using System.Collections.Generic;

namespace Napilnik
{
    class LoggerChain : ILogger
    {
        private IEnumerable<ILogger> _loggers;

        private LoggerChain(IEnumerable<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public void Log(string message)
        {
            foreach (var logger in _loggers)
                logger.Log(message);
        }

        public static LoggerChain Create(params ILogger[] loggers)
        {
            if (loggers == null)
                throw new ArgumentNullException(nameof(loggers));

            return new LoggerChain(loggers);
        }
    }
}
