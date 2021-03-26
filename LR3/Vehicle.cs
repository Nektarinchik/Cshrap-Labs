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
        public Сolors Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public EngineTypes EngineType
        {
            get
            {
                return engineType;
            }
            set
            {
                engineType = value;
            }
        }
        public FuelTypes FuelType
        {
            get
            {
                return fuelType;
            }
            set
            {
                fuelType = value;
            }
        }
        public double EngineCapacity
        {
            get
            {
                return engineСapacity;
            }
            set
            {
                engineСapacity = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public double FuelСonsumption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                fuelConsumption = value;
            }
        }
        public int SeatsAmount
        {
            get
            {
                return seatsAmount;
            }
            set
            {
                seatsAmount = value;
            }
        }
        public int YearOfRelease
        {
            get
            {
                return yearOfRelease;
            }
            set
            {
                yearOfRelease = value;
            }
        }

        private Сolors color;
        private EngineTypes engineType;
        private FuelTypes fuelType;
        private double engineСapacity;
        private double fuelConsumption;
        private int weight;
        private int seatsAmount;
        private int yearOfRelease;
    }
}
