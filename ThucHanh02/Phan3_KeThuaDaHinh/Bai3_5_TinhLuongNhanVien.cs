using System;
using System.Collections.Generic;

namespace ThucHanh02.Phan3_KeThuaDaHinh
{
    /// <summary>
    /// BÀI 3.5: LỚP TRỪU TƯỢNG NHÂN VIÊN (KẾ THỪA & ĐA HÌNH)
    /// </summary>
    public abstract class NhanVien
    {
        public string MaNV { get; set; } = "";
        public string HoTen { get; set; } = "";

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen)
        {
            MaNV = maNV ?? "";
            HoTen = hoTen ?? "";
        }

        // Phương thức trừu tượng tính lương
        public abstract double TinhLuong();

        public virtual void Input()
        {
            Console.Write("Nhap Ma NV: ");
            MaNV = Console.ReadLine() ?? "";

            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine() ?? "";
        }

        public virtual void Output()
        {
            Console.Write($"[{MaNV}] {HoTen,-20} | ");
        }
    }

    /// <summary>
    /// Nhân viên kinh doanh: Lương = Lương cơ bản + 500.000 * Số hợp đồng
    /// </summary>
    public class NhanVienKinhDoanh : NhanVien
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }

        public NhanVienKinhDoanh() : base() { }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, int soHopDong)
            : base(maNV, hoTen)
        {
            LuongCoBan = luongCoBan >= 0 ? luongCoBan : 0;
            SoHopDong = soHopDong >= 0 ? soHopDong : 0;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoHopDong * 500000.0;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Luong co ban: ");
            double.TryParse(Console.ReadLine(), out double lcb);
            LuongCoBan = lcb;

            Console.Write("Nhap So hop dong ky ket: ");
            int.TryParse(Console.ReadLine(), out int shd);
            SoHopDong = shd;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"[Kinh Doanh] LCB: {LuongCoBan,12:N0} | Hop dong: {SoHopDong,2} | Tong luong: {TinhLuong(),12:N0} VND");
        }
    }

    /// <summary>
    /// Nhân viên sản xuất: Lương = Sản phẩm * 1000. Nếu > 3000 sp thì thưởng thêm 5% lương
    /// </summary>
    public class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }

        public NhanVienSanXuat() : base() { }

        public NhanVienSanXuat(string maNV, string hoTen, int soSanPham)
            : base(maNV, hoTen)
        {
            SoSanPham = soSanPham >= 0 ? soSanPham : 0;
        }

        public override double TinhLuong()
        {
            double luongGoc = SoSanPham * 1000.0;
            if (SoSanPham > 3000)
            {
                // Thuong them 5%
                return luongGoc * 1.05;
            }
            return luongGoc;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap So luong san pham: ");
            int.TryParse(Console.ReadLine(), out int sp);
            SoSanPham = sp;
        }

        public override void Output()
        {
            base.Output();
            string thuong = SoSanPham > 3000 ? "(Thuong 5%)" : "";
            Console.WriteLine($"[San Xuat]   San pham: {SoSanPham,4} {thuong,-12} | Tong luong: {TinhLuong(),12:N0} VND");
        }
    }

    /// <summary>
    /// Quản lý danh sách nhân viên công ty
    /// </summary>
    public class CongTy
    {
        private List<NhanVien> _danhSach = new List<NhanVien>();

        public void Add(NhanVien nv)
        {
            if (nv != null) _danhSach.Add(nv);
        }

        public double TinhTongLuong()
        {
            double tong = 0;
            foreach (var nv in _danhSach)
            {
                tong += nv.TinhLuong();
            }
            return tong;
        }

        public void Output()
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("        DANH SACH NHAN VIEN CONG TY VA TIEN LUONG      ");
            Console.WriteLine("=======================================================");
            for (int i = 0; i < _danhSach.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                _danhSach[i].Output();
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($" >> TONG LUONG CONG TY: {TinhTongLuong():N0} VND");
            Console.WriteLine("=======================================================");
        }
    }
}
