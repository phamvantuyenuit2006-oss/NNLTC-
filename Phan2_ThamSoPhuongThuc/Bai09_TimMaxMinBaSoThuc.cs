using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 9: TÌM MAX VÀ MIN CỦA 3 SỐ THỰC (SỬ DỤNG TỪ KHÓA OUT)
    /// </summary>
    public class MaxMinHelper
    {
        // Phương thức tìm cả Max và Min sử dụng tham số out
        public static void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            // Tìm Max
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            // Tìm Min
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
        }
    }

    public static class Bai09_TimMaxMinBaSoThuc
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 9: TÌM MAX VÀ MIN CỦA 3 SỐ THỰC (THAM CHIẾU OUT) ===");

            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine() ?? "0");

            double max, min;
            MaxMinHelper.TimMaxMin(a, b, c, out max, out min);

            Console.WriteLine($"\n=> So lon nhat (Max): {max}");
            Console.WriteLine($"=> So nho nhat (Min): {min}");
        }
    }
}
