using System;

namespace NNLTC.Phan5_MangArrayList
{
    /// <summary>
    /// BÀI 16: SẮP XẾP MẢNG HỌ TÊN CỦA N NGƯỜI TĂNG DẦN
    /// </summary>
    public static class Bai16_SapXepHoTen
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 16: SẮP XẾP MẢNG HỌ TÊN N NGƯỜI TĂNG DẦN ===");

            Console.Write("Nhap so luong nguoi n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            string[] ds = new string[n];

            // 1. Nhập họ tên từng người
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten nguoi thu {i + 1}: ");
                ds[i] = Console.ReadLine() ?? "";
            }

            // 2. Sắp xếp mảng chuỗi tăng dần theo thứ tự bảng chữ cái
            Array.Sort(ds);

            // 3. Xuất danh sách sau khi đã sắp xếp
            Console.WriteLine("\n--- DANH SACH SAU KHI SAP XEP (A - Z) ---");
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ds[i]}");
            }
        }
    }
}
