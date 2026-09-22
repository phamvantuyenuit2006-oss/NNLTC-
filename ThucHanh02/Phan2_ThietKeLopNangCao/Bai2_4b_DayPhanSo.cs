using System;
using System.Collections.Generic;
using ThucHanh02.Phan1_ThietKeLopCoBan;

namespace ThucHanh02.Phan2_ThietKeLopNangCao
{
    /// <summary>
    /// BÀI 2.4 (DÃY PHÂN SỐ): XÂY DỰNG LỚP CHỨA N PHÂN SỐ VÀ TÍNH TỔNG N PHÂN SỐ
    /// </summary>
    public class DayPhanSo
    {
        // 1. Field
        private List<PhanSo> _danhSach;

        // 2. Properties & Indexer
        public int Count => _danhSach.Count;

        public PhanSo this[int i]
        {
            get
            {
                if (i < 0 || i >= _danhSach.Count)
                    throw new IndexOutOfRangeException($"Chi so {i} nam ngoai pham vi [0, {_danhSach.Count - 1}].");
                return _danhSach[i];
            }
            set
            {
                if (i < 0 || i >= _danhSach.Count)
                    throw new IndexOutOfRangeException($"Chi so {i} nam ngoai pham vi [0, {_danhSach.Count - 1}].");
                _danhSach[i] = value ?? new PhanSo();
            }
        }

        // 3. Constructors
        public DayPhanSo()
        {
            _danhSach = new List<PhanSo>();
        }

        public DayPhanSo(IEnumerable<PhanSo> items)
        {
            _danhSach = new List<PhanSo>();
            if (items != null)
            {
                foreach (var ps in items)
                {
                    _danhSach.Add(new PhanSo(ps));
                }
            }
        }

        public DayPhanSo(DayPhanSo other)
        {
            _danhSach = new List<PhanSo>();
            if (other != null)
            {
                for (int i = 0; i < other.Count; i++)
                {
                    _danhSach.Add(new PhanSo(other[i]));
                }
            }
        }

        // 4. Methods
        public void Add(PhanSo ps)
        {
            if (ps != null)
            {
                _danhSach.Add(ps);
            }
        }

        // Tính tổng n phân số
        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in _danhSach)
            {
                tong = tong + ps;
            }
            tong.RutGon();
            return tong;
        }

        public void Input()
        {
            Console.Write("Nhap so luong phan so n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                _danhSach.Clear();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhap phan so thu {i + 1} ---");
                    PhanSo ps = new PhanSo();
                    ps.Input();
                    _danhSach.Add(ps);
                }
            }
        }

        public void Output()
        {
            if (_danhSach.Count == 0)
            {
                Console.WriteLine("Day phan so rong []");
                return;
            }

            Console.WriteLine($"Day phan so ({Count} phan tu): " + string.Join(", ", _danhSach));
            Console.WriteLine($"Tong day phan so = {TinhTong()}");
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", _danhSach) + "]";
        }
    }
}
