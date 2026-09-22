using System;
using System.Collections.Generic;

namespace ThucHanh02.Phan2_ThietKeLopNangCao
{
    /// <summary>
    /// Nhân viên trong phòng ban
    /// </summary>
    public class NhanVienPhongBan
    {
        public string HoTen { get; set; } = "";
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public NhanVienPhongBan() { }

        public NhanVienPhongBan(string hoTen, double mucLuong, int soNgayVang)
        {
            HoTen = hoTen ?? "";
            MucLuong = mucLuong >= 0 ? mucLuong : 0;
            SoNgayVang = soNgayVang >= 0 ? soNgayVang : 0;
        }

        // Luong thuc lanh = MucLuong - SoNgayVang * 100.000 (khong am)
        public double TinhLuong()
        {
            double tienPhat = SoNgayVang * 100000.0;
            double luong = MucLuong - tienPhat;
            return luong > 0 ? luong : 0;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap muc luong co ban: ");
            double.TryParse(Console.ReadLine(), out double ml);
            MucLuong = ml;

            Console.Write("Nhap so ngay vang: ");
            int.TryParse(Console.ReadLine(), out int snv);
            SoNgayVang = snv;
        }

        public void Output()
        {
            Console.WriteLine($"NV: {HoTen,-20} | Muc luong: {MucLuong,12:N0} | Ngay vang: {SoNgayVang,2} | Thuc lanh: {TinhLuong(),12:N0} VND");
        }

        public override string ToString()
        {
            return $"{HoTen} ({TinhLuong():N0} VND)";
        }
    }

    /// <summary>
    /// BÀI 2.5: TÍNH TỔNG LƯƠNG NHÂN VIÊN PHÒNG BAN
    /// </summary>
    public class PhongBan
    {
        public string TenPhongBan { get; set; } = "Phong Ban";
        private List<NhanVienPhongBan> _danhSach;

        public int Count => _danhSach.Count;

        public NhanVienPhongBan this[int index]
        {
            get => _danhSach[index];
            set => _danhSach[index] = value;
        }

        public PhongBan(string tenPhongBan = "Phong Ban")
        {
            TenPhongBan = tenPhongBan;
            _danhSach = new List<NhanVienPhongBan>();
        }

        public void Add(NhanVienPhongBan nv)
        {
            if (nv != null)
            {
                _danhSach.Add(nv);
            }
        }

        // Tính tổng lương của phòng ban
        public double TinhTongLuong()
        {
            double tong = 0;
            foreach (var nv in _danhSach)
            {
                tong += nv.TinhLuong();
            }
            return tong;
        }

        public void Input()
        {
            Console.Write("Nhap ten phong ban: ");
            TenPhongBan = Console.ReadLine() ?? "Phong Ban";

            Console.Write("Nhap so luong nhan vien: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                _danhSach.Clear();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhap thong tin nhan vien {i + 1} ---");
                    var nv = new NhanVienPhongBan();
                    nv.Input();
                    _danhSach.Add(nv);
                }
            }
        }

        public void Output()
        {
            Console.WriteLine($"\n=======================================================");
            Console.WriteLine($"  DANH SACH NHAN VIEN - {TenPhongBan.ToUpper()}");
            Console.WriteLine($"=======================================================");
            for (int i = 0; i < _danhSach.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                _danhSach[i].Output();
            }
            Console.WriteLine($"-------------------------------------------------------");
            Console.WriteLine($" >> TONG LUONG PHONG BAN: {TinhTongLuong():N0} VND");
            Console.WriteLine($"=======================================================");
        }
    }
}
