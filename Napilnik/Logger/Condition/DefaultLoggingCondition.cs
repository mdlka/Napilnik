namespace Napilnik
{
    class DefaultLoggingCondition : ILoggingCondition
    {
        public bool CanLog() => true;
    }
}
