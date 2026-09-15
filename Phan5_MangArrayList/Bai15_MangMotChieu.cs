using System;
using System.Collections.Generic;

namespace NNLTC.Phan5_MangArrayList
{
    /// <summary>
    /// BÀI 15: MẢNG MỘT CHIỀU & DANH SÁCH SỐ NGUYÊN TỐ
    /// Yêu cầu: Viết các phương thức thành viên sau:
    /// • Nhập mảng gồm n phần tử
    /// • In mảng ra màn hình
    /// • Tìm phần tử lớn nhất và nhỏ nhất trong mảng
    /// • Trả về mảng các số nguyên tố
    /// </summary>
    public class MangMotChieuHelper
    {
        /// <summary>
        /// Phương thức nhập mảng gồm n số nguyên từ bàn phím
        /// </summary>
        /// <param name="n">Số phần tử của mảng</param>
        /// <returns>Mảng các số nguyên int[]</returns>
        public static int[] NhapMang(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"A[{i}] = ");
                    if (int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        break;
                    }
                    Console.WriteLine("Gia tri khong hop le! Vui long nhap so nguyen.");
                }
            }
            return arr;
        }

        /// <summary>
        /// Phương thức in mảng các số nguyên ra màn hình
        /// </summary>
        /// <param name="arr">Mảng cần in</param>
        /// <param name="tieuDe">Tiêu đề hiển thị</param>
        public static void InMang(int[] arr, string tieuDe = "Mang")
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine($"{tieuDe}: [Rỗng]");
                return;
            }
            Console.WriteLine($"{tieuDe}: [{string.Join(", ", arr)}]");
        }

        /// <summary>
        /// Phương thức tìm phần tử lớn nhất và nhỏ nhất trong mảng sử dụng tham số out
        /// </summary>
        /// <param name="arr">Mảng đầu vào</param>
        /// <param name="max">Giá trị lớn nhất</param>
        /// <param name="min">Giá trị nhỏ nhất</param>
        public static void TimMaxMin(int[] arr, out int max, out int min)
        {
            if (arr == null || arr.Length == 0)
            {
                max = 0;
                min = 0;
                return;
            }

            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }

        /// <summary>
        /// Hàm phụ trợ kiểm tra 1 số nguyên có phải số nguyên tố hay không
        /// </summary>
        /// <param name="num">Số nguyên cần kiểm tra</param>
        /// <returns>true nếu là số nguyên tố, ngược lại false</returns>
        public static bool LaSoNguyenTo(int num)
        {
            if (num < 2) return false;
            int canBacHai = (int)Math.Sqrt(num);
            for (int i = 2; i <= canBacHai; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Phương thức lọc và trả về một mảng chứa các số nguyên tố có trong mảng ban đầu
        /// </summary>
        /// <param name="arr">Mảng số nguyên đầu vào</param>
        /// <returns>Mảng int[] các số nguyên tố</returns>
        public static int[] LayDanhSachSoNguyenTo(int[] arr)
        {
            List<int> primeList = new List<int>();
            foreach (int item in arr)
            {
                if (LaSoNguyenTo(item))
                {
                    primeList.Add(item);
                }
            }
            return primeList.ToArray();
        }
    }

    public static class Bai15_MangMotChieu
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 15
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("   BÀI 15: MẢNG 1 CHIỀU (NHẬP, XUẤT, TÌM MAX/MIN, SỐ NGUYÊN TỐ)   ");
            Console.WriteLine("==================================================================");

            int n;
            while (true)
            {
                Console.Write("Nhap so luong phan tu n (n > 0): ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("So phan tu phai la so nguyen duong!");
            }

            // 1. Nhập mảng
            int[] arr = MangMotChieuHelper.NhapMang(n);

            Console.WriteLine("\n--- KET QUA ---");
            // 2. In mảng
            MangMotChieuHelper.InMang(arr, "Mang vua nhap");

            // 3. Tìm phần tử lớn nhất và nhỏ nhất
            MangMotChieuHelper.TimMaxMin(arr, out int max, out int min);
            Console.WriteLine($"Phan tu lon nhat (Max): {max}");
            Console.WriteLine($"Phan tu nho nhat (Min): {min}");

            // 4. Trả về mảng các số nguyên tố
            int[] mangSNT = MangMotChieuHelper.LayDanhSachSoNguyenTo(arr);
            MangMotChieuHelper.InMang(mangSNT, "Mang cac so nguyen to");
            Console.WriteLine("==================================================================");
        }
    }
}
