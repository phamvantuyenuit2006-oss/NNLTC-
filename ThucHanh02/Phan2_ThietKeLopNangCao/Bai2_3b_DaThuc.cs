using System;
using System.Collections.Generic;
using System.Text;
using ThucHanh02.Phan1_ThietKeLopCoBan;

namespace ThucHanh02.Phan2_ThietKeLopNangCao
{
    /// <summary>
    /// BÀI 2.3 (ĐA THỨC): XÂY DỰNG LỚP ĐA THỨC GỒM n+1 ĐƠN THỨC
    /// P(x) = a0*x^0 + a1*x^1 + a2*x^2 + ... + an*x^n
    /// </summary>
    public class DaThuc
    {
        // 1. Field: Mảng các đơn thức
        private DonThuc[] _donThucs;

        // 2. Properties
        public int Bac => _donThucs.Length - 1;

        // b. Indexer để truy cập đơn thức thứ i (bậc i)
        public DonThuc this[int i]
        {
            get
            {
                if (i < 0 || i >= _donThucs.Length)
                    throw new IndexOutOfRangeException($"Bac {i} nam ngoai pham vi [0, {Bac}].");
                return _donThucs[i];
            }
            set
            {
                if (i < 0 || i >= _donThucs.Length)
                    throw new IndexOutOfRangeException($"Bac {i} nam ngoai pham vi [0, {Bac}].");
                _donThucs[i] = value ?? new DonThuc(0, i);
            }
        }

        // 3. a. Các loại Constructor
        // Default Constructor: Da thuc bac 0: P(x) = 0
        public DaThuc()
        {
            _donThucs = new DonThuc[1];
            _donThucs[0] = new DonThuc(0, 0);
        }

        // Parameter Constructor voi bac n (gom n + 1 don thuc tu bac 0 den n)
        public DaThuc(int bac)
        {
            if (bac < 0) bac = 0;
            _donThucs = new DonThuc[bac + 1];
            for (int i = 0; i <= bac; i++)
            {
                _donThucs[i] = new DonThuc(0, i);
            }
        }

        // Parameter Constructor từ mảng các hệ số a0, a1, ..., an
        public DaThuc(double[] heSos)
        {
            if (heSos != null && heSos.Length > 0)
            {
                _donThucs = new DonThuc[heSos.Length];
                for (int i = 0; i < heSos.Length; i++)
                {
                    _donThucs[i] = new DonThuc(heSos[i], i);
                }
            }
            else
            {
                _donThucs = new DonThuc[1];
                _donThucs[0] = new DonThuc(0, 0);
            }
        }

        // Copy Constructor
        public DaThuc(DaThuc other)
        {
            if (other != null)
            {
                _donThucs = new DonThuc[other.Bac + 1];
                for (int i = 0; i <= other.Bac; i++)
                {
                    _donThucs[i] = new DonThuc(other[i]);
                }
            }
            else
            {
                _donThucs = new DonThuc[1];
                _donThucs[0] = new DonThuc(0, 0);
            }
        }

        // 4. c. Nhập / Xuất
        public void Input()
        {
            Console.Write("Nhap bac cua da thuc n (n >= 0): ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n < 0) n = 0;

            _donThucs = new DonThuc[n + 1];
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Nhap he so a{i} (cho x^{i}): ");
                double.TryParse(Console.ReadLine(), out double a);
                _donThucs[i] = new DonThuc(a, i);
            }
        }

        public void Output()
        {
            Console.WriteLine("P(x) = " + ToString());
        }

        // 5. d. Tính giá trị của đa thức với giá trị x
        public double TinhGiaTri(double x)
        {
            double sum = 0;
            for (int i = 0; i < _donThucs.Length; i++)
            {
                sum += _donThucs[i].TinhGiaTri(x);
            }
            return sum;
        }

        public override string ToString()
        {
            List<string> terms = new List<string>();
            for (int i = 0; i < _donThucs.Length; i++)
            {
                if (_donThucs[i].HeSo != 0 || _donThucs.Length == 1)
                {
                    terms.Add(_donThucs[i].ToString());
                }
            }
            return terms.Count > 0 ? string.Join(" + ", terms) : "0";
        }
    }
}
