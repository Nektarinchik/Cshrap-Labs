using System;

namespace Transport
{
    class Car : Vehicle, IComparable<Car>
    {
        public Car(Сolors color, EngineTypes engineType, FuelTypes fuelType, BodyworkTypes bodyWork,
            Transmission transmission, Drive drive, double engineCapacity, int weight, double fuelСonsumption,
            int yearOfRelease, int price, int seatsAmount) : base(color, engineType, fuelType, engineCapacity, weight,
            fuelСonsumption, yearOfRelease, price)
        {
            this.bodyWork = bodyWork;
            this.transmission = transmission;
            this.drive = drive;
            this.seatsAmount = seatsAmount;
        }
        public enum BodyworkTypes
        {
            hatchback,
            sedan,
            coupe,
            convertible,
            wagon,
            jeep
        }
        public enum Transmission
        {
            mechanical,
            automatic
        }
        public enum Drive
        {
            allWheel,
            frontWheel,
            rearWheel
        }
        public BodyworkTypes bodyWork { get; set; }
        public Transmission transmission { get; set; }
        public Drive drive { get; set; }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Bodywork type : {bodyWork}");
            Console.WriteLine($"Transmission : {transmission}");
            Console.WriteLine($"Drive type : {drive}");
            Console.WriteLine($"Seats amount : {seatsAmount}");
        }
        public int CompareTo(Car car)
        {
            if (price == car.price)
                return 0;
            else if (price > car.price)
                return 1;
            else
                return -1;
        }

        public int SeatsAmount
        {
            get
            {
                return seatsAmount;
            }
            set
            {
                if (value < 1)
                    throw new Exception("invalid amount of seats");
                seatsAmount = value;
            }
        }

        protected int seatsAmount;
    }
}
