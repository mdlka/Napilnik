namespace Napilnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Pathfinder filePathfinder = new Pathfinder(new FileLogger(new DefaultLoggingCondition()));
            filePathfinder.Find();

            Pathfinder consolePathfinder = new Pathfinder(new ConsoleLogger(new DefaultLoggingCondition()));
            consolePathfinder.Find();

            Pathfinder fridayFilePathfinder = new Pathfinder(new FileLogger(new FridayLoggingCondition()));
            fridayFilePathfinder.Find();

            Pathfinder fridayConsolePathfinder = new Pathfinder(new ConsoleLogger(new FridayLoggingCondition()));
            fridayConsolePathfinder.Find();

            LoggerChain loggerChain = LoggerChain.Create(new ConsoleLogger(new DefaultLoggingCondition()), 
                                                         new FileLogger(new FridayLoggingCondition()));
            Pathfinder consoleAndFridayFilePathfinder = new Pathfinder(loggerChain);
            consoleAndFridayFilePathfinder.Find();

        }
    }
}
