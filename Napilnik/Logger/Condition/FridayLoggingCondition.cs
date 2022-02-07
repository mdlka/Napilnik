using System;

namespace Napilnik
{
    public class FridayLoggingCondition : ILoggingCondition
    {
        public bool CanLog() => DateTime.Now.DayOfWeek == DayOfWeek.Friday;
    }
}
