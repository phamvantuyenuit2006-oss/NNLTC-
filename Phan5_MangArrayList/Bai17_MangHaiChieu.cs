using System;
using System.Collections.Generic;

namespace NNLTC.Phan5_MangArrayList
{
    /// <summary>
    /// BÀI 17: MẢNG 2 CHIỀU (SINH NGẪU NHIÊN [10, 100], TÁCH CHẴN LẺ)
    /// </summary>
    public class MangHaiChieuHelper
    {
        // 1. Sinh ngẫu nhiên ma trận n dòng x m cột trong khoảng [10, 100]
        public static int[,] SinhMaTran(int n, int m)
        {
            Random rd = new Random();
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rd.Next(10, 101); // Lấy ngẫu nhiên từ 10 đến 100
                }
            }
            return a;
        }

        // 2. In ma trận ra màn hình
        public static void InMaTran(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        // 3. Tách ma trận thành 2 mảng: mảng số chẵn và mảng số lẻ
        public static void TachChanLe(int[,] a, int n, int m, out int[] mangChan, out int[] mangLe)
        {
            List<int> dsChan = new List<int>();
            List<int> dsLe = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        dsChan.Add(a[i, j]);
                    }
                    else
                    {
                        dsLe.Add(a[i, j]);
                    }
                }
            }

            mangChan = dsChan.ToArray();
            mangLe = dsLe.ToArray();
        }
    }

    public static class Bai17_MangHaiChieu
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 17: MẢNG HAI CHIỀU ===");

            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine() ?? "0");

            // 1. Sinh mảng ngẫu nhiên
            int[,] a = MangHaiChieuHelper.SinhMaTran(n, m);

            // 2. In mảng
            Console.WriteLine("\nMa tran ngau nhien [10, 100]:");
            MangHaiChieuHelper.InMaTran(a, n, m);

            // 3. Tách mảng chẵn và lẻ
            int[] mangChan, mangLe;
            MangHaiChieuHelper.TachChanLe(a, n, m, out mangChan, out mangLe);

            Console.WriteLine($"\nMang cac so chan ({mangChan.Length} so): [{string.Join(", ", mangChan)}]");
            Console.WriteLine($"Mang cac so le ({mangLe.Length} so):   [{string.Join(", ", mangLe)}]");
        }
    }
}
