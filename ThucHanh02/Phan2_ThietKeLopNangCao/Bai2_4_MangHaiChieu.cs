using System;
using System.Collections.Generic;

namespace ThucHanh02.Phan2_ThietKeLopNangCao
{
    /// <summary>
    /// BÀI 2.4: LỚP CHỨA MẢNG 2 CHIỀU (KÍCH THƯỚC N x M)
    /// </summary>
    public class MangHaiChieu
    {
        // 1. Field
        private int[,] _matrix;
        private int _rows;
        private int _cols;

        // 2. Properties
        public int Rows => _rows;
        public int Cols => _cols;

        // b. Indexer để truy cập phần tử tại vị trí (i, j)
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= _rows || j < 0 || j >= _cols)
                    throw new IndexOutOfRangeException($"Vi tri ({i}, {j}) nam ngoai kich thuoc [{_rows}, {_cols}].");
                return _matrix[i, j];
            }
            set
            {
                if (i < 0 || i >= _rows || j < 0 || j >= _cols)
                    throw new IndexOutOfRangeException($"Vi tri ({i}, {j}) nam ngoai kich thuoc [{_rows}, {_cols}].");
                _matrix[i, j] = value;
            }
        }

        // 3. a. Các loại Constructor
        // Default Constructor: 1x1
        public MangHaiChieu()
        {
            _rows = 1;
            _cols = 1;
            _matrix = new int[1, 1];
        }

        // Parameter Constructor
        public MangHaiChieu(int rows, int cols)
        {
            _rows = rows > 0 ? rows : 1;
            _cols = cols > 0 ? cols : 1;
            _matrix = new int[_rows, _cols];
        }

        // Copy Constructor
        public MangHaiChieu(MangHaiChieu other)
        {
            if (other != null)
            {
                _rows = other.Rows;
                _cols = other.Cols;
                _matrix = new int[_rows, _cols];
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        _matrix[i, j] = other[i, j];
                    }
                }
            }
            else
            {
                _rows = 1;
                _cols = 1;
                _matrix = new int[1, 1];
            }
        }

        // 4. c. Nhập / Xuất
        public void Input()
        {
            Console.Write("Nhap so dong (rows): ");
            int.TryParse(Console.ReadLine(), out _rows);
            if (_rows <= 0) _rows = 1;

            Console.Write("Nhap so cot (cols): ");
            int.TryParse(Console.ReadLine(), out _cols);
            if (_cols <= 0) _cols = 1;

            _matrix = new int[_rows, _cols];

            Console.WriteLine($"Nhap cac phan tu cho ma tran {_rows}x{_cols}:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write($"M[{i}, {j}] = ");
                    int.TryParse(Console.ReadLine(), out _matrix[i, j]);
                }
            }
        }

        public void Output()
        {
            Console.WriteLine($"Ma tran 2 chieu ({_rows} dong x {_cols} cot):");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write($"{_matrix[i, j],6} ");
                }
                Console.WriteLine();
            }
        }

        // 5. d. Tìm các số nguyên tố trong mảng
        private static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public List<int> TimCacSoNguyenTo()
        {
            List<int> sntList = new List<int>();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (LaSoNguyenTo(_matrix[i, j]))
                    {
                        sntList.Add(_matrix[i, j]);
                    }
                }
            }
            return sntList;
        }

        public override string ToString()
        {
            return $"MangHaiChieu[{_rows}x{_cols}]";
        }
    }
}
