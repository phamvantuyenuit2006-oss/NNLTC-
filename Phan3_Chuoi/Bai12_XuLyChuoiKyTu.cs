using System;

namespace NNLTC.Phan3_Chuoi
{
    /// <summary>
    /// BÀI 12: XỬ LÝ CHUỖI (CHỮ THƯỜNG, CHỮ HOA, ĐẾM SỐ TỪ)
    /// </summary>
    public class XuLyChuoi
    {
        public static string ChuyenSangChuThuong(string s)
        {
            return s.ToLower();
        }

        public static string ChuyenSangChuHoa(string s)
        {
            return s.ToUpper();
        }

        public static int DemSoTu(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            // Tách các từ dựa trên khoảng trắng và tab, loại bỏ khoảng trắng thừa
            string[] mangTu = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return mangTu.Length;
        }
    }

    public static class Bai12_XuLyChuoiKyTu
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 12: XỬ LÝ CHUỖI KÝ TỰ ===");

            Console.Write("Nhap mot chuoi gom nhieu tu: ");
            string s = Console.ReadLine() ?? "";

            Console.WriteLine("\n--- KET QUA ---");
            Console.WriteLine($"1. Chuoi chu thuong : {XuLyChuoi.ChuyenSangChuThuong(s)}");
            Console.WriteLine($"2. Chuoi chu hoa    : {XuLyChuoi.ChuyenSangChuHoa(s)}");
            Console.WriteLine($"3. So luong tu      : {XuLyChuoi.DemSoTu(s)} tu");
        }
    }
}
