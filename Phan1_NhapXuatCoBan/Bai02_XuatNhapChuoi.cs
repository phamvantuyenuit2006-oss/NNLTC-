using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 2: XUẤT VÀ NHẬP CHUỖI
    /// Yêu cầu:
    /// Dùng chương trình Visual Studio.Net viết chương trình nhập họ tên và xuất họ tên đã nhập
    /// ra màn hình console theo định dạng sau:
    /// Nhap ho ten cua ban: Tran Anh Minh
    /// Chao ban Tran Anh Minh!
    /// </summary>
    public static class Bai02_XuatNhapChuoi
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 2
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("                  BÀI 2: XUẤT VÀ NHẬP CHUỖI                      ");
            Console.WriteLine("==================================================================");

            // In thông báo yêu cầu người dùng nhập họ tên đúng định dạng đề bài
            Console.Write("Nhap ho ten cua ban: ");

            // Đọc dữ liệu chuỗi người dùng nhập từ bàn phím
            string? hoTen = Console.ReadLine();

            // Xuất câu chào mừng theo đúng định dạng mẫu yêu cầu
            Console.WriteLine($"Chao ban {hoTen}!");
            Console.WriteLine("==================================================================");
        }
    }
}
