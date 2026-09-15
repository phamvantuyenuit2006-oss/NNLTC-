using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 3: NHẬP SỐ NGUYÊN
    /// Yêu cầu:
    /// Viết chương trình nhập hai số nguyên x, y. Tính x^y và xuất theo định dạng sau:
    /// Nhap so nguyen x: 7
    /// Nhap so nguyen y: 3
    /// Ket qua 7 mu 3 la: 343
    /// </summary>
    public static class Bai03_NhapSoNguyen
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 3
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("                BÀI 3: NHẬP SỐ NGUYÊN & TÍNH X^Y                  ");
            Console.WriteLine("==================================================================");

            // Nhập số nguyên x từ bàn phím và chuyển đổi kiểu dữ liệu bằng int.Parse
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine() ?? "0");

            // Nhập số nguyên y từ bàn phím và chuyển đổi kiểu dữ liệu
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine() ?? "0");

            // Tính x lũy thừa y (x^y) sử dụng phương thức Math.Pow(double, double) trong thư viện Math
            double ketQua = Math.Pow(x, y);

            // Xuất kết quả ra màn hình đúng mẫu định dạng trong đề bài thực hành
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
            Console.WriteLine("==================================================================");
        }
    }
}
