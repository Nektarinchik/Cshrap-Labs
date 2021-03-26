using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle auto = new Vehicle();
            auto.color = Vehicle.Сolors.black;
            auto.engineType = Vehicle.EngineTypes.internalCombustionEngine;
            auto.fuelType = Vehicle.FuelTypes.gasoline;
            auto.engineCapacity = 2.2;
            auto.fuelСonsumption = 9.7;
            auto.seatsAmount = 4;
            auto.weight = 1960;
            auto.yearOfRelease = 2014;
            Console.WriteLine($"Color: {auto.color}");
            Console.WriteLine($"Type of engine: {auto.engineType}");
            Console.WriteLine($"Type of fuel: {auto.fuelType}");
            Console.WriteLine($"Engine capacity: {auto.engineCapacity}");
            Console.WriteLine($"Fuel consumption: {auto.fuelСonsumption}");
            Console.WriteLine($"Number of seats: {auto.seatsAmount}");
            Console.WriteLine($"Weight: {auto.weight}");
            Console.WriteLine($"Year of release: {auto.yearOfRelease}");

            Vehicles vehicles = new Vehicles();
            vehicles[0] = auto;
            Console.WriteLine($"Color: {vehicles[0].color}");

        }
    }
}
