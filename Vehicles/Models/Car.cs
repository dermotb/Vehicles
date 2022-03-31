namespace Vehicles.Models
{
    public enum CarEngineType { Petrol, Diesel, Hybrid, EV};

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public CarEngineType EngineType { get; set; }
        public int EngineSize { get; set; }
    }
}
