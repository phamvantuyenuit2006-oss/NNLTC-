using System;

namespace GenericSortSearch
{
    /// <summary>
    /// Lớp Circle thực hiện Generic IComparable<Circle> (Bài tập 4)
    /// </summary>
    public class Circle : IComparable<Circle>, IComparable
    {
        public string Id { get; set; }
        public double Radius { get; set; }

        public Circle(string id, double radius)
        {
            Id = id;
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;
        public double Perimeter => 2 * Math.PI * Radius;

        public int CompareTo(Circle? other)
        {
            if (other == null) return 1;
            return Radius.CompareTo(other.Radius);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Circle other) return CompareTo(other);
            throw new ArgumentException("Object is not a Circle");
        }

        public override bool Equals(object? obj)
        {
            if (obj is Circle other)
            {
                return Math.Abs(Radius - other.Radius) < 0.0001;
            }
            return false;
        }

        public override int GetHashCode() => Radius.GetHashCode();

        public override string ToString()
        {
            return $"Circle[ID: {Id,-5} | Radius: {Radius,6:F2} | Area: {Area,8:F2}]";
        }
    }
}
