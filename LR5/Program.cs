using System;

namespace Transport
{


    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Mercedes(Vehicle.Сolors.white, Vehicle.EngineTypes.internalCombustionEngine,
                Vehicle.FuelTypes.gasoline, Car.BodyworkTypes.coupe, Car.Transmission.mechanical,
                Car.Drive.allWheel, 2.0, 1460, 7.7, 2020, 46000, 4, "CLA");
        }
    }
}
