using System;

namespace DecoratorPattern.BikeDecorator
{
    public class BikeBuilder
    {
        private readonly IBike _bike;

        public BikeBuilder(IBike bike)
        {
            _bike = bike;
        }

        public void BuildBike(Bike bike)
        {
            Console.WriteLine( _bike.BuildBike(bike));
        }
    }
}