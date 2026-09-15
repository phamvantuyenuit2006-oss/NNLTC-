using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 8: THAM CHIẾU REF (REFERENCE PARAMETERS)
    /// Yêu cầu:
    /// Xây dựng lớp có phương thức hoán vị hai số thực.
    /// Từ khóa 'ref' cho phép truyền tham chiếu: biến phải được khởi tạo trước khi truyền vào,
    /// và phương thức có thể đọc và ghi trực tiếp lên vùng nhớ của biến bên ngoài.
    /// </summary>
    public class HoanViHelper
    {
        /// <summary>
        /// Phương thức hoán vị giá trị của 2 số thực sử dụng từ khóa 'ref'
        /// </summary>
        /// <param name="a">Tham số tham chiếu đến biến số thực a</param>
        /// <param name="b">Tham số tham chiếu đến biến số thực b</param>
        public static void HoanVi(ref double a, ref double b)
        {
            // Sử dụng biến tạm để lưu giá trị ban đầu của a
            double temp = a;
            // Gán giá trị của b vào ô nhớ a
            a = b;
            // Gán giá trị tạm vào ô nhớ b
            b = temp;
        }
    }

    public static class Bai08_HoanViSoThuc
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 8
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("             BÀI 8: HOÁN VỊ HAI SỐ THỰC (THAM CHIẾU REF)          ");
            Console.WriteLine("==================================================================");

            // Nhập 2 số thực từ bàn phím
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine() ?? "0");

            // Hiển thị giá trị trước khi gọi hàm hoán vị
            Console.WriteLine("\n--- KET QUA ---");
            Console.WriteLine($"Truoc khi hoan vi : a = {a}, b = {b}");

            // Khi gọi phương thức có tham số ref, bắt buộc phải kèm từ khóa 'ref' trước mỗi biến
            HoanViHelper.HoanVi(ref a, ref b);

            // Hiển thị giá trị sau khi hoán vị (giá trị của a và b bên ngoài đã được thay đổi)
            Console.WriteLine($"Sau khi hoan vi   : a = {a}, b = {b}");
            Console.WriteLine("==================================================================");
        }
    }
}
