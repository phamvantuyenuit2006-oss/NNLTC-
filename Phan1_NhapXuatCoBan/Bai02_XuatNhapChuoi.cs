using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    public static class Bai02_XuatNhapChuoi
    {
        public static void Chay() 
        {
            Console.WriteLine("=== BÀI 2: XUẤT VÀ NHẬP CHUỖI ==="); // In ra thông báo

            Console.Write("Nhap ho ten cua ban: "); // Yêu cầu người dùng nhập họ tên
            string? hoTen = Console.ReadLine(); // Đọc chuỗi nhập từ bàn phím và lưu vào biến hoTen

            Console.WriteLine($"Chao ban {hoTen}!"); // In ra lời chào kèm theo họ tên vừa nhập
        }
    }
}
