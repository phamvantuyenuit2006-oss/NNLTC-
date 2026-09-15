using System;

namespace NNLTC.Phan3_Chuoi
{
    /// <summary>
    /// BÀI 12: XỬ LÝ CHUỖI KÝ TỰ (CHỮ THƯỜNG, CHỮ HOA, ĐẾM SỐ TỪ)
    /// Yêu cầu:
    /// Nhập một chuỗi gồm nhiều từ.
    /// Hãy chuyển chuỗi đó sang ký tự thường, sang ký tự hoa, đếm số từ trong chuỗi.
    /// </summary>
    public class XuLyChuoi
    {
        /// <summary>
        /// Phương thức chuyển đổi toàn bộ chuỗi sang chữ in thường
        /// </summary>
        /// <param name="s">Chuỗi ban đầu</param>
        /// <returns>Chuỗi đã chuyển thành chữ thường</returns>
        public static string ChuyenSangChuThuong(string s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// Phương thức chuyển đổi toàn bộ chuỗi sang chữ in hoa
        /// </summary>
        /// <param name="s">Chuỗi ban đầu</param>
        /// <returns>Chuỗi đã chuyển thành chữ hoa</returns>
        public static string ChuyenSangChuHoa(string s)
        {
            return s.ToUpper();
        }

        /// <summary>
        /// Phương thức đếm số lượng từ trong chuỗi
        /// Tách các từ dựa trên khoảng trắng, tab, xuống dòng và loại bỏ các phần tử rỗng
        /// </summary>
        /// <param name="s">Chuỗi cần đếm từ</param>
        /// <returns>Số lượng từ trong chuỗi</returns>
        public static int DemSoTu(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            // Mảng các ký tự phân cách giữa các từ
            char[] phanCach = new char[] { ' ', '\t', '\n', '\r' };

            // StringSplitOptions.RemoveEmptyEntries giúp loại bỏ các khoảng trắng thừa liên tiếp
            string[] danhSachTu = s.Split(phanCach, StringSplitOptions.RemoveEmptyEntries);

            return danhSachTu.Length;
        }
    }

    public static class Bai12_XuLyChuoiKyTu
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 12
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("   BÀI 12: XỬ LÝ CHUỖI (CHUYỂN HOA, THƯỜNG VÀ ĐẾM SỐ TỪ)         ");
            Console.WriteLine("==================================================================");

            Console.Write("Nhap mot chuoi gom nhieu tu: ");
            string s = Console.ReadLine() ?? "";

            // Gọi các phương thức xử lý chuỗi
            string chuThuong = XuLyChuoi.ChuyenSangChuThuong(s);
            string chuHoa = XuLyChuoi.ChuyenSangChuHoa(s);
            int soTu = XuLyChuoi.DemSoTu(s);

            // Xuất kết quả
            Console.WriteLine("\n--- KET QUA XU LY ---");
            Console.WriteLine($"1. Chuoi chu thuong : {chuThuong}");
            Console.WriteLine($"2. Chuoi chu hoa    : {chuHoa}");
            Console.WriteLine($"3. So luong tu      : {soTu} tu");
            Console.WriteLine("==================================================================");
        }
    }
}
