using System;
using System.Text;

namespace GenericSortSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("******************************************************************");
            Console.WriteLine("  CHƯƠNG TRÌNH DEMO THUẬT TOÁN GENERIC SORTING & SEARCHING (C#)  ");
            Console.WriteLine("******************************************************************\n");

            // 1. DEMO CONTACT (PhoneList từ Slide 8 & 9)
            Console.WriteLine("==================================================");
            Console.WriteLine("   DEMO LỚP CONTACT - SẮP XẾP BẰNG SELECTION SORT ");
            Console.WriteLine("==================================================");

            Contact[] friends = new Contact[8]
            {
                new Contact("John", "Smith", "610-555-7384"),
                new Contact("Sarah", "Barnes", "215-555-3827"),
                new Contact("Mark", "Riley", "733-555-2969"),
                new Contact("Laura", "Getz", "663-555-3984"),
                new Contact("Larry", "Smith", "464-555-3489"),
                new Contact("Frank", "Phelps", "322-555-2284"),
                new Contact("Mario", "Guzman", "804-555-9066"),
                new Contact("Marsha", "Grant", "243-555-2837")
            };

            Console.WriteLine("\n--- Danh sách danh bạ ban đầu ---");
            foreach (var c in friends) Console.WriteLine(c);

            Sorting.SelectionSort(friends);

            Console.WriteLine("\n--- Danh sách danh bạ sau khi sắp xếp theo Tên (LastName -> FirstName) ---");
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }

            Console.WriteLine("\n--- Thử nghiệm tìm kiếm trong danh bạ ---");
            Contact contactTarget = new Contact("Frank", "Phelps", "");
            Contact? foundLinear = (Contact?)Searching.LinearSearch(friends, contactTarget);
            Console.WriteLine($"Tìm kiếm tuyến tính (Frank Phelps): {(foundLinear != null ? "Tìm thấy -> " + foundLinear : "Không tìm thấy")}");

            Contact? foundBinary = (Contact?)Searching.BinarySearch(friends, contactTarget);
            Console.WriteLine($"Tìm kiếm nhị phân    (Frank Phelps): {(foundBinary != null ? "Tìm thấy -> " + foundBinary : "Không tìm thấy")}");


            // 2. DEMO CAR (Bài tập 4)
            Console.WriteLine("\n\n==================================================");
            Console.WriteLine("   DEMO LỚP CAR - SẮP XẾP VÀ TÌM KIẾM THEO GIÁ    ");
            Console.WriteLine("==================================================");
            Car[] cars = new Car[]
            {
                new Car("VinFast VF8", 42000.0, 200),
                new Car("Toyota Camry", 26000.0, 210),
                new Car("Mercedes C300", 45000.0, 250),
                new Car("Hyundai Tucson", 30000.0, 190),
                new Car("Porsche 911", 120000.0, 310)
            };

            Console.WriteLine("\n--- Danh sách Xe hơi ban đầu ---");
            foreach (var car in cars) Console.WriteLine(car);

            Sorting.GenericInsertionSort(cars);

            Console.WriteLine("\n--- Danh sách Xe hơi sau khi Insertion Sort (Giá tăng dần) ---");
            foreach (var car in cars) Console.WriteLine(car);

            Car carTarget = new Car("Mercedes C300", 45000.0, 250);
            Car? carFound = Searching.GenericBinarySearch(cars, carTarget);
            Console.WriteLine("\nKết quả Binary Search (Mercedes C300 - $45000.00):");
            Console.WriteLine(carFound != null ? $"-> Tìm thấy: {carFound}" : "-> Không tìm thấy");


            // 3. DEMO CIRCLE (Bài tập 4)
            Console.WriteLine("\n\n==================================================");
            Console.WriteLine("   DEMO LỚP CIRCLE - SẮP XẾP THEO BÁN KÍNH/DIỆN TÍCH ");
            Console.WriteLine("==================================================");
            Circle[] circles = new Circle[]
            {
                new Circle("C1", 15.5),
                new Circle("C2", 3.2),
                new Circle("C3", 28.0),
                new Circle("C4", 7.8),
                new Circle("C5", 12.0)
            };

            Console.WriteLine("\n--- Danh sách Hình tròn ban đầu ---");
            foreach (var c in circles) Console.WriteLine(c);

            Sorting.GenericSelectionSort(circles);

            Console.WriteLine("\n--- Danh sách Hình tròn sau Selection Sort (Bán kính tăng dần) ---");
            foreach (var c in circles) Console.WriteLine(c);

            Circle circleTarget = new Circle("Target", 12.0);
            Circle? circleFound = Searching.GenericBinarySearch(circles, circleTarget);
            Console.WriteLine("\nKết quả Binary Search (Bán kính = 12.0):");
            Console.WriteLine(circleFound != null ? $"-> Tìm thấy: {circleFound}" : "-> Không tìm thấy");


            // 4. DEMO HUMAN (Bài tập 4)
            Console.WriteLine("\n\n==================================================");
            Console.WriteLine("   DEMO LỚP HUMAN - SẮP XẾP THEO TUỔI VÀ CHIỀU CAO ");
            Console.WriteLine("==================================================");
            Human[] people = new Human[]
            {
                new Human("H01", "Nguyen Van An", 25, 172.5),
                new Human("H02", "Tran Thi Binh", 20, 160.0),
                new Human("H03", "Le Van Cuong", 32, 178.0),
                new Human("H04", "Pham Thi Dung", 20, 165.5),
                new Human("H05", "Hoang Van Em", 18, 170.0)
            };

            Console.WriteLine("\n--- Danh sách Con người ban đầu ---");
            foreach (var h in people) Console.WriteLine(h);

            Sorting.GenericInsertionSort(people);

            Console.WriteLine("\n--- Danh sách Con người sau Insertion Sort (Tuổi -> Chiều cao) ---");
            foreach (var h in people) Console.WriteLine(h);

            Human humanTarget = new Human("H03", "Le Van Cuong", 32, 178.0);
            Human? humanFound = Searching.GenericBinarySearch(people, humanTarget);
            Console.WriteLine("\nKết quả Binary Search (Le Van Cuong - 32 tuổi):");
            Console.WriteLine(humanFound != null ? $"-> Tìm thấy: {humanFound}" : "-> Không tìm thấy");

            Console.WriteLine("\n******************************************************************");
            Console.WriteLine("                   DEMO HOÀN TẤT THÀNH CÔNG!                      ");
            Console.WriteLine("******************************************************************");
        }
    }
}
