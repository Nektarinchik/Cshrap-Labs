using System;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            ICondition mercedes1 = new Mercedes(Vehicle.Сolors.white, Vehicle.EngineTypes.internalCombustionEngine,
                Vehicle.FuelTypes.gasoline, Car.BodyworkTypes.coupe, Car.Transmission.mechanical,
                Car.Drive.allWheel, 2.0, 1460, 7.7, 2020, 46000, 113000, 4, "CLA", "with mileage");
            Console.WriteLine($"{mercedes1.Maintainability()}");
            Mercedes mercedes2 = new Mercedes(Vehicle.Сolors.black, Vehicle.EngineTypes.internalCombustionEngine,
                Vehicle.FuelTypes.diesel, Car.BodyworkTypes.sedan, Car.Transmission.automatic,
                Car.Drive.frontWheel, 1.8, 1360, 4.3, 2020, 35000, 0, 4, "C-Class", "new");
            Car car1 = (Car)mercedes1;
            Console.WriteLine($"{car1.CompareTo(mercedes2)}");
            mercedes2.WeRecommend += (output) => Console.WriteLine(output);
            mercedes2.GetInfo();
        }
    }
}