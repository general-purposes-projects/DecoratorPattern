using System;

namespace DecoratorPattern.LoggerExample
{
    public class LoggerWithInnerException: LoggerDecorator
    {
        public LoggerWithInnerException(ILogger logger) : base(logger)
        {   
        }
        public override void LogOperation(Log log)
        {
            Console.WriteLine("StackTrace Logger!");
            if (log.LogDescription is Exception exception)
            {
                Exception result = new Exception( exception.Message + "\n" + 
                                exception.InnerException?.Message);
                log.LogDescription = result;
            }
            base.LogOperation(log);
        }

        public override Log GetLogOperation(string name)
        {
            Console.WriteLine("I'm here.");
            return base.GetLogOperation(name);
        }

    }
}