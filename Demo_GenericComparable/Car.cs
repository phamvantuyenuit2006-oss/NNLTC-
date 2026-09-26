using System;

namespace GenericSortSearch
{
    /// <summary>
    /// Lớp Car thực hiện Generic IComparable<Car> (Bài tập 4)
    /// </summary>
    public class Car : IComparable<Car>, IComparable
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string model, double price, int maxSpeed)
        {
            Model = model;
            Price = price;
            MaxSpeed = maxSpeed;
        }

        public int CompareTo(Car? other)
        {
            if (other == null) return 1;
            
            // Sắp xếp ưu tiên theo Giá, sau đó đến Tốc độ tối đa, rồi đến Model
            int priceComparison = Price.CompareTo(other.Price);
            if (priceComparison != 0) return priceComparison;

            int speedComparison = MaxSpeed.CompareTo(other.MaxSpeed);
            if (speedComparison != 0) return speedComparison;

            return string.Compare(Model, other.Model, StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Car other) return CompareTo(other);
            throw new ArgumentException("Object is not a Car");
        }

        public override bool Equals(object? obj)
        {
            if (obj is Car other)
            {
                return Math.Abs(Price - other.Price) < 0.001 &&
                       MaxSpeed == other.MaxSpeed &&
                       Model == other.Model;
            }
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Model, Price, MaxSpeed);

        public override string ToString()
        {
            return $"Car[Model: {Model,-15} | Price: ${Price,10:N2} | Speed: {MaxSpeed,3} km/h]";
        }
    }
}
