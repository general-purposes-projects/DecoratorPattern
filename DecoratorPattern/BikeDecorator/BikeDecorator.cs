namespace DecoratorPattern.BikeDecorator
{
    public abstract class BikeDecorator: IBike
    {
        private readonly IBike _bike;

        protected BikeDecorator(IBike bike)
        {
            _bike = bike;
        }

        public virtual string BuildBike(Bike bike)
        {
            return _bike.BuildBike(bike);
        }
    }
}