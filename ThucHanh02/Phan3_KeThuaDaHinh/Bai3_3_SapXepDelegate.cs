using System;

namespace ThucHanh02.Phan3_KeThuaDaHinh
{
    // Định nghĩa delegate so sánh
    public delegate int HamSoSanh<T>(T a, T b);

    /// <summary>
    /// BÀI 3.3: SẮP XẾP MẢNG TỔNG QUÁT BẰNG DELEGATE
    /// </summary>
    public static class ThuatToanSapXepDelegate
    {
        public static void SapXep<T>(T[] arr, HamSoSanh<T> soSanh)
        {
            if (arr == null || soSanh == null || arr.Length <= 1) return;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (soSanh(arr[j], arr[minIdx]) < 0)
                    {
                        minIdx = j;
                    }
                }
                if (minIdx != i)
                {
                    T temp = arr[i];
                    arr[i] = arr[minIdx];
                    arr[minIdx] = temp;
                }
            }
        }
    }
}
