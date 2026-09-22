using System;

namespace ThucHanh02.Phan3_KeThuaDaHinh
{
    /// <summary>
    /// Interface so sánh 2 đối tượng tổng quát
    /// </summary>
    public interface IMyComparer<T>
    {
        int Compare(T? x, T? y);
    }

    /// <summary>
    /// BÀI 3.2: PHƯƠNG THỨC SẮP XẾP MẢNG TỔNG QUÁT BẰNG INTERFACE (MÔ PHỎNG Array.Sort)
    /// </summary>
    public static class ThuatToanSapXepInterface
    {
        // Thuật toán sắp xếp tổng quát (Selection Sort / Bubble Sort) dùng IMyComparer<T>
        public static void SapXep<T>(T[] arr, IMyComparer<T> comparer)
        {
            if (arr == null || comparer == null || arr.Length <= 1) return;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer.Compare(arr[j], arr[minIdx]) < 0)
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

    // Bộ so sánh điểm giảm dần
    public class SoSanhDiemGiamDan : IMyComparer<SinhVienSortable>
    {
        public int Compare(SinhVienSortable? x, SinhVienSortable? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            return y.DiemTB.CompareTo(x.DiemTB); // Giảm dần
        }
    }

    // Bộ so sánh họ tên theo thứ tự bảng chữ cái
    public class SoSanhTheoTen : IMyComparer<SinhVienSortable>
    {
        public int Compare(SinhVienSortable? x, SinhVienSortable? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            return string.Compare(x.HoTen, y.HoTen, StringComparison.OrdinalIgnoreCase);
        }
    }
}
