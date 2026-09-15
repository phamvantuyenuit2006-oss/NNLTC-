using System;

namespace NNLTC.Phan4_XayDungLop
{
    /// <summary>
    /// BÀI 13: XÂY DỰNG LỚP CƠ BẢN (LỚP SINH VIÊN)
    /// Yêu cầu:
    /// Xây dựng lớp sinh viên để lưu trữ 1 sinh viên (mã sinh viên, họ tên, địa chỉ, sinh viên năm thứ mấy).
    /// Hãy nhập xuất 1 sinh viên.
    /// Minh họa đầy đủ: Fields, Properties, Constructors, Methods (Nhập, Xuất).
    /// </summary>
    public class SinhVien
    {
        // 1. Các trường dữ liệu (Fields) / Thuộc tính (Properties)
        // Áp dụng tính đóng gói (Encapsulation) với auto-implemented properties
        public string MaSV { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public int NamThuMay { get; set; }

        // 2. Constructors (Hàm khởi tạo)
        /// <summary>
        /// Constructor mặc định (không tham số)
        /// </summary>
        public SinhVien()
        {
        }

        /// <summary>
        /// Constructor đầy đủ tham số
        /// </summary>
        public SinhVien(string maSV, string hoTen, string diaChi, int namThuMay)
        {
            MaSV = maSV;
            HoTen = hoTen;
            DiaChi = diaChi;
            NamThuMay = namThuMay;
        }

        // 3. Các phương thức thành viên (Methods)
        /// <summary>
        /// Phương thức nhập thông tin của 1 sinh viên từ bàn phím
        /// </summary>
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine() ?? "";

            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? "";

            // Nhập và kiểm tra tính hợp lệ của năm học (1 đến 6)
            while (true)
            {
                Console.Write("Nhap sinh vien nam thu may (1-6): ");
                if (int.TryParse(Console.ReadLine(), out int nam) && nam >= 1 && nam <= 6)
                {
                    NamThuMay = nam;
                    break;
                }
                Console.WriteLine("Nam hoc khong hop le! Vui long nhap so tu 1 den 6.");
            }
        }

        /// <summary>
        /// Phương thức xuất thông tin của sinh viên ra màn hình Console
        /// </summary>
        public void Xuat()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Ma SV       : {MaSV}");
            Console.WriteLine($"Ho va ten   : {HoTen}");
            Console.WriteLine($"Dia chi     : {DiaChi}");
            Console.WriteLine($"Sinh vien   : Nam thu {NamThuMay}");
            Console.WriteLine("------------------------------------------");
        }
    }

    public static class Bai13_QuanLySinhVien
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 13
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("        BÀI 13: XÂY DỰNG LỚP SINH VIÊN (NHẬP & XUẤT THÔNG TIN)   ");
            Console.WriteLine("==================================================================");

            // Khởi tạo đối tượng SinhVien bằng Constructor mặc định
            SinhVien sv = new SinhVien();

            // Gọi phương thức Nhap() của đối tượng
            Console.WriteLine("--- NHAP THONG TIN SINH VIEN ---");
            sv.Nhap();

            // Gọi phương thức Xuat() của đối tượng
            Console.WriteLine("\n--- THONG TIN SINH VIEN VUA NHAP ---");
            sv.Xuat();
            Console.WriteLine("==================================================================");
        }
    }
}
