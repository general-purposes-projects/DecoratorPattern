using System;
using System.Reflection.Metadata.Ecma335;
using DecoratorPattern.BikeDecorator;
using DecoratorPattern.LoggerExample;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // LoggerClient loggerClient = new LoggerClient();
            // loggerClient.DoClientStuff();
            BikeClient client = new BikeClient();
            client.doBike();
        }
    }

    public class LoggerClient
    {
        public void DoClientStuff()
        {
            ILogger logger = new Logger();
            Log log = new Log {Name = "Tired Error", LogDescription = new Exception("I'm too tired to keep coding",innerException: new Exception("Need some sleep!"))};
            LoggerDecorator loggerDecorator = new LoggerDecorator(logger);
            loggerDecorator.LogOperation(log);
            LoggerWithInnerException loggerWithInnerException = new LoggerWithInnerException(logger);
            loggerWithInnerException.LogOperation(log);   
        }
    }

    public class BikeClient
    {
        public void doBike(){
            IBike bike = new Bike();
            Bike clientSpecifications = new Bike
            {
                WheelHeight = 24
            };
            
            bike = new CrossOverBike(bike);
            
            bike = new WolfDecoratorBike(bike);

            BikeBuilder builder = new BikeBuilder(bike);
            
            builder.BuildBike(clientSpecifications);
        }
    }
    
}