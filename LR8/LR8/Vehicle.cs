using System;

namespace Transport
{
    abstract public class Vehicle
    {
        public Vehicle(Сolors color, EngineTypes engineType, FuelTypes fuelType,
        double engineCapacity, int weight, double fuelСonsumption,
        int yearOfRelease, int price, int mileage)
        {
            this.color = color;
            this.engineType = engineType;
            this.fuelType = fuelType;
            this.engineCapacity = engineCapacity;
            this.weight = weight;
            this.fuelСonsumption = fuelСonsumption;
            this.yearOfRelease = yearOfRelease;
            this.price = price;
            this.mileage = mileage;
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
            Console.WriteLine($"Mileage : {mileage} km");
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
                    throw new ArgumentException("invalid engine capacity\n");
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
                    throw new ArgumentException("invalid weight\n");
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
                    throw new ArgumentException("invalid fuel consumption\n");
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
                    throw new ArgumentException("invalid year of release\n");
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
                    throw new ArgumentException("invalid price");
                price = value;
            }
        }
        public int Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("invalid mileage");
                mileage = value;
            }
        }


        protected double engineCapacity;

        protected int weight;

        protected double fuelСonsumption;

        protected int yearOfRelease;

        protected int price;

        protected int mileage;
    }
}