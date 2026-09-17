using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 6: TÌM GIÁ TRỊ LỚN NHẤT CỦA 3 SỐ NGUYÊN (PHƯƠNG THỨC RETURN GIÁ TRỊ)
    /// </summary>
    public class TimMax
    {
        // Phương thức tìm số lớn nhất trong 3 số nguyên (truyền tham trị)
        public static int TimGiaTriLonNhat(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
    }

    public static class Bai06_TimMaxBaSo
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 6: TÌM GIÁ TRỊ LỚN NHẤT CỦA 3 SỐ NGUYÊN ===");

            Console.Write("Nhap so thu nhat (a): ");
            int a = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thu hai (b): ");
            int b = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thu ba (c): ");
            int c = int.Parse(Console.ReadLine() ?? "0");

            int max = TimMax.TimGiaTriLonNhat(a, b, c);
            Console.WriteLine($"\n=> So lon nhat trong 3 so ({a}, {b}, {c}) la: {max}");
        }
    }
}
