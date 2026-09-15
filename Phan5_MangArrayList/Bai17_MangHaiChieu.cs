using System;
using System.Collections.Generic;

namespace NNLTC.Phan5_MangArrayList
{
    /// <summary>
    /// Bài 17: Mảng 2 chiều
    /// • Sinh ngẫu nhiên mảng A[nxm] trong đoạn [10, 100] (n,m nhập từ bàn phím)
    /// • In mảng ra màn hình
    /// • Trả về hai mảng: mảng các số chẵn và mảng các số lẻ
    /// </summary>
    public class MangHaiChieuHelper
    {
        private static readonly Random random = new Random();

        public static int[,] SinhMangNgauNhien(int n, int m, int minVal = 10, int maxVal = 100)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Next(min, max + 1) để lấy giá trị trong đoạn [minVal, maxVal]
                    matrix[i, j] = random.Next(minVal, maxVal + 1);
                }
            }
            return matrix;
        }

        public static void InMaTran(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            Console.WriteLine($"Ma tran A [{n}x{m}]:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        public static void TachChanLe(int[,] matrix, out int[] mangChan, out int[] mangLe)
        {
            List<int> dsChan = new List<int>();
            List<int> dsLe = new List<int>();

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int val = matrix[i, j];
                    if (val % 2 == 0)
                    {
                        dsChan.Add(val);
                    }
                    else
                    {
                        dsLe.Add(val);
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
            Console.WriteLine("=== BAI 17: MANG HAI CHIEU (SINH NGAU NHIEN [10, 100], TACH CHAN LE) ===");
            int n, m;

            while (true)
            {
                Console.Write("Nhap so dong n (n > 0): ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("So dong phai la so nguyen duong!");
            }

            while (true)
            {
                Console.Write("Nhap so cot m (m > 0): ");
                if (int.TryParse(Console.ReadLine(), out m) && m > 0)
                {
                    break;
                }
                Console.WriteLine("So cot phai la so nguyen duong!");
            }

            int[,] matrix = MangHaiChieuHelper.SinhMangNgauNhien(n, m, 10, 100);
            Console.WriteLine("\n--- MA TRAN DUOC SINH NGAU NHIEN ---");
            MangHaiChieuHelper.InMaTran(matrix);

            MangHaiChieuHelper.TachChanLe(matrix, out int[] mangChan, out int[] mangLe);

            Console.WriteLine("\n--- KET QUA PHAN LOAI CHAN LE ---");
            Console.WriteLine($"Mang cac so chan ({mangChan.Length} phan tu): [{string.Join(", ", mangChan)}]");
            Console.WriteLine($"Mang cac so le ({mangLe.Length} phan tu):   [{string.Join(", ", mangLe)}]");
        }
    }
}
