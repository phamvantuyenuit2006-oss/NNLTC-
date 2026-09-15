using System;

namespace NNLTC.Phan2_ThamSoPhuongThuc
{
    /// <summary>
    /// BÀI 6: RETURN GIÁ TRỊ - TRUYỀN THAM SỐ BẰNG THAM TRỊ (PASS-BY-VALUE)
    /// Yêu cầu:
    /// Xây dựng lớp có phương thức tìm giá trị lớn nhất của ba số nguyên.
    /// </summary>
    public class TimMax
    {
        /// <summary>
        /// Phương thức tìm số lớn nhất trong ba số nguyên
        /// Truyền tham số bằng tham trị: các bản sao của a, b, c được truyền vào phương thức,
        /// biến gốc bên ngoài không bị thay đổi.
        /// </summary>
        /// <param name="a">Số nguyên thứ nhất</param>
        /// <param name="b">Số nguyên thứ hai</param>
        /// <param name="c">Số nguyên thứ ba</param>
        /// <returns>Giá trị lớn nhất (int) trong 3 số</returns>
        public static int TimGiaTriLonNhat(int a, int b, int c)
        {
            // Giả sử số đầu tiên a là lớn nhất
            int max = a;

            // So sánh max với b
            if (b > max)
            {
                max = b;
            }

            // So sánh max với c
            if (c > max)
            {
                max = c;
            }

            // Trả về giá trị lớn nhất tìm được
            return max;
        }

        /// <summary>
        /// Phương thức mở rộng minh họa từ khóa 'params' (Mục tiêu thực hành: tham trị, ref, out, params)
        /// Cho phép truyền vào số lượng tham số tùy ý (hoặc một mảng int[]).
        /// </summary>
        /// <param name="danhSach">Danh sách các số nguyên truyền vào</param>
        /// <returns>Giá trị lớn nhất trong danh sách</returns>
        public static int TimGiaTriLonNhat(params int[] danhSach)
        {
            if (danhSach == null || danhSach.Length == 0)
            {
                throw new ArgumentException("Danh sách số nguyên không được để trống!");
            }

            int max = danhSach[0];
            foreach (int item in danhSach)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }

    public static class Bai06_TimMaxBaSo
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 6
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("    BÀI 6: TÌM GIÁ TRỊ LỚN NHẤT CỦA 3 SỐ NGUYÊN (RETURN GIÁ TRỊ) ");
            Console.WriteLine("==================================================================");

            // Nhập 3 số nguyên từ bàn phím
            Console.Write("Nhap so nguyen thu nhat (a): ");
            int a = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so nguyen thu hai (b): ");
            int b = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so nguyen thu ba (c): ");
            int c = int.Parse(Console.ReadLine() ?? "0");

            // Gọi phương thức tĩnh từ lớp TimMax để nhận giá trị lớn nhất
            int max = TimMax.TimGiaTriLonNhat(a, b, c);

            // In kết quả ra màn hình
            Console.WriteLine($"\n=> Gia tri lon nhat trong 3 so ({a}, {b}, {c}) la: {max}");
            Console.WriteLine("==================================================================");
        }
    }
}
