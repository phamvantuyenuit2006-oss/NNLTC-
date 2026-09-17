using System;

namespace NNLTC.Phan4_XayDungLop
{
    /// <summary>
    /// BÀI 14: TÍNH LƯƠNG 1 NHÂN VIÊN
    /// </summary>
    public class NhanVien
    {
        // 1. Thuộc tính
        public string HoTen { get; set; } = string.Empty;
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        // 2. Constructors
        public NhanVien() { }

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            HoTen = hoTen;
            MucLuong = mucLuong;
            SoNgayVang = soNgayVang;
        }

        // 3. Phương thức tính lương: mỗi ngày vắng trừ 100.000 VNĐ
        public double TinhLuongThucLanh()
        {
            double luong = MucLuong - (SoNgayVang * 100000);
            return luong > 0 ? luong : 0;
        }

        // 4. Nhập thông tin nhân viên
        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap muc luong co ban (VND): ");
            MucLuong = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine() ?? "0");
        }

        // 5. Xuất bảng lương
        public void Xuat()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Ho va ten       : {HoTen}");
            Console.WriteLine($"Muc luong goc   : {MucLuong:N0} VND");
            Console.WriteLine($"So ngay vang    : {SoNgayVang} ngay");
            Console.WriteLine($"Tien phat vang  : {SoNgayVang * 100000:N0} VND");
            Console.WriteLine($"Luong thuc lanh : {TinhLuongThucLanh():N0} VND");
            Console.WriteLine("------------------------------------------");
        }
    }

    public static class Bai14_TinhLuongNhanVien
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 14: TÍNH LƯƠNG NHÂN VIÊN ===");

            NhanVien nv = new NhanVien();

            Console.WriteLine("--- NHAP THONG TIN NHAN VIEN ---");
            nv.Nhap();

            Console.WriteLine("\n--- KET QUA PHIEU LUONG ---");
            nv.Xuat();
        }
    }
}
