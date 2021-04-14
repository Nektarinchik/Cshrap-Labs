using System;

namespace Transport
{
    class Motorcycle : Vehicle, IComparable<Motorcycle>
    {
        public Motorcycle(Сolors color, EngineTypes engineType, FuelTypes fuelType, Drive drive, Category category,
            double engineCapacity, int weight, double fuelСonsumption, int yearOfRelease, int price, int seatsAmount) : 
            base(color, engineType, fuelType, engineCapacity, weight, fuelСonsumption, yearOfRelease, price)
        {
            this.category = category;
            this.drive = drive;
        }
        public enum Category
        {
            moped,
            lightMotorcycle,
            motorcycle
        }
        public enum Drive
        {
            chainDrive,
            beltDrive,
            shaftDrive
        }
        public Category category { get; set; }
        public Drive drive { get; set; }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Category : {category}");
            Console.WriteLine($"Drive type : {drive}");
        }
        public int CompareTo(Motorcycle motorcycle)
        {
            if (price == motorcycle.price)
                return 0;
            else if (price > motorcycle.price)
                return 1;
            else
                return -1;
        }
    }
}
