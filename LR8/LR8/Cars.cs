using System;
using System.Collections.Generic;

namespace Transport
{
    class Cars
    {
        public Cars()
        {
            cars = new Dictionary<int, Car>();
            vehiclesAmount = 0;
        }
        public Car this[int index]
        {
            get
            {
                if (index >= 0 && index < vehiclesAmount)
                    return cars[index];
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index != value.Number)
                    throw new IndexOutOfRangeException("Car can't be used with such number");
                else
                {
                    cars[value.Number] = value;
                    ++vehiclesAmount;
                }                
            }
        }
        private int vehiclesAmount;

        private Dictionary<int, Car> cars;
    }
}
