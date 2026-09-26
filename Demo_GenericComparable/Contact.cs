using System;

namespace GenericSortSearch
{
    /// <summary>
    /// Lớp Contact đại diện cho thông tin liên lạc (Slide 4 & 5)
    /// </summary>
    public class Contact : IComparable, IComparable<Contact>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public string GetFirstName() => FirstName;
        public string GetLastName() => LastName;
        public string GetPhone() => Phone;

        public override string ToString()
        {
            return $"{LastName}, {FirstName}\t{Phone}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Contact other)
            {
                return LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase) &&
                       FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Contact other)
            {
                return CompareTo(other);
            }
            throw new ArgumentException("Object is not a Contact");
        }

        public int CompareTo(Contact? other)
        {
            if (other == null) return 1;

            if (LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase))
            {
                return string.Compare(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase);
            }
            return string.Compare(LastName, other.LastName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
