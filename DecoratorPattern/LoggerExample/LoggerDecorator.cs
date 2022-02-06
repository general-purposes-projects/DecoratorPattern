using System;

namespace DecoratorPattern.LoggerExample
{
    public class LoggerDecorator : ILogger
    {
        private readonly ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void LogOperation(Log log)
        {
            Log newLog = new Log();
            Console.WriteLine("Base Decorator.");

            if (_logger is null)
            {
                return;
            }
            newLog.Name = log.Name;
            newLog.LogDescription = log.LogDescription is Exception exception? 
                exception.Message: log.LogDescription; 
            
            _logger.LogOperation(newLog);
        }

        public virtual Log GetLogOperation(string name)
        {
            return _logger?.GetLogOperation(name);
        }
    }
}