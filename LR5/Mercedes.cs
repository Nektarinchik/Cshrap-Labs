using System;

namespace Transport
{
    sealed class Mercedes : Car
    {
        public Mercedes(Сolors color, EngineTypes engineType, FuelTypes fuelType, BodyworkTypes bodyWork,
            Transmission transmission, Drive drive, double engineCapacity, int weight, double fuelСonsumption,
            int yearOfRelease, int price, int seatsAmount, string model) : base(color, engineType, fuelType,
                bodyWork, transmission, drive, engineCapacity, weight, fuelСonsumption, yearOfRelease,
                price, seatsAmount)
        {
            this.model = model;
            GetInfo();
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Mercedes {model}");
            base.GetInfo();
        }
        public string model { get; set; }
    }
}
