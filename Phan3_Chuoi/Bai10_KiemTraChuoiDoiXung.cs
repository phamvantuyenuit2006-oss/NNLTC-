using System;

namespace NNLTC.Phan3_Chuoi
{
    /// <summary>
    /// BÀI 10: KIỂM TRA CHUỖI ĐỐI XỨNG (PALINDROME)
    /// Yêu cầu:
    /// Viết phương thức thành viên kiểm tra chuỗi có đối xứng hay không.
    /// Phương thức thành viên (Instance Method) là phương thức thuộc về đối tượng,
    /// cần tạo thể hiện của lớp (new ChuoiHelper()) để gọi.
    /// </summary>
    public class ChuoiHelper
    {
        /// <summary>
        /// Phương thức thành viên kiểm tra một chuỗi có phải là chuỗi đối xứng (Palindrome) hay không
        /// Chuỗi đối xứng là chuỗi đọc xuôi hay đọc ngược đều giống nhau.
        /// Sử dụng kỹ thuật 2 con trỏ (Two-Pointers) từ 2 đầu duyệt vào giữa.
        /// </summary>
        /// <param name="s">Chuỗi cần kiểm tra</param>
        /// <returns>true nếu chuỗi đối xứng, ngược lại false</returns>
        public bool KiemTraDoiXung(string s)
        {
            // Chuỗi null hoặc rỗng được quy ước là đối xứng
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int left = 0;               // Con trỏ đầu chuỗi
            int right = s.Length - 1;   // Con trỏ cuối chuỗi

            // Duyệt đồng thời từ 2 đầu về giữa
            while (left < right)
            {
                // Nếu 2 ký tự ở 2 đầu khác nhau thì chuỗi không đối xứng
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;     // Dịch con trỏ trái sang phải
                right--;    // Dịch con trỏ phải sang trái
            }

            // Nếu tất cả các cặp ký tự đối xứng đều bằng nhau
            return true;
        }
    }

    public static class Bai10_KiemTraChuoiDoiXung
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 10
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("        BÀI 10: KIỂM TRA CHUỖI ĐỐI XỨNG (PHƯƠNG THỨC THÀNH VIÊN)  ");
            Console.WriteLine("==================================================================");

            Console.Write("Nhap chuoi can kiem tra: ");
            string s = Console.ReadLine() ?? "";

            // Khởi tạo đối tượng của lớp ChuoiHelper để gọi phương thức thành viên
            ChuoiHelper helper = new ChuoiHelper();
            bool laDoiXung = helper.KiemTraDoiXung(s);

            // Xuất kết quả kiểm tra
            if (laDoiXung)
            {
                Console.WriteLine($"\n=> Ket qua: Chuoi \"{s}\" LA chuoi doi xung (Palindrome).");
            }
            else
            {
                Console.WriteLine($"\n=> Ket qua: Chuoi \"{s}\" KHONG phai la chuoi doi xung.");
            }
            Console.WriteLine("==================================================================");
        }
    }
}
