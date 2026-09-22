using System;

namespace ThucHanh02.Phan3_KeThuaDaHinh
{
    /// <summary>
    /// BÀI 3.1: SẮP XẾP ĐỐI TƯỢNG BẰNG PHƯƠNG THỨC TĨNH Array.Sort(...) DÙNG IComparable
    /// </summary>
    public class SinhVienSortable : IComparable<SinhVienSortable>
    {
        public string MaSV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public double DiemTB { get; set; }

        public SinhVienSortable() { }

        public SinhVienSortable(string maSV, string hoTen, double diemTB)
        {
            MaSV = maSV ?? "";
            HoTen = hoTen ?? "";
            DiemTB = diemTB;
        }

        // Cài đặt IComparable để sắp xếp theo Điểm Trung Bình tăng dần (hoặc họ tên)
        public int CompareTo(SinhVienSortable? other)
        {
            if (other == null) return 1;
            // Sắp xếp tăng dần theo Điểm TB
            return DiemTB.CompareTo(other.DiemTB);
        }

        public override string ToString()
        {
            return $"[{MaSV}] {HoTen,-20} - DTB: {DiemTB:F2}";
        }
    }

    public static class Bai3_1_Demo
    {
        public static void ChayDemo()
        {
            SinhVienSortable[] ds = new SinhVienSortable[]
            {
                new SinhVienSortable("SV01", "Nguyen Van An", 7.5),
                new SinhVienSortable("SV02", "Tran Thi Binh", 8.8),
                new SinhVienSortable("SV03", "Le Van Cuong", 6.2),
                new SinhVienSortable("SV04", "Pham Thi Dung", 9.1)
            };

            Console.WriteLine("--- Danh sach truoc khi sap xep ---");
            foreach (var sv in ds) Console.WriteLine(sv);

            // Sắp xếp bằng phương thức tĩnh Array.Sort
            Array.Sort(ds);

            Console.WriteLine("\n--- Danh sach sau khi Array.Sort (theo DiemTB tang dan) ---");
            foreach (var sv in ds) Console.WriteLine(sv);
        }
    }
}
