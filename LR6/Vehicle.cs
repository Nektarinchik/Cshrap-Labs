using System;

namespace Transport
{
    abstract public class Vehicle
    {
        public Vehicle(Сolors color, EngineTypes engineType, FuelTypes fuelType,
        double engineCapacity, int weight, double fuelСonsumption,
        int yearOfRelease, int price)
        {
            this.color = color;
            this.engineType = engineType;
            this.fuelType = fuelType;
            this.engineCapacity = engineCapacity;
            this.weight = weight;
            this.fuelСonsumption = fuelСonsumption;
            this.yearOfRelease = yearOfRelease;
            this.price = price;
        }
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
        public virtual void GetInfo()
        {
            Console.WriteLine($"Color : {color}");
            Console.WriteLine($"Engine type : {engineType}");
            Console.WriteLine($"Fuel type : {fuelType}");
            Console.WriteLine($"Engine capacity : {engineCapacity} liters");
            Console.WriteLine($"Weight : {weight} kg");
            Console.WriteLine($"Fuel consumption : {fuelСonsumption} liters");
            Console.WriteLine($"Year of release : {yearOfRelease}");
            Console.WriteLine($"Price : {price} $");
        }
        public double EngineCapacity
        {
            get
            {
                return engineCapacity;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("invalid engine capacity\n");
                engineCapacity = value;
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
                if (value <= 0)
                    throw new Exception("invalid weight\n");
                weight = value;
            }
        }
        public double FuelСonsumption
        {
            get
            {
                return fuelСonsumption;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("invalid fuel consumption\n");
                fuelСonsumption = value;
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
                if (value <= 0)
                    throw new Exception("invalid year of release\n");
                yearOfRelease = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("invalid price");
                price = value;
            }
        }

        protected double engineCapacity;

        protected int weight;

        protected double fuelСonsumption;

        protected int yearOfRelease;

        protected int price;
    }
}
