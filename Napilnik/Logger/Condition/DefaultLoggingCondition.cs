namespace Napilnik
{
    public class DefaultLoggingCondition : ILoggingCondition
    {
        public bool CanLog() => true;
    }
}
