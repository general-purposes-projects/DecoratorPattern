using System;
using System.Collections.Generic;

namespace DecoratorPattern.LoggerExample
{
    public class Logger: ILogger
    {
        private readonly List<Log> _log;

        public Logger()
        {
            _log = new List<Log>();
        }

        public void LogOperation(Log log)
        {
            Console.WriteLine("I'm the logger");
            _log.Add(log);   
            _log.ForEach(l=>Console.WriteLine(l.LogDescription));
        }

        public Log GetLogOperation(string name)
        {
            return _log.Find(c => c.Name == name);
        }
    }
}