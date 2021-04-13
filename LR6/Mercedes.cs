using System;

namespace Transport
{
    sealed class Mercedes : Car, ICondition
    {
        public Mercedes(Сolors color, EngineTypes engineType, FuelTypes fuelType, BodyworkTypes bodyWork,
            Transmission transmission, Drive drive, double engineCapacity, int weight, double fuelСonsumption,
            int yearOfRelease, int price, int seatsAmount, string model, string condition) : base(color, engineType, fuelType,
                bodyWork, transmission, drive, engineCapacity, weight, fuelСonsumption, yearOfRelease,
                price, seatsAmount)
        {
            brand = "Mercedes";
            this.condition = condition;
            this.model = model;
            GetInfo();
        }
        public override void GetInfo()
        {
            Console.WriteLine($"{brand} {model}");
            base.GetInfo();
        }

        public string Maintainability()
        {
            if (condition == "new")
                return $"{brand} {model} rideable, no repair required";
            if(condition == "with mileage")
                return $"{brand} {model} rideable, requires additional inspection";
            if(condition == "crash")
                return $"{brand} {model} not rideable, exclusively for spare parts";
            throw new ArgumentException("invalid condition");
        }

        public string brand { get; set; }
        public string model { get; set; }
        public string condition { get ; set; }
    }
}
