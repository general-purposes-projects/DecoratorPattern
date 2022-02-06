namespace DecoratorPattern.BikeDecorator
{
    public class WolfDecoratorBike: BikeDecorator
    {
        public WolfDecoratorBike(IBike bike) : base(bike)
        {
        }

        public override string BuildBike(Bike bike)
        {
            bike.Color = "Wolf Stylus";
            return base.BuildBike(bike);
        }
    }
}