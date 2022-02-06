using System.Runtime.Serialization.Json;

namespace DecoratorPattern.BikeDecorator
{
    public class CrossOverBike: BikeDecorator
    {
        public CrossOverBike(IBike bike) : base(bike)
        {
        }

        public override string BuildBike(Bike bike)
        {
            bike.Type = "CrossOver";
            bike.WheelHeight = 24;
            return base.BuildBike(bike);
        }
    }
}