namespace DecoratorPattern.LoggerExample
{
    public interface ILogger
    {
        public void LogOperation(Log log);
        public Log GetLogOperation(string name);
    }
}