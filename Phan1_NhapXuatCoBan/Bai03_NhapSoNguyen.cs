using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 3: NHẬP SỐ NGUYÊN VÀ TÍNH X^Y
    /// </summary>
    public static class Bai03_NhapSoNguyen
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 3: NHẬP SỐ NGUYÊN TÍNH X^Y ===");

            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine() ?? "0");

            // Tinh x mu y bang Math.Pow
            double ketQua = Math.Pow(x, y);

            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}
