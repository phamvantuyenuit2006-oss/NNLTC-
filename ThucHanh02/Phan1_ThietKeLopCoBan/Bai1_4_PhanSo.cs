using System;

namespace ThucHanh02.Phan1_ThietKeLopCoBan
{
    /// <summary>
    /// BÀI 1.4: THIẾT KẾ LỚP PHÂN SỐ
    /// Đầy đủ Constructor, ToString, và Overload các toán tử 1 ngôi, 2 ngôi, so sánh
    /// </summary>
    public class PhanSo
    {
        // 1. Fields
        private int _tuSo;
        private int _mauSo;

        // 2. Properties
        public int TuSo
        {
            get => _tuSo;
            set => _tuSo = value;
        }

        public int MauSo
        {
            get => _mauSo;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Mau so khong the bang 0.");
                _mauSo = value;
            }
        }

        // 3. Constructors
        // Constructor mac nhien: 0/1
        public PhanSo()
        {
            _tuSo = 0;
            _mauSo = 1;
        }

        // Constructor 1 tham so (so nguyen): n/1
        public PhanSo(int tuSo)
        {
            _tuSo = tuSo;
            _mauSo = 1;
        }

        // Constructor 2 tham so: tu/mau
        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
                throw new ArgumentException("Mau so khong the bang 0.");

            _tuSo = tuSo;
            _mauSo = mauSo;
            RutGon();
        }

        // Constructor sao chep (Copy constructor)
        public PhanSo(PhanSo other)
        {
            if (other != null)
            {
                _tuSo = other._tuSo;
                _mauSo = other._mauSo;
            }
            else
            {
                _tuSo = 0;
                _mauSo = 1;
            }
        }

        // 4. Methods
        // Tim uoc chung lon nhat
        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Rut gon phan so
        public void RutGon()
        {
            if (_mauSo < 0)
            {
                _tuSo = -_tuSo;
                _mauSo = -_mauSo;
            }

            int ucln = UCLN(_tuSo, _mauSo);
            if (ucln > 1)
            {
                _tuSo /= ucln;
                _mauSo /= ucln;
            }
        }

        public void Input()
        {
            Console.Write("Nhap tu so: ");
            int.TryParse(Console.ReadLine(), out _tuSo);

            do
            {
                Console.Write("Nhap mau so (khac 0): ");
                int.TryParse(Console.ReadLine(), out _mauSo);
                if (_mauSo == 0) Console.WriteLine("Mau so phai khac 0! Vui long nhap lai.");
            } while (_mauSo == 0);

            RutGon();
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            if (_mauSo == 1) return $"{_tuSo}";
            if (_tuSo == 0) return "0";
            return $"{_tuSo}/{_mauSo}";
        }

        public double ToDouble()
        {
            return (double)_tuSo / _mauSo;
        }

        // 5. Overload toán tử 1 ngôi
        public static PhanSo operator +(PhanSo a)
        {
            return new PhanSo(a);
        }

        public static PhanSo operator -(PhanSo a)
        {
            if (a == null) return new PhanSo(0, 1);
            return new PhanSo(-a.TuSo, a.MauSo);
        }

        // 6. Overload toán tử 2 ngôi (+, -, *, /)
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            if (a == null) return new PhanSo(b);
            if (b == null) return new PhanSo(a);
            int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mau = a.MauSo * b.MauSo;
            return new PhanSo(tu, mau);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            if (a == null) return -b;
            if (b == null) return new PhanSo(a);
            int tu = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            int mau = a.MauSo * b.MauSo;
            return new PhanSo(tu, mau);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            if (a == null || b == null) return new PhanSo(0, 1);
            int tu = a.TuSo * b.TuSo;
            int mau = a.MauSo * b.MauSo;
            return new PhanSo(tu, mau);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (a == null) return new PhanSo(0, 1);
            if (b == null || b.TuSo == 0) throw new DivideByZeroException("Khong the chia cho phan so bang 0.");
            int tu = a.TuSo * b.MauSo;
            int mau = a.MauSo * b.TuSo;
            return new PhanSo(tu, mau);
        }

        // 7. Overload toán tử so sánh (>, <, >=, <=, ==, !=)
        public static bool operator >(PhanSo a, PhanSo b)
        {
            return (a - b).TuSo > 0;
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return (a - b).TuSo < 0;
        }

        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return (a - b).TuSo >= 0;
        }

        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return (a - b).TuSo <= 0;
        }

        public static bool operator ==(PhanSo? a, PhanSo? b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.TuSo == b.TuSo && a.MauSo == b.MauSo;
        }

        public static bool operator !=(PhanSo? a, PhanSo? b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is PhanSo other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_tuSo, _mauSo);
        }
    }
}
