using Xunit;
using GenericSortSearch;

namespace GenericSortSearch.Tests
{
    public class AlgorithmTests
    {
        [Fact]
        public void Test_Contact_SelectionSort_And_BinarySearch()
        {
            Contact[] friends = new Contact[4]
            {
                new Contact("John", "Smith", "111"),
                new Contact("Sarah", "Barnes", "222"),
                new Contact("Mark", "Riley", "333"),
                new Contact("Laura", "Getz", "444")
            };

            Sorting.SelectionSort(friends);

            Assert.Equal("Barnes", friends[0].LastName);
            Assert.Equal("Getz", friends[1].LastName);
            Assert.Equal("Riley", friends[2].LastName);
            Assert.Equal("Smith", friends[3].LastName);

            var found = Searching.BinarySearch(friends, new Contact("Mark", "Riley", ""));
            Assert.NotNull(found);
            Assert.Equal("333", ((Contact)found).Phone);
        }

        [Fact]
        public void Test_Car_GenericInsertionSort_And_BinarySearch()
        {
            Car[] cars = new Car[]
            {
                new Car("VF8", 42000, 200),
                new Car("Camry", 26000, 210),
                new Car("Porsche", 120000, 310)
            };

            Sorting.GenericInsertionSort(cars);

            Assert.Equal("Camry", cars[0].Model);
            Assert.Equal("VF8", cars[1].Model);
            Assert.Equal("Porsche", cars[2].Model);

            var found = Searching.GenericBinarySearch(cars, new Car("VF8", 42000, 200));
            Assert.NotNull(found);
            Assert.Equal("VF8", found.Model);
        }

        [Fact]
        public void Test_Circle_GenericSelectionSort()
        {
            Circle[] circles = new Circle[]
            {
                new Circle("C1", 10.0),
                new Circle("C2", 2.5),
                new Circle("C3", 5.0)
            };

            Sorting.GenericSelectionSort(circles);

            Assert.Equal(2.5, circles[0].Radius);
            Assert.Equal(5.0, circles[1].Radius);
            Assert.Equal(10.0, circles[2].Radius);

            var found = Searching.GenericBinarySearch(circles, new Circle("C2", 2.5));
            Assert.NotNull(found);
            Assert.Equal("C2", found.Id);
        }

        [Fact]
        public void Test_Human_GenericInsertionSort()
        {
            Human[] people = new Human[]
            {
                new Human("H1", "An", 30, 170),
                new Human("H2", "Binh", 20, 165),
                new Human("H3", "Cuong", 25, 175)
            };

            Sorting.GenericInsertionSort(people);

            Assert.Equal("Binh", people[0].FullName);
            Assert.Equal("Cuong", people[1].FullName);
            Assert.Equal("An", people[2].FullName);

            var found = Searching.GenericLinearSearch(people, new Human("H3", "Cuong", 25, 175));
            Assert.NotNull(found);
            Assert.Equal("H3", found.Id);
        }
    }
}
