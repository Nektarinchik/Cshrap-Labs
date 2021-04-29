using System;

namespace Transport
{
    sealed class Mercedes : Car, ICondition
    {
        public Mercedes(Сolors color, EngineTypes engineType, FuelTypes fuelType, BodyworkTypes bodyWork,
            Transmission transmission, Drive drive, double engineCapacity, int weight, double fuelСonsumption,
            int yearOfRelease, int price, int mileage, int seatsAmount, string model, string condition) : base(color, engineType, fuelType,
                bodyWork, transmission, drive, engineCapacity, weight, fuelСonsumption, yearOfRelease,
                price, mileage, seatsAmount)
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
            WeRecommend?.Invoke(Recommendation());
        }
        public string Maintainability()
        {
            if (condition == "new")
                return $"{brand} {model} rideable, no repair required";
            if (condition == "with mileage")
                return $"{brand} {model} rideable, requires additional inspection";
            if (condition == "crash")
                return $"{brand} {model} not rideable, exclusively for spare parts";
            throw new ArgumentException("invalid condition");
        }
        public string Recommendation()
        {
            if(condition == "new")
            {
                if (price < 30000)
                    return $"We recommend {brand} {model}. The price-quality ratio is excellent";
                return $"We recommend {brand} {model}. High price meets expectations";
            }
            else if(condition=="with mileage")
            {
                if (yearOfRelease > 1999 && mileage < 300000 && price < 8000)
                    return $"We recommend {brand} {model}. Even used cars from this brand are the dream of many";
                return $"We don't recommend {brand} {model} for everyday driving. This car is ready to get into the hands of a restorer";          
            }
            else
            {
                if (price < 5000)
                    return $"We recommend {brand} {model} for spare parts";
                return $"We don't recommend {brand} {model} for spare parts. The price is too high";
            }
        }
        public delegate void CarRecommendation(string recommend);

        public event CarRecommendation WeRecommend;
        public string brand { get; set; }
        public string model { get; set; }
        public string condition { get; set; }
    }
}