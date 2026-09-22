using System;
using System.Collections.Generic;

namespace ThucHanh02.Phan2_ThietKeLopNangCao
{
    /// <summary>
    /// BÀI 2.3: LỚP CHỨA MẢNG 1 CHIỀU (DÃY SỐ NGUYÊN)
    /// </summary>
    public class DaySo
    {
        // 1. Field
        private int[] _arr;

        // 2. Properties & Indexer
        public int Length => _arr.Length;

        // b. Indexer để truy cập phần tử thứ i trong dãy
        public int this[int i]
        {
            get
            {
                if (i < 0 || i >= _arr.Length)
                    throw new IndexOutOfRangeException($"Chi so {i} nam ngoai pham vi [0, {_arr.Length - 1}].");
                return _arr[i];
            }
            set
            {
                if (i < 0 || i >= _arr.Length)
                    throw new IndexOutOfRangeException($"Chi so {i} nam ngoai pham vi [0, {_arr.Length - 1}].");
                _arr[i] = value;
            }
        }

        // 3. a. Các loại Constructor
        // Default Constructor: mảng rỗng
        public DaySo()
        {
            _arr = Array.Empty<int>();
        }

        // Parameter Constructor với số lượng n phần tử
        public DaySo(int n)
        {
            if (n < 0) n = 0;
            _arr = new int[n];
        }

        // Parameter Constructor từ mảng có sẵn
        public DaySo(int[] src)
        {
            if (src != null)
            {
                _arr = new int[src.Length];
                Array.Copy(src, _arr, src.Length);
            }
            else
            {
                _arr = Array.Empty<int>();
            }
        }

        // Copy Constructor
        public DaySo(DaySo other)
        {
            if (other != null)
            {
                _arr = new int[other.Length];
                for (int i = 0; i < other.Length; i++)
                {
                    _arr[i] = other[i];
                }
            }
            else
            {
                _arr = Array.Empty<int>();
            }
        }

        // 4. c. Nhập / Xuất dãy số
        public void Input()
        {
            Console.Write("Nhap so phan tu n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                _arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"a[{i}] = ");
                    int.TryParse(Console.ReadLine(), out _arr[i]);
                }
            }
        }

        public void Output()
        {
            if (_arr.Length == 0)
            {
                Console.WriteLine("Day so rong []");
                return;
            }

            Console.WriteLine($"Day so ({_arr.Length} phan tu): " + string.Join(", ", _arr));
        }

        // 5. d. Tìm các số chẵn trong dãy
        public DaySo TimCacSoChan()
        {
            List<int> chanList = new List<int>();
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] % 2 == 0)
                {
                    chanList.Add(_arr[i]);
                }
            }
            return new DaySo(chanList.ToArray());
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", _arr) + "]";
        }
    }
}
