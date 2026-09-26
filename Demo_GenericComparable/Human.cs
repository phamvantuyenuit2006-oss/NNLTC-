using System;

namespace GenericSortSearch
{
    /// <summary>
    /// Lớp Human thực hiện Generic IComparable<Human> (Bài tập 4)
    /// </summary>
    public class Human : IComparable<Human>, IComparable
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; } // cm

        public Human(string id, string fullName, int age, double height)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Height = height;
        }

        public int CompareTo(Human? other)
        {
            if (other == null) return 1;

            // Sắp xếp ưu tiên theo Tuổi, sau đó đến Chiều cao, rồi đến Tên
            int ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0) return ageComparison;

            int heightComparison = Height.CompareTo(other.Height);
            if (heightComparison != 0) return heightComparison;

            return string.Compare(FullName, other.FullName, StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Human other) return CompareTo(other);
            throw new ArgumentException("Object is not a Human");
        }

        public override bool Equals(object? obj)
        {
            if (obj is Human other)
            {
                return Age == other.Age &&
                       Math.Abs(Height - other.Height) < 0.001 &&
                       FullName.Equals(other.FullName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Id, FullName, Age, Height);

        public override string ToString()
        {
            return $"Human[ID: {Id,-5} | Name: {FullName,-18} | Age: {Age,2} | Height: {Height,5:F1} cm]";
        }
    }
}
