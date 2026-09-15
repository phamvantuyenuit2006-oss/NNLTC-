using System;
using System.Text;

namespace NNLTC.Phan3_Chuoi
{
    /// <summary>
    /// BÀI 11: ĐẢO NGƯỢC CHUỖI VỚI STRINGBUILDER
    /// Yêu cầu:
    /// Viết phương thức thành viên trả về chuỗi là đảo của một chuỗi.
    /// Sử dụng lớp StringBuilder trong namespace System.Text để tối ưu hóa hiệu năng ghép chuỗi.
    /// </summary>
    public class DaoChuoiHelper
    {
        /// <summary>
        /// Phương thức thành viên thực hiện đảo ngược chuỗi
        /// </summary>
        /// <param name="s">Chuỗi gốc ban đầu</param>
        /// <returns>Chuỗi mới có thứ tự các ký tự đảo ngược</returns>
        public string DaoChuoi(string s)
        {
            // Kiểm tra chuỗi rỗng hoặc null
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            // Sử dụng StringBuilder với dung lượng khởi tạo bằng độ dài chuỗi s
            // để tránh phân mảnh bộ nhớ khi nối chuỗi trong vòng lặp (chuỗi string trong C# là immutable)
            StringBuilder sb = new StringBuilder(s.Length);

            // Duyệt ngược từ ký tự cuối cùng về ký tự đầu tiên của chuỗi
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]); // Thêm từng ký tự vào StringBuilder
            }

            // Chuyển StringBuilder thành string và trả về kết quả
            return sb.ToString();
        }
    }

    public static class Bai11_DaoChuoi
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 11
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("        BÀI 11: ĐẢO NGƯỢC CHUỖI (SỬ DỤNG STRINGBUILDER)          ");
            Console.WriteLine("==================================================================");

            Console.Write("Nhap chuoi can dao nguoc: ");
            string s = Console.ReadLine() ?? "";

            // Khởi tạo đối tượng lớp DaoChuoiHelper
            DaoChuoiHelper helper = new DaoChuoiHelper();
            string ketQua = helper.DaoChuoi(s);

            // Xuất kết quả
            Console.WriteLine("\n--- KET QUA ---");
            Console.WriteLine($"Chuoi ban dau   : \"{s}\"");
            Console.WriteLine($"Chuoi sau khi dao: \"{ketQua}\"");
            Console.WriteLine("==================================================================");
        }
    }
}
