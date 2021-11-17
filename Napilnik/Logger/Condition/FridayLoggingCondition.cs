using System;

namespace Napilnik
{
    class FridayLoggingCondition : ILoggingCondition
    {
        public bool CanLog() => DateTime.Now.DayOfWeek == DayOfWeek.Friday;
    }
}
