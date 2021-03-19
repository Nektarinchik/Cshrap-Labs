using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle auto = new Vehicle();
            auto.Color = Vehicle.Сolors.black;
            auto.EngineType = Vehicle.EngineTypes.internalCombustionEngine;
            auto.FuelType = Vehicle.FuelTypes.gasoline;
            auto.EngineCapacity = 2.2;
            auto.FuelСonsumption = 9.7;
            auto.SeatsAmount = 4;
            auto.Weight = 1960;
            auto.YearOfRelease = 2014;
            Console.WriteLine($"Color: {auto.Color}");
            Console.WriteLine($"Type of engine: {auto.EngineType}");
            Console.WriteLine($"Type of fuel: {auto.FuelType}");
            Console.WriteLine($"Engine capacity: {auto.EngineCapacity}");
            Console.WriteLine($"Fuel consumption: {auto.FuelСonsumption}");
            Console.WriteLine($"Number of seats: {auto.SeatsAmount}");
            Console.WriteLine($"Weight: {auto.Weight}");
            Console.WriteLine($"Year of release: {auto.YearOfRelease}");

            Vehicles vehicles = new Vehicles();
            vehicles[0] = auto;
            Console.WriteLine($"Color: {vehicles[0].Color}");

        }
    }
}
