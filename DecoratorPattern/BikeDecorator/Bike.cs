namespace DecoratorPattern.BikeDecorator
{
    public class Bike: IBike
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int WheelHeight { get; set; }
        
        private readonly Bike _bike;
        public string BuildBike(Bike bike)
        {
            Color = bike.Color;
            Type = bike.Type;
            WheelHeight = bike.WheelHeight;
            return $"Bike built type: { bike.Type } " +
                   $"color: { bike.Color } " +
                   $"WheelHeight: { bike.WheelHeight }";
        }
    }
}