using System;
using System.Collections.Generic;

namespace NNLTC.Phan5_MangArrayList
{
    /// <summary>
    /// BÀI 15: MẢNG MỘT CHIỀU & DANH SÁCH SỐ NGUYÊN TỐ
    /// </summary>
    public class MangMotChieuHelper
    {
        // 1. Nhập mảng n phần tử
        public static int[] NhapMang(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            return arr;
        }

        // 2. In mảng
        public static void InMang(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("[] (Mang rong)");
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // 3. Tìm phần tử lớn nhất và nhỏ nhất
        public static void TimMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }

        // Hàm kiểm tra số nguyên tố
        private static bool LaSoNguyenTo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // 4. Trả về mảng các số nguyên tố
        public static int[] LayDanhSachSoNguyenTo(int[] arr)
        {
            List<int> dsSNT = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (LaSoNguyenTo(arr[i]))
                {
                    dsSNT.Add(arr[i]);
                }
            }
            return dsSNT.ToArray();
        }
    }

    public static class Bai15_MangMotChieu
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 15: MẢNG 1 CHIỀU ===");

            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            // 1. Nhập mảng
            int[] arr = MangMotChieuHelper.NhapMang(n);

            // 2. In mảng
            Console.Write("\nMang vua nhap la: ");
            MangMotChieuHelper.InMang(arr);

            // 3. Tìm Max và Min
            int max, min;
            MangMotChieuHelper.TimMaxMin(arr, out max, out min);
            Console.WriteLine($"Phan tu lon nhat (Max): {max}");
            Console.WriteLine($"Phan tu nho nhat (Min): {min}");

            // 4. Lấy và in mảng các số nguyên tố
            int[] mangSNT = MangMotChieuHelper.LayDanhSachSoNguyenTo(arr);
            Console.Write("Cac so nguyen to trong mang: ");
            MangMotChieuHelper.InMang(mangSNT);
        }
    }
}
