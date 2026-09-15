using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 9: THAM CHIẾU OUT (OUTPUT PARAMETERS)
    /// Yêu cầu:
    /// Xây dựng lớp có phương thức tìm giá trị lớn nhất và giá trị nhỏ nhất của ba số thực.
    /// Từ khóa 'out' cho phép phương thức trả về nhiều giá trị thông qua các tham số đầu ra.
    /// Khác với 'ref', biến truyền vào 'out' không bắt buộc phải khởi tạo trước,
    /// nhưng phương thức bên trong BẮT BUỘC phải gán giá trị cho tất cả tham số 'out' trước khi kết thúc.
    /// </summary>
    public class MaxMinHelper
    {
        /// <summary>
        /// Phương thức tìm cả giá trị lớn nhất (max) và nhỏ nhất (min) trong 3 số thực
        /// </summary>
        /// <param name="a">Số thực thứ 1</param>
        /// <param name="b">Số thực thứ 2</param>
        /// <param name="c">Số thực thứ 3</param>
        /// <param name="max">Tham số out trả về giá trị lớn nhất</param>
        /// <param name="min">Tham số out trả về giá trị nhỏ nhất</param>
        public static void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            // 1. Tìm giá trị lớn nhất (Max)
            max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            // 2. Tìm giá trị nhỏ nhất (Min)
            min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
        }
    }

    public static class Bai09_TimMaxMinBaSoThuc
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 9
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("        BÀI 9: TÌM MAX VÀ MIN CỦA 3 SỐ THỰC (THAM CHIẾU OUT)      ");
            Console.WriteLine("==================================================================");

            // Nhập 3 số thực từ bàn phím
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine() ?? "0");

            // Khai báo các biến nhận kết quả out trực tiếp khi gọi hàm (out double max, out double min)
            MaxMinHelper.TimMaxMin(a, b, c, out double max, out double min);

            // Xuất kết quả
            Console.WriteLine("\n--- KET QUA ---");
            Console.WriteLine($"- Gia tri lon nhat (Max): {max}");
            Console.WriteLine($"- Gia tri nho nhat (Min): {min}");
            Console.WriteLine("==================================================================");
        }
    }
}
