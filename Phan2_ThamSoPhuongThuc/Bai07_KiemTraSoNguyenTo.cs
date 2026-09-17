using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 7: KIỂM TRA SỐ NGUYÊN TỐ (PHƯƠNG THỨC BOOL)
    /// </summary>
    public class SoNguyenToChecker
    {
        // Phương thức kiểm tra n có phải số nguyên tố không (trả về true/false)
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }

    public static class Bai07_KiemTraSoNguyenTo
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 7: KIỂM TRA SỐ NGUYÊN TỐ ===");

            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            if (SoNguyenToChecker.KiemTraNguyenTo(n))
            {
                Console.WriteLine($"\n=> {n} LA so nguyen to.");
            }
            else
            {
                Console.WriteLine($"\n=> {n} KHONG phai la so nguyen to.");
            }
        }
    }
}
