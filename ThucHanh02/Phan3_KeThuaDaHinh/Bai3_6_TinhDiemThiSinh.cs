using System;
using System.Collections.Generic;

namespace ThucHanh02.Phan3_KeThuaDaHinh
{
    /// <summary>
    /// BÀI 3.6: LỚP CƠ SỞ THÍ SINH (CUỘC THI TIN HỌC)
    /// </summary>
    public abstract class ThiSinh
    {
        public string SBD { get; set; } = "";
        public string HoTen { get; set; } = "";
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }

        public ThiSinh() { }

        public ThiSinh(string sbd, string hoTen, double b1, double b2, double b3)
        {
            SBD = sbd ?? "";
            HoTen = hoTen ?? "";
            Bai1 = b1;
            Bai2 = b2;
            Bai3 = b3;
        }

        // Điểm 3 bài thi lập trình
        public double TongDiemLapTrinh()
        {
            return Bai1 + Bai2 + Bai3;
        }

        // Phương thức trừu tượng tính tổng điểm cuối cùng
        public abstract double TinhTongDiem();

        public virtual void Input()
        {
            Console.Write("Nhap So bao danh (SBD): ");
            SBD = Console.ReadLine() ?? "";

            Console.Write("Nhap Ho ten: ");
            HoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap diem Bai 1: "); double.TryParse(Console.ReadLine(), out double b1); Bai1 = b1;
            Console.Write("Nhap diem Bai 2: "); double.TryParse(Console.ReadLine(), out double b2); Bai2 = b2;
            Console.Write("Nhap diem Bai 3: "); double.TryParse(Console.ReadLine(), out double b3); Bai3 = b3;
        }

        public virtual void Output()
        {
            Console.Write($"[{SBD}] {HoTen,-20} | B1: {Bai1,4:F1} | B2: {Bai2,4:F1} | B3: {Bai3,4:F1} | ");
        }
    }

    /// <summary>
    /// Thí sinh Chuyên: Làm 3 bài lập trình + Bài Tiếng Anh (xét điểm thưởng)
    /// </summary>
    public class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }

        public ThiSinhChuyen() : base() { }

        public ThiSinhChuyen(string sbd, string hoTen, double b1, double b2, double b3, double tiengAnh)
            : base(sbd, hoTen, b1, b2, b3)
        {
            TiengAnh = tiengAnh;
        }

        // Tính điểm thưởng Tiếng Anh:
        // 7 <= TiengAnh <= 8: cong 1 diem
        // 9 <= TiengAnh <= 10: cong 2 diem
        public double TinhDiemThuongTiengAnh()
        {
            if (TiengAnh >= 9.0 && TiengAnh <= 10.0) return 2.0;
            if (TiengAnh >= 7.0 && TiengAnh < 9.0) return 1.0;
            return 0.0;
        }

        public override double TinhTongDiem()
        {
            return TongDiemLapTrinh() + TinhDiemThuongTiengAnh();
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem Tieng Anh: ");
            double.TryParse(Console.ReadLine(), out double ta);
            TiengAnh = ta;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"[CHUYEN] TA: {TiengAnh,4:F1} (+{TinhDiemThuongTiengAnh()}d) | TONG DIEM: {TinhTongDiem(),5:F1}");
        }
    }

    /// <summary>
    /// Thí sinh Siêu cúp: Tổng điểm của 4 bài thi (3 bài lập trình + 1 bài CSDL)
    /// </summary>
    public class ThiSinhSieuCup : ThiSinh
    {
        public double CSDL { get; set; }

        public ThiSinhSieuCup() : base() { }

        public ThiSinhSieuCup(string sbd, string hoTen, double b1, double b2, double b3, double csdl)
            : base(sbd, hoTen, b1, b2, b3)
        {
            CSDL = csdl;
        }

        public override double TinhTongDiem()
        {
            return TongDiemLapTrinh() + CSDL;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem Co So Du Lieu (CSDL): ");
            double.TryParse(Console.ReadLine(), out double db);
            CSDL = db;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"[SIEU CUP] CSDL: {CSDL,4:F1}          | TONG DIEM: {TinhTongDiem(),5:F1}");
        }
    }

    /// <summary>
    /// Lớp quản lý Cuộc thi Tin học
    /// </summary>
    public class CuocThiTinHoc
    {
        public string TenCuocThi { get; set; } = "Cuoc Thi Tin Hoc";
        private List<ThiSinh> _danhSach = new List<ThiSinh>();

        public void Add(ThiSinh ts)
        {
            if (ts != null) _danhSach.Add(ts);
        }

        public void Input()
        {
            Console.Write("Nhap ten cuoc thi: ");
            TenCuocThi = Console.ReadLine() ?? "Cuoc Thi Tin Hoc";

            Console.Write("Nhap so luong thi sinh: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                _danhSach.Clear();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhap thi sinh thu {i + 1} ---");
                    Console.Write("Chon doi tuong (1 - Chuyen, 2 - Sieu Cup): ");
                    string? loai = Console.ReadLine()?.Trim();

                    ThiSinh ts;
                    if (loai == "2")
                    {
                        ts = new ThiSinhSieuCup();
                    }
                    else
                    {
                        ts = new ThiSinhChuyen();
                    }
                    ts.Input();
                    _danhSach.Add(ts);
                }
            }
        }

        public void Output()
        {
            Console.WriteLine("\n=========================================================================");
            Console.WriteLine($"           KET QUA CUOC THI: {TenCuocThi.ToUpper()}");
            Console.WriteLine("=========================================================================");
            for (int i = 0; i < _danhSach.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                _danhSach[i].Output();
            }
            Console.WriteLine("=========================================================================");
        }
    }
}
