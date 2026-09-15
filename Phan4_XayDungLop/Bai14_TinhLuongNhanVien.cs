using System;

namespace NNLTC.Phan4_XayDungLop
{
    /// <summary>
    /// BÀI 14: TÍNH LƯƠNG 1 NHÂN VIÊN
    /// Yêu cầu:
    /// Viết chương trình nhập thông tin một nhân viên (họ tên, mức lương, số ngày vắng).
    /// Tính và xuất lương của nhân viên, biết rằng một ngày vắng sẽ bị trừ 100.000 VNĐ.
    /// </summary>
    public class NhanVien
    {
        // 1. Hằng số tiền phạt cho mỗi ngày vắng
        private const double TienPhatMoiNgayVang = 100000;

        // 2. Các thuộc tính (Properties)
        public string HoTen { get; set; } = string.Empty;
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        // 3. Constructors
        public NhanVien() { }

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            HoTen = hoTen;
            MucLuong = mucLuong;
            SoNgayVang = soNgayVang;
        }

        // 4. Phương thức nghiệp vụ: Tính lương thực lãnh
        /// <summary>
        /// Tính lương thực lãnh = Mức lương - (Số ngày vắng * 100.000)
        /// Nếu lương thực lãnh < 0 thì trả về 0
        /// </summary>
        /// <returns>Lương thực lãnh sau khi trừ phạt</returns>
        public double TinhLuongThucLanh()
        {
            double luong = MucLuong - (SoNgayVang * TienPhatMoiNgayVang);
            return luong > 0 ? luong : 0;
        }

        // 5. Phương thức Nhập thông tin nhân viên
        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine() ?? "";

            // Nhập mức lương cơ bản (kiểm tra >= 0)
            while (true)
            {
                Console.Write("Nhap muc luong co ban (VND): ");
                if (double.TryParse(Console.ReadLine(), out double luong) && luong >= 0)
                {
                    MucLuong = luong;
                    break;
                }
                Console.WriteLine("Muc luong khong hop le! Vui long nhap so duong.");
            }

            // Nhập số ngày vắng (kiểm tra >= 0)
            while (true)
            {
                Console.Write("Nhap so ngay vang: ");
                if (int.TryParse(Console.ReadLine(), out int ngayVang) && ngayVang >= 0)
                {
                    SoNgayVang = ngayVang;
                    break;
                }
                Console.WriteLine("So ngay vang phai la so nguyen khong am!");
            }
        }

        // 6. Phương thức Xuất bảng lương nhân viên
        public void Xuat()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Ho va ten       : {HoTen}");
            Console.WriteLine($"Muc luong goc   : {MucLuong:N0} VND");
            Console.WriteLine($"So ngay vang    : {SoNgayVang} ngay");
            Console.WriteLine($"Tien phat vang  : {SoNgayVang * TienPhatMoiNgayVang:N0} VND (-100.000 VND/ngay)");
            Console.WriteLine($"Luong thuc lanh : {TinhLuongThucLanh():N0} VND");
            Console.WriteLine("------------------------------------------");
        }
    }

    public static class Bai14_TinhLuongNhanVien
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 14
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("         BÀI 14: TÍNH LƯƠNG NHÂN VIÊN (TRỪ PHẠT NGÀY VẮNG)        ");
            Console.WriteLine("==================================================================");

            NhanVien nv = new NhanVien();
            Console.WriteLine("--- NHAP THONG TIN NHAN VIEN ---");
            nv.Nhap();

            Console.WriteLine("\n--- KET QUA PHIEU LUONG ---");
            nv.Xuat();
            Console.WriteLine("==================================================================");
        }
    }
}
