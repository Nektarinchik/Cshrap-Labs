namespace Lab3
{
    public class Vehicle
    {
        public enum Сolors
        {
            blue,
            yellow,
            grey,
            white,
            black,
            brown,
            green,
            red,
            purple,
            pink
        }
        public enum EngineTypes
        {
            internalCombustionEngine,
            electric
        }
        public enum FuelTypes
        {
            gasoline,
            diesel,
            gas,
            battery
        }
        public Сolors color { get; set; }
        public EngineTypes engineType { get; set; }
        public FuelTypes fuelType { get; set; }
        public double engineCapacity { get; set; }
        public int weight { get; set; }
        public double fuelСonsumption { get; set; }
        public int seatsAmount { get; set; }
        public int yearOfRelease { get; set; }
    }
}
