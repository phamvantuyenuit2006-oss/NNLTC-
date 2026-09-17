using System;
using System.Text;

namespace NNLTC.Phan3_Chuoi
{
    /// <summary>
    /// BÀI 11: ĐẢO NGƯỢC CHUỖI (SỬ DỤNG STRINGBUILDER)
    /// </summary>
    public class DaoChuoiHelper
    {
        // Phương thức thành viên đảo ngược chuỗi
        public string DaoChuoi(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }

    public static class Bai11_DaoChuoi
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 11: ĐẢO NGƯỢC CHUỖI ===");

            Console.Write("Nhap chuoi can dao: ");
            string s = Console.ReadLine() ?? "";

            // Khởi tạo đối tượng để gọi phương thức thành viên
            DaoChuoiHelper helper = new DaoChuoiHelper();
            string ketQua = helper.DaoChuoi(s);

            Console.WriteLine($"\nChuoi ban dau    : \"{s}\"");
            Console.WriteLine($"Chuoi sau khi dao: \"{ketQua}\"");
        }
    }
}
