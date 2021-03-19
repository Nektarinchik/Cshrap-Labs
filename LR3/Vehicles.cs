using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Vehicles
    {
        public Vehicles()
        {
            vehicles = new List<Vehicle>();
            numberOfVehicles = 0;
        }

        List<Vehicle> vehicles;
        public Vehicle this[int index]
        {
            get
            {
                if (index < 0 || index >= numberOfVehicles)
                {
                    throw new Exception("There is no such index");
                }
                return vehicles[index];
            }
            set
            {
                vehicles.Insert(index, value);
                ++numberOfVehicles;
            }
        }

        private int numberOfVehicles;
    }
}
