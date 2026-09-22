using System;

namespace ThucHanh02.Phan1_ThietKeLopCoBan
{
    /// <summary>
    /// BÀI 1.5: XÂY DỰNG LỚP ĐƠN THỨC P(x) = a * x^n
    /// (a) Tính giá trị đơn thức với x cho trước
    /// (b) Đạo hàm đơn thức Q(x) = P'(x) = a * n * x^(n-1)
    /// </summary>
    public class DonThuc
    {
        // 1. Fields
        private double _heSo; // a
        private int _soMu;    // n (so nguyen khong am)

        // 2. Properties
        public double HeSo
        {
            get => _heSo;
            set => _heSo = value;
        }

        public int SoMu
        {
            get => _soMu;
            set => _soMu = value < 0 ? 0 : value;
        }

        // 3. Constructors
        // Default Constructor: P(x) = 0 * x^0
        public DonThuc()
        {
            _heSo = 0.0;
            _soMu = 0;
        }

        // Parameter Constructor
        public DonThuc(double heSo, int soMu)
        {
            _heSo = heSo;
            _soMu = soMu < 0 ? 0 : soMu;
        }

        // Copy Constructor
        public DonThuc(DonThuc other)
        {
            if (other != null)
            {
                _heSo = other._heSo;
                _soMu = other._soMu;
            }
            else
            {
                _heSo = 0.0;
                _soMu = 0;
            }
        }

        // 4. Methods
        // (a) Tính giá trị đơn thức P(x) = a * x^n
        public double TinhGiaTri(double x)
        {
            return _heSo * Math.Pow(x, _soMu);
        }

        // (b) Đạo hàm đơn thức: Q(x) = P'(x) = a * n * x^(n - 1)
        public DonThuc DaoHam()
        {
            if (_soMu == 0)
            {
                return new DonThuc(0, 0);
            }
            double heSoMoi = _heSo * _soMu;
            int soMuMoi = _soMu - 1;
            return new DonThuc(heSoMoi, soMuMoi);
        }

        // Nhap don thuc
        public void Input()
        {
            Console.Write("Nhap he so a: ");
            double.TryParse(Console.ReadLine(), out _heSo);

            do
            {
                Console.Write("Nhap so mu n (n >= 0): ");
                int.TryParse(Console.ReadLine(), out _soMu);
                if (_soMu < 0) Console.WriteLine("So mu phai khong am! Vui long nhap lai.");
            } while (_soMu < 0);
        }

        // Xuat don thuc
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            if (_heSo == 0) return "0";
            if (_soMu == 0) return $"{_heSo}";
            if (_soMu == 1) return $"{_heSo}x";
            return $"{_heSo}x^{_soMu}";
        }
    }
}
