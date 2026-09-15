using System;

namespace NNLTC.Phan5_MangArrayList
{
    /// <summary>
    /// BÀI 16: SẮP XẾP MẢNG HỌ TÊN CỦA N NGƯỜI TĂNG DẦN
    /// Yêu cầu:
    /// Nhập vào một mảng họ tên của n người. Hãy sắp xếp mảng đó theo thứ tự tăng dần (A-Z).
    /// </summary>
    public class SapXepHoTenHelper
    {
        /// <summary>
        /// Phương thức nhập danh sách họ tên của n người
        /// </summary>
        /// <param name="n">Số lượng người</param>
        /// <returns>Mảng string[] chứa họ tên</returns>
        public static string[] NhapDanhSach(int n)
        {
            string[] ds = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten nguoi thu {i + 1}: ");
                ds[i] = Console.ReadLine() ?? "";
            }
            return ds;
        }

        /// <summary>
        /// Phương thức sắp xếp mảng chuỗi họ tên tăng dần theo thứ tự từ điển (không phân biệt hoa/thường)
        /// </summary>
        /// <param name="ds">Mảng họ tên cần sắp xếp</param>
        public static void SapXepTangDan(string[] ds)
        {
            // Sử dụng Array.Sort với bộ so sánh chuẩn văn hóa hiện tại không phân biệt chữ hoa/thường
            Array.Sort(ds, StringComparer.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// Phương thức in danh sách họ tên ra màn hình Console
        /// </summary>
        /// <param name="ds">Mảng danh sách họ tên</param>
        /// <param name="tieuDe">Tiêu đề bảng danh sách</param>
        public static void InDanhSach(string[] ds, string tieuDe)
        {
            Console.WriteLine($"\n--- {tieuDe} ---");
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine($"{i + 1,2}. {ds[i]}");
            }
        }
    }

    public static class Bai16_SapXepHoTen
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 16
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("           BÀI 16: SẮP XẾP MẢNG HỌ TÊN CỦA N NGƯỜI TĂNG DẦN       ");
            Console.WriteLine("==================================================================");

            int n;
            while (true)
            {
                Console.Write("Nhap so luong nguoi n (n > 0): ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("So luong phai la so nguyen duong!");
            }

            // 1. Nhập danh sách họ tên
            string[] dsHoTen = SapXepHoTenHelper.NhapDanhSach(n);

            // 2. In danh sách trước khi sắp xếp
            SapXepHoTenHelper.InDanhSach(dsHoTen, "DANH SÁCH TRƯỚC KHI SẮP XẾP");

            // 3. Sắp xếp danh sách tăng dần
            SapXepHoTenHelper.SapXepTangDan(dsHoTen);

            // 4. In danh sách sau khi đã sắp xếp
            SapXepHoTenHelper.InDanhSach(dsHoTen, "DANH SÁCH SAU KHI SẮP XẾP TĂNG DẦN (A - Z)");
            Console.WriteLine("==================================================================");
        }
    }
}
