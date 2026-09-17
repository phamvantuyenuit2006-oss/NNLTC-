using System;

namespace NNLTC.Phan3_Chuoi
{
    /// <summary>
    /// BÀI 10: KIỂM TRA CHUỖI ĐỐI XỨNG (PHƯƠNG THỨC THÀNH VIÊN)
    /// </summary>
    public class ChuoiHelper
    {
        // Phương thức thành viên (phương thức của đối tượng) kiểm tra chuỗi đối xứng
        public bool KiemTraDoiXung(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }

    public static class Bai10_KiemTraChuoiDoiXung
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 10: KIỂM TRA CHUỖI ĐỐI XỨNG ===");

            Console.Write("Nhap chuoi can kiem tra: ");
            string s = Console.ReadLine() ?? "";

            // Khởi tạo đối tượng để gọi phương thức thành viên
            ChuoiHelper helper = new ChuoiHelper();
            if (helper.KiemTraDoiXung(s))
            {
                Console.WriteLine($"\n=> Chuoi \"{s}\" LA chuoi doi xung (Palindrome).");
            }
            else
            {
                Console.WriteLine($"\n=> Chuoi \"{s}\" KHONG phai la chuoi doi xung.");
            }
        }
    }
}
