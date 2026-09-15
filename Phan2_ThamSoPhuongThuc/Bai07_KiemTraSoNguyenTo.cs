using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 7: PHƯƠNG THỨC BOOL
    /// Yêu cầu:
    /// Xây dựng lớp có phương thức kiểm tra n có phải là số nguyên tố hay không.
    /// Trả về kiểu boolean (true/false).
    /// </summary>
    public class SoNguyenToChecker
    {
        /// <summary>
        /// Phương thức kiểm tra một số nguyên n có phải là số nguyên tố hay không
        /// Số nguyên tố là số nguyên lớn hơn 1 và chỉ chia hết cho 1 và chính nó.
        /// </summary>
        /// <param name="n">Số nguyên cần kiểm tra</param>
        /// <returns>true nếu n là số nguyên tố, ngược lại false</returns>
        public static bool KiemTraNguyenTo(int n)
        {
            // Các số nhỏ hơn 2 không phải là số nguyên tố
            if (n < 2)
            {
                return false;
            }

            // Duyệt từ 2 đến căn bậc hai của n để tối ưu thuật toán O(sqrt(n))
            int canBacHai = (int)Math.Sqrt(n);
            for (int i = 2; i <= canBacHai; i++)
            {
                // Nếu n chia hết cho bất kỳ số nào từ 2 đến sqrt(n) thì n là hợp số
                if (n % i == 0)
                {
                    return false;
                }
            }

            // Nếu không chia hết cho số nào thì n là số nguyên tố
            return true;
        }
    }

    public static class Bai07_KiemTraSoNguyenTo
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 7
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("           BÀI 7: KIỂM TRA SỐ NGUYÊN TỐ (PHƯƠNG THỨC BOOL)        ");
            Console.WriteLine("==================================================================");

            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            // Gọi phương thức trả về kiểu bool
            bool laSNT = SoNguyenToChecker.KiemTraNguyenTo(n);

            if (laSNT)
            {
                Console.WriteLine($"\n=> Ket qua: {n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"\n=> Ket qua: {n} khong phai la so nguyen to.");
            }
            Console.WriteLine("==================================================================");
        }
    }
}
