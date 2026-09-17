using System;

namespace NNLTC.Phan4_XayDungLop
{
    /// <summary>
    /// BÀI 13: XÂY DỰNG LỚP SINH VIÊN (OOP CƠ BẢN)
    /// </summary>
    public class SinhVien
    {
        // 1. Các thuộc tính
        public string MaSV { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public int NamThuMay { get; set; }

        // 2. Hàm khởi tạo (Constructors)
        public SinhVien() { }

        public SinhVien(string maSV, string hoTen, string diaChi, int namThuMay)
        {
            MaSV = maSV;
            HoTen = hoTen;
            DiaChi = diaChi;
            NamThuMay = namThuMay;
        }

        // 3. Phương thức Nhập thông tin
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine() ?? "";

            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? "";

            Console.Write("Nhap sinh vien nam thu may: ");
            NamThuMay = int.Parse(Console.ReadLine() ?? "1");
        }

        // 4. Phương thức Xuất thông tin
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
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 13: XÂY DỰNG LỚP SINH VIÊN ===");

            SinhVien sv = new SinhVien();

            Console.WriteLine("--- NHAP THONG TIN SINH VIEN ---");
            sv.Nhap();

            Console.WriteLine("\n--- THONG TIN SINH VIEN VUA NHAP ---");
            sv.Xuat();
        }
    }
}
