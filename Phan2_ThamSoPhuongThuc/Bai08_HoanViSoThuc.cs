using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 8: HOÁN VỊ HAI SỐ THỰC (SỬ DỤNG TỪ KHÓA REF)
    /// </summary>
    public class HoanViHelper
    {
        // Phương thức hoán vị 2 số thực sử dụng tham chiếu ref
        public static void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }

    public static class Bai08_HoanViSoThuc
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 8: HOÁN VỊ HAI SỐ THỰC (THAM CHIẾU REF) ===");

            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"\nTruoc khi hoan vi : a = {a}, b = {b}");

            // Gọi hàm hoán vị truyền tham chiếu bằng ref
            HoanViHelper.HoanVi(ref a, ref b);

            Console.WriteLine($"Sau khi hoan vi   : a = {a}, b = {b}");
        }
    }
}
